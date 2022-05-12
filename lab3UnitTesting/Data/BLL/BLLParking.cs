using lab3UnitTesting.Models;

namespace lab3UnitTesting.Data.BLL
{
    public class BLLParking
    {
        Irespiratory<ParkingSpace> repo;
        public BLLParking(Irespiratory<ParkingSpace> r)
        {
            repo = r;
        }

        public void CreateParkingSpace(ParkingSpace p)
        {
            if (p.Number < 1)
            {
                throw new Exception("Number should larger than zero");
            }
            else
            {
                repo.Create(p);
            }
        }
    }
}