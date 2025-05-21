using OOP.Services;
using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using OOP.Usercontrols;

namespace OOP.Models
{
    public enum RoleType
    {
        Admin,
        Member
    }

    public class Project
    {
        public  int projectID { get; set; }
        public string projectName { get; set; }
        public string projectDescription { get; set; }
        public List<Task> tasks = new List<Task>();
        public List<string> members { get; set; } = new List<string>();
        public int AdminID { get; set; }
        public string AdminName { get; set; }
        public string CreatedBy { get; set; }
        public Project() { }
        public RoleType UserRole { get; private set; }
    


        public Project(int projectID, string projectName, string projectDescription, RoleType role)
        {
            this.projectID = projectID;
            this.projectName = projectName;
            this.projectDescription = projectDescription;
            this.UserRole = role;

        }
        public Project(int projectID, string projectName, string projectDescription, RoleType role, int adminID, string adminName, string createdBy)
        {
            this.projectID = projectID;
            this.projectName = projectName;
            this.projectDescription = projectDescription;
            this.UserRole = role;
            this.AdminID = adminID;
            this.AdminName = adminName;
            this.members = new List<string> { $"{createdBy} (Admin)" };
        }
        public Project(int id, string name, string description)
        {
            this.projectID = id;
            projectName = name;
            projectDescription = description;
            members = new List<string>();
        }
        public void AddTask(Task task)
        {
            if (UserRole == RoleType.Admin || UserRole == RoleType.Member)
            {
                tasks.Add(task);
            }
            else
            {
                throw new UnauthorizedAccessException("Only Admins and Members can add tasks.");
            }

        }
        public void AssignTask(Task task, User assignee)
        {
            if (assignee.Role != RoleType.Member)
            {
                throw new InvalidOperationException("Chỉ thành viên (Member) mới có thể được gán task!");
            }

            tasks.Add(task);

            // Gửi thông báo cho Member khi nhận task
          
        }


        public void RemoveTask(Task task)
        {
            if (UserRole == RoleType.Admin)
            {
                tasks.Remove(task);
            }
            else
            {
                throw new UnauthorizedAccessException("Only Admins can remove tasks.");
            }
        }
        //operator +
        public static Project operator +(Project project, string memberInfo)
        {
            if (project != null && !string.IsNullOrWhiteSpace(memberInfo) && !project.members.Contains(memberInfo))
            {
                project.members.Add(memberInfo);
            }
            return project; // Trả về chính đối tượng Project
        }


    }
}