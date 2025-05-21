using System;
using System.Collections.Generic;
using System.Data;
using OOP.Models;
using OOP.Services;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace OOP.Models
{
    public abstract class AbaseTask : IComparable<AbaseTask>
    {
        private IUpdateStatus updateStatus;
        public string taskID { get; set; }

        public string ProjectName { get; set; }
        public string taskName { get; set; }
        public string status { get; set; }
        public DateTime deadline { get; set; }
        public int AssignedTo { get; set; } // ✅ Moved AssignedTo to AbaseTask

        public void SetUpdateStatus(IUpdateStatus updateStatus)
        {
            this.updateStatus = updateStatus;
        }
        public IUpdateStatus GetUpdateStatus()
        {
            return this.updateStatus;
        }

        public void UpdateStatus()
        {
            this.status = updateStatus.UpdateStatus(deadline);
        }

        public AbaseTask(string taskID, string taskName, string status, DateTime deadline, string ProjectName, int assignedTo)
        {
            this.taskID = taskID;
            this.taskName = taskName;
            this.status = status;
            this.deadline = deadline;
          this.ProjectName = ProjectName;
            this.AssignedTo = assignedTo; // ✅ Now all tasks have AssignedTo
        }

        public int CompareTo(AbaseTask other)
        {
            if (this.deadline < other.deadline) return -1;
            if (this.deadline > other.deadline) return 1;
            return 0;
        }

   

        public virtual void Message()
        {
            MessageBox.Show("");
        }
        public abstract void UpdateStatus(string newStatus);
    }



    public class Task : AbaseTask
    {


        public Task(string taskID, string taskName, string status, DateTime deadline, string projectName, int assignedTo)
            : base(taskID, taskName, status, deadline, projectName, assignedTo)
        {
           
        }

    
        public override void UpdateStatus(string newStatus)
        {
            status = newStatus;
        }
        public override void Message()
        {
            MessageBox.Show("Task đã được tạo");
        }
    }

    public class Meeting : AbaseTask
    {

        public string Location { get; set; }
        public List<User> Participants { get; set; }
        public string Hour { get; set; }

        public Meeting(string taskID, string taskName, string status, DateTime deadline, string hour,  string location, List<User> participants, string projectName, int assignedTo)
            : base(taskID, taskName, status, deadline, projectName, assignedTo)
        {
            Location = location;
            Participants = participants ?? new List<User>();
            Hour = hour;
        }

      
        public override void UpdateStatus(string newStatus)
        {
            status = newStatus;
        }
        public override void Message()
        {
            MessageBox.Show("Meeting đã được tạo");
        }
    }


    public class Milestone : AbaseTask
    {
        public string Description { get; set; }

        public Milestone(string taskID, string taskName, string status, DateTime deadline, string description, string projectName, int assignedTo)
            : base(taskID, taskName, status, deadline, projectName, assignedTo)
        {
            Description = description;
        }

      
        public override void UpdateStatus(string newStatus)
        {
            status = newStatus;
        }
        public override void Message()
        {
            MessageBox.Show("Milestone đã được tạo");
        }
    }


}

