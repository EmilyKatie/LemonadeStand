using System;

namespace LemonadeStand

{
    public class Player
    {

        double money;
        Inventory inventory = new Inventory();




        public void BuyLemons()
        {
            Console.WriteLine("How many lemons do you want? They each cost .10.");
            string numberOfLemons = Console.ReadLine();
            int Lemons = Int32.Parse(numberOfLemons);

            double LemonPrice = .10;
            double Cost = LemonPrice * Lemons;

            if (money >= Cost)
            {
                money -= Cost;
                inventory.Lemon += Lemons;

            }
        }
        public void BuySugar()
        {
            Console.WriteLine("How many cups of sugar do you want? Each cup cost .25.");
            string cupsOfSugar = Console.ReadLine();
            int Sugar = Int32.Parse(cupsOfSugar);

            double SugarPrice = .25;
            double CostOfSugar = SugarPrice * Sugar;

            if (money >= CostOfSugar)
            {
                money -= CostOfSugar;
                inventory.Sugar += Sugar; 

            }

        }
        public void BuyIce()
        {
            Console.WriteLine("How many ice cubes would you like to make your Lemonade ice cold? They cost .03 each.");
            string iceCubes = Console.ReadLine();
            int Ice = Int32.Parse(iceCubes);

            double IcePrice = .03;
            double CostofIce = IcePrice * Ice;

            if (money >= CostofIce)
            {

                money -= CostofIce;
                inventory.Ice += Ice;
        
            }
    }
    
}
