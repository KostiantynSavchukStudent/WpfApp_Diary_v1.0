using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Diary_v1._0.src.models
{
    public class User
    {
        long IdUser { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }
        string Email { get; set; }
        string Pass { get; set; }
        DateTime Birth { get; set; }
        string CurrentLocation { get; set; }
        DateTime CreatedAt { get; set; }

        User(string Firstname, string Lastname, string Email, string Pass, DateTime Birth, string CurrentLocation)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Email = Email;
            this.Pass = Pass;
            this.Birth = Birth;
            this.CurrentLocation = CurrentLocation;
            CreatedAt = DateTime.Now;
        }
    }
}
