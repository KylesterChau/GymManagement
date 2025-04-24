using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementApplication.Classes
{
    class Equipment
    {
        public int equipmentID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool isAvailable { get; set; }
        public DateTime lastMaintenanceDate { get; set; }
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
