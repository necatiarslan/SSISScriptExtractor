using Microsoft.SqlServer.Dts.Runtime;
using Microsoft.SqlServer.Dts.Tasks.ScriptTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace SSISTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string[] args)
        {
            InitializeComponent();
            this.arguments = args;
        }

        string[] arguments;

        Microsoft.SqlServer.Dts.Runtime.Application app = new Microsoft.SqlServer.Dts.Runtime.Application();
        Package package;

        private void btnPaclageFileSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "SSIS Package (*.dtsx)|*.dtsx";
            if (file.ShowDialog() == DialogResult.OK)
            {
                txtSsisPackageFile.Text = file.FileName;
                LoadScriptComponentList();
            }
        }

        private void LoadScriptComponentList()
        {
            if (!System.IO.File.Exists(txtSsisPackageFile.Text))
                return;
            
            try
            {
                package = app.LoadPackage(txtSsisPackageFile.Text, null);

                listView1.Items.Clear();
                FillScriptComponentList(package.Executables);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FillScriptComponentList(Executables executables)
        {
            foreach (Executable executable in executables)
            {               
                if (executable is TaskHost)
                {
                    if (ShowOnlyScriptTasksCheckBox.Checked && !IsScriptTask((TaskHost)executable))
                        continue;

                    listView1.Items.Add(new TaskHostListItem(executable));
                }
                    

                if (executable is Sequence)
                    FillScriptComponentList(((Sequence)executable).Executables);
            }  
        }
        
        private string GetSqlStatementSource(TaskHost task)
        {
            if (task == null)
                return null;

            foreach (var p in task.Properties)
            {
                if (p.Name == "SqlStatementSource")
                {
                    try
                    {
                        return (string)p.GetValue(task);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        return null;
                    }
                }
            }

            return null;
        }

        private void btnSaveScriptFile_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
                return;


            if (listView1.SelectedItems.Count == 1)
            {
                TaskHost taskHost = ((TaskHostListItem)listView1.SelectedItems[0]).TaskHost;

                SaveTaskHost(taskHost);            
            }
            else
            {
                foreach (TaskHostListItem taskHost in listView1.Items)
                {
                    SaveTaskHost(taskHost.TaskHost);
                }
            }
        }

        private void SaveTaskHost(TaskHost taskHost)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.RestoreDirectory = true;
            file.InitialDirectory = System.IO.Path.GetDirectoryName(txtSsisPackageFile.Text);
            file.Filter = "Sql Script (*.sql)|*.sql";
            file.FileName = package.Name + " - " + taskHost.Name;

            if (SaveFileToNearCheckBox.Checked || file.ShowDialog() == DialogResult.OK)
            {
                string sqlStatementSource = GetSqlStatementSource(taskHost);

                if (sqlStatementSource == null)
                    return;

                string selectedFile;
                if (SaveFileToNearCheckBox.Checked)
                    selectedFile = Path.Combine(file.InitialDirectory, file.FileName + ".sql");
                else
                    selectedFile = file.FileName;

                System.IO.File.WriteAllText(selectedFile, sqlStatementSource);
            }
        }

        private void btnPathSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if(folder.ShowDialog() == DialogResult.OK)
            {
                txtSourceFolder.Text = folder.SelectedPath;
                txtDestFolder.Text = folder.SelectedPath;
                FillPackageList();
            }
        }

        private void FillPackageList()
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(txtSourceFolder.Text);
            IEnumerable<System.IO.FileInfo> fileList = dir.GetFiles("*.dtsx", System.IO.SearchOption.AllDirectories);

            var queryMatchingFiles =
            from file in fileList
            select file.FullName;

            lstPackageList.Items.Clear();

            foreach (string file in queryMatchingFiles.ToArray<string>())
            {
                lstPackageList.Items.Add(new PackageListItem(file));
            }
            
        }

        private void btnDestFolderSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                txtDestFolder.Text = folder.SelectedPath;
            }
        }

        private void btnPackageListScriptSave_Click(object sender, EventArgs e)
        {
            if (lstPackageList.Items.Count == 0)
                return;

            if (!System.IO.Directory.Exists(txtDestFolder.Text))
                return;

            try
            { 
                foreach(PackageListItem packageListItem in lstPackageList.Items)
                {
                    package = app.LoadPackage(packageListItem.FileName, null);

                    LoopExecutablesToSaveTaskScript(package.Executables, Path.GetDirectoryName(packageListItem.FileName));
                }

                MessageBox.Show("Save Successful ...");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoopExecutablesToSaveTaskScript(Executables executables, string packagePath)
        {

            foreach (Executable executable in executables)
            {
                if (executable is TaskHost)
                {
                    TaskHost task = (TaskHost)executable;
                    if (IsScriptTask(task))
                    {
                        string sqlStatementSource = GetSqlStatementSource(task);

                        string fileName;
                        if (SaveAllFilesToNearCheckBox.Checked)
                        {
                            fileName = System.IO.Path.Combine(packagePath, package.Name + " - " + task.Name + ".sql");

                            if (System.IO.File.Exists(fileName))
                                fileName = System.IO.Path.Combine(packagePath, package.Name + " - " + task.Name + "_" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + "-" + DateTime.Now.Millisecond.ToString() + ".sql");                        
                        }
                        else
                        {
                            fileName = System.IO.Path.Combine(txtDestFolder.Text, package.Name + " - " + task.Name + ".sql");

                            if (System.IO.File.Exists(fileName))
                                fileName = System.IO.Path.Combine(txtDestFolder.Text, package.Name + " - " + task.Name + "_" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + "-" + DateTime.Now.Millisecond.ToString() + ".sql");                        
                        }

                        System.IO.File.WriteAllText(fileName, sqlStatementSource);
                    }
                }

                if (executable is Sequence)
                {
                    LoopExecutablesToSaveTaskScript(((Sequence)executable).Executables, packagePath);
                }

            }
        }

        private bool IsScriptTask(TaskHost task)
        {
            foreach(var p in task.Properties)
            {
                if(p.Name == "SqlStatementSource")
                    return true;
            }

            return false;
        }

        private void txtSourceFolder_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtSourceFolder_DragDrop(object sender, DragEventArgs e)
        {
            string[] folders = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            
            if (folders.Length == 0)
                return;
            

            txtSourceFolder.Text = folders[0];
            txtDestFolder.Text = folders[0];
            FillPackageList();
        }

        private void txtSsisPackageFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtSsisPackageFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (files.Length == 0)
                return;

            if (!files[0].Contains("dtsx"))
                return;

            txtSsisPackageFile.Text = files[0];
            LoadScriptComponentList();
        }

        private void btnPreviewSql_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            //string sql = GetSqlStatementSourceFromTask((string)listView1.SelectedItem);
            string sql = GetSqlStatementSource(((TaskHostListItem)listView1.SelectedItems[0]).TaskHost);

            SqlPreviewForm frm = new SqlPreviewForm();
            frm.SqlStatementSource = sql;
            frm.SaveFileName = package.Name + " - " + ((TaskHostListItem)listView1.SelectedItems[0]).TaskHost.Name;
            frm.Show();
        }

        private void lstPackageList_DoubleClick(object sender, EventArgs e)
        {
            if (lstPackageList.SelectedItem == null)
                return;

            txtSsisPackageFile.Text = ((PackageListItem)lstPackageList.SelectedItem).FileName;
            LoadScriptComponentList();

            tabControl1.SelectedIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text += " v." + Assembly.GetEntryAssembly().GetName().Version.ToString();

            if(this.arguments != null && this.arguments.Length > 0)
            {
                if (System.IO.Path.GetExtension(this.arguments[0]) != ".dtsx")
                {
                    MessageBox.Show("Invalid File Extension : " + System.IO.Path.GetExtension(this.arguments[0]));
                    return;
                }

                if(System.IO.File.Exists(this.arguments[0]))
                {
                    txtSsisPackageFile.Text = this.arguments[0];
                    LoadScriptComponentList();
                }
            }
        }

        private void listView1_DoubleClick_1(object sender, EventArgs e)
        {
            btnPreviewSql.PerformClick();
        }

        private void ShowOnlyScriptTasksCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadScriptComponentList();
        }

    }
    
}
