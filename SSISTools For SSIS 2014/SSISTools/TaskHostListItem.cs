using Microsoft.SqlServer.Dts.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSISTools
{
    public class TaskHostListItem: ListViewItem
    {
        public TaskHost TaskHost { get; set; }
        public bool IsScriptTask { get; set; }
        public string ConnectionName { get; set; }

        public TaskHostListItem(TaskHost taskHost)
        {
            InitData(taskHost);
        }

        private void InitData(TaskHost taskHost)
        {
            this.TaskHost = taskHost;
            this.IsScriptTask = GetIsScriptTask(this.TaskHost);
            this.ConnectionName = this.GetTaskConnection(this.TaskHost);
            SetColumnData();
        }

        public TaskHostListItem(Executable executable)
        {
            if (executable is TaskHost)
            {
                InitData((TaskHost)executable);
            }
        }

        private void SetColumnData()
        {
            base.Text = this.TaskHost.Name;
            if (!this.IsScriptTask)
                base.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(162)));

            base.SubItems.Add(new ListViewSubItem() { Text = (this.IsScriptTask ? "Y" : "N")});
            base.SubItems.Add(new ListViewSubItem() { Text = this.ConnectionName});
        }

        private bool GetIsScriptTask(TaskHost task)
        {
            foreach (var p in task.Properties)
            {
                if (p.Name == "SqlStatementSource")
                    return true;
            }

            return false;
        }

        private string GetTaskConnection(TaskHost task)
        {
            if (task == null)
                return null;

            foreach (var p in task.Properties)
            {
                if (p.Name == "Connection")
                {
                    try
                    {
                        return (string)p.GetValue(task);
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                }
            }

            return null;
        }
    }
}
