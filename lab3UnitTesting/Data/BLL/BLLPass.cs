using lab3UnitTesting.Models;

namespace lab3UnitTesting.Data.BLL
{
    public class BLLPass
    {
        Irespiratory<Pass> repo;
        public BLLPass(Irespiratory<Pass> repository)
        {
            repo = repository;
        }

        public void CreatePass(Pass pass)
        {
            if (pass.Purchaser.Length >= 3 && pass.Purchaser.Length <= 20)
            {
                repo.Create(pass);
            }
            else
            {
                throw new Exception("Purchaser argument should between 3 and 20characters long");
            }

        }
    }
}