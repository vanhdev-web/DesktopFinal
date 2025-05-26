using OOP.Forms; // IAddMeetingView
using OOP.Models; // ModelUser, Meeting, Project
using OOP.Services; // MeetingService, ProjectManager
using System;
using System.Collections.Generic;
using System.ComponentModel;
using ModelUser = OOP.Models.User;

namespace OOP.Presenters
{
    public class AddMeetingPresenter
    {
        private IAddMeetingView _view;
        private MeetingService _meetingService;
        private ProjectManager _projectManager; // [cite: 45]

        public AddMeetingPresenter(IAddMeetingView view)
        {
            _view = view;
            _meetingService = new MeetingService();
            _projectManager = new ProjectManager(); // [cite: 45]
        }

        public void InitializeProjects()
        {
            List<string> projectNames = new List<string>();

            if (ModelUser.LoggedInUser == null) return; // Kiểm tra user đăng nhập [cite: 47]

            foreach (Project project in _projectManager.Projects) // [cite: 47]
            {
                if (project == null || project.members == null) continue; // Kiểm tra null tránh lỗi [cite: 47, 48]

                Console.WriteLine($"Project: {project.projectID} - {project.projectName}, AdminID: {project.AdminID}, Members: {string.Join(", ", project.members)}"); // [cite: 48]
                bool isMember = false; // [cite: 49]
                foreach (string member in project.members) // [cite: 49]
                {
                    string memberUsername = member.Split('(')[0].Trim(); // Lấy username trước dấu "(" và Trim() [cite: 49]
                    if (memberUsername == ModelUser.LoggedInUser.Username) // [cite: 49, 50]
                    {
                        isMember = true; // [cite: 50]
                        break;
                    }
                }

                if (project.AdminID == ModelUser.LoggedInUser.ID || isMember) // [cite: 51]
                {
                    projectNames.Add(project.projectName); // [cite: 51]
                }
            }
            _view.SetProjects(projectNames);
        }

        public void ConfirmMeeting()
        {
            string location = _view.MeetingLocation; // [cite: 23]
            DateTime meetingTime = _view.MeetingTime; // [cite: 24]
            string hour = _view.MeetingHour; // [cite: 24]
            string taskName = _view.MeetingName; // [cite: 24]
            string status = "Unfinished"; // [cite: 24]
            string projectName = _view.SelectedProjectName; // [cite: 24]

            int projectId = _meetingService.GetProjectIdByName(projectName); // [cite: 25, 27]

            if (projectId == 0) // [cite: 27]
            {
                _view.DisplayErrorMessage("Dự án không tồn tại."); // [cite: 27]
                return; // [cite: 28]
            }

            List<ModelUser> members = _meetingService.GetProjectMembers(projectId); // [cite: 37]

            if (members.Count == 0) // [cite: 38]
            {
                _view.DisplayErrorMessage("Không có thành viên nào thuộc dự án này."); // [cite: 38]
                return; // [cite: 39]
            }

            // Create the meeting
            Meeting newMeeting = _meetingService.CreateMeeting(taskName, status, meetingTime, location, hour, projectId); // [cite: 39, 40, 41, 42]

            // Add meeting members
            _meetingService.AddMeetingMembers(newMeeting.taskID, members); // [cite: 42, 43, 44]

            _view.CloseView(newMeeting); // [cite: 45]
        }

        public void ValidateMeetingName(string meetingName, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(meetingName)) // [cite: 52]
            {
                _view.CancelValidation(e, true); // [cite: 52]
                _view.SetMeetingNameError("Please enter task name!"); // [cite: 52]
            }
            else
            {
                _view.CancelValidation(e, false); // [cite: 53, 54]
                _view.SetMeetingNameError(null); // [cite: 54, 55]
            }
        }
    }
}