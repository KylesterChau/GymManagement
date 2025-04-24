using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Classes
{
    public class AppState
    {
        //Properties for the AppState class used for login purposes
        public string username { get; set; }
        public string password { get; set; }
        public bool loggedIn { get; set; } = false;
    }
}
