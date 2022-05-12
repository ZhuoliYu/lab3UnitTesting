namespace lab3UnitTesting.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        public bool Parked { get; set; }

        public ICollection<Reservation> Reservations { get; set; }

        public Vehicle()
        {
            Reservations = new HashSet<Reservation>();
        }
    }
}