using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    [Serializable] // Thêm attribute Serializable để có thể serialize object
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; } // Thêm username
        public RoleType Role { get; set; }  // Kiểm tra dòng này có tồn tại không
        public string Password { get; set; } // Thêm password
        public string Email { get; set; } // Thêm email
        public byte[] Avatar { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();
        public List<User> Friends { get; set; } = new List<User>();
        public List<User> allUsers = new List<User>();
        public static User LoggedInUser { get; set; } // Đây là người dùng đã đăng nhập, ví dụ "admin"

        public User(int id, string username, RoleType role, string password, string email)
        {
            ID = id;
            Username = username;
            Role = role;
            Password = password;
            Email = email;
        }
        public static void Login(string username, RoleType role)
        {
            // Tạo một đối tượng User và gán cho LoggedInUser
            LoggedInUser = new User(1, username, RoleType.Member, "123", "OOP@.com"); // Ví dụ, ID = 1, bạn có thể thay bằng cách tạo ID tự động
        }

        // Phương thức để lấy thông tin người dùng đăng nhập
        public static string GetLoggedInUserName()
        {
            return LoggedInUser?.Username ?? "No user logged in"; // Trả về tên người dùng nếu đã đăng nhập
        }

        // Phương thức để kiểm tra xem người dùng có đăng nhập không
        public static bool IsLoggedIn()
        {
            return LoggedInUser != null;
        }
        public User() { } // Constructor mặc định cho việc deserialize
    }
}