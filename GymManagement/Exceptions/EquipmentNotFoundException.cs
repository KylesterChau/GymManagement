using System;

namespace GymManagement.Exceptions
{
    public class EquipmentNotFoundException : Exception
    {
        public EquipmentNotFoundException() : base("Equipment not found.") { }

        public EquipmentNotFoundException(string message) : base(message) { }

        public EquipmentNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
}
