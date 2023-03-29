namespace GamerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                BirthYear = 1996,
                FirstName = "Muhammed Ali",
                Id = 1,
                LastName = "TUNÇDEMİR",
                IdentityNumber = 1234567891
            });

            // Fake Doğrulama Oluşturup Sorgusunu Yaparsak;
            GamerManager gamerManager1 = new GamerManager(new NewEStateUserValidationManager());
            gamerManager1.Add(new Gamer 
            { 
                BirthYear = 2035, 
                FirstName = "Muhammed Ali", 
                Id = 1, LastName = "TUNÇDEMİR", 
                IdentityNumber = 678910 
            });
        }
    }
}