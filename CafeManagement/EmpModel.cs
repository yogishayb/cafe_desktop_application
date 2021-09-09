using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement
{
    class EmpModel
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string EmpID { get; set; }

        private static string error = "User Does Not Exist...!";

        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }

        public static bool IsEqual(EmpModel user1, EmpModel user2)
        {
            if (user1 == null || user2 == null)
            {
                return false;
            }

            if (user1.Username != user2.Username)
            {
                error = "Username does not exist!";
                return false;
            }

            else if (user1.Password != user2.Password)
            {
                error = "Username and Password does not match!";
                return false;
            }

            return true;
        }


    }
}
