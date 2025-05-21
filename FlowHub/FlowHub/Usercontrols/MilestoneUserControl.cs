using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP.Models;
using OOP.Services;

namespace OOP.Usercontrols
{
    public partial class MilestoneUserControl : UserControl
    {
        private Milestone milestone;  // Tham chiếu đến Milestone gốc
        public event EventHandler<Milestone> OnTaskFinished;

        public Panel TaskPanel // Thuộc tính công khai để truy cập Panel
        {
            get { return panel9; } // panelContainer là tên Panel bên trong TaskControl
        }

        public MilestoneUserControl(Milestone milestone)
        {
            InitializeComponent();
            this.milestone = milestone;
            UpdateUI();
        }

        private void UpdateUI()
        {
            taskContent.Text = milestone.taskName;
            taskProject.Text = milestone.ProjectName;
            taskDeadline.Text = $"{milestone.deadline:dd/MM/yyyy}";
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            if (milestone.status == "Finished")
            {
                checkBox.Image = Properties.Resources.check;
            }
            else
            {
                checkBox.Image = Properties.Resources.checkUnfinished;
            }
        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            if (milestone.status == "Finished")
            {
                milestone.status = "UnFinished"; // Cập nhật trạng thái Meeting gốc
            }
            else
            {
                milestone.status = "Finished"; // Cập nhật trạng thái Meeting gốc
            }

            UpdateButtonState();
            OnTaskFinished?.Invoke(this, milestone);
            TaskManager.GetInstance().UpdateTask(milestone);

            // Chỉ gửi thông báo nếu trạng thái thực sự thay đổi thành "Finished"
            if (milestone.status == "Finished")
            {
                NotificationManager.Instance.SendTaskUpdateNotification(User.GetLoggedInUserName(), milestone.taskName, milestone.status);
            }
        }
    }
}