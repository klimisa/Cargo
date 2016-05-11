namespace Cargo.DomainModel.Models
{
    public class CarrierMovement
    {
        private int _scheduleId;

        public int ScheduleId
        {
            get { return _scheduleId; }
            set { _scheduleId = value; }
        }

        private Location _from;
        public Location From
        {
            get { return _from; }
            set { _from = value; }
        }

        private Location _to;
        public Location To
        {
            get { return _to; }
            set { _to = value; }
        }
    }
}
