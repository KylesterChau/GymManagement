using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementApplication.Classes
{
    class Equipment
    {
        int equipmentID { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        bool isAvailable { get; set; }
        DateTime lastMaintenanceDate { get; set; }
        public Equipment(int equipmentID, string name, string type, bool isAvailable, DateTime lastMaintenanceDate)
        {
            this.equipmentID = equipmentID;
            Name = name;
            Type = type;
            this.isAvailable = isAvailable;
            this.lastMaintenanceDate = lastMaintenanceDate;
        } 
        public void scheduleMaintenance(DateTime date)
        {
            lastMaintenanceDate = date;
            isAvailable = false;
        }
        public string getEquipmentStatus() 
        {
            return "";
        }
    }
}
