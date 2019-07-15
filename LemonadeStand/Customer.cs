using System;
namespace LemonadeStand
{
    public class Customer

    {
        public string name;
        public bool thirst;
        public double money;
        public int temperature;
        public double wallet;
        public string taste;

        Customer customer = new Customer();



        public void Purchase()
        {
            thirst = true;
            Console.WriteLine("Are you feeling thirsty today? If yes, check weather and money");
            string Thirsty = Console.ReadLine();

            switch(Thirsty)
            {
                case "yes":
                    Console.WriteLine("Awesome! Enjoy your ice cold lemonade");
                    break;
                case "no":

                default:
                    break;
            }

        }

        public void AssignMoneyFactor()
        {
            Random random = new Random();
            money = random.Next(15, 80);

        }
        public void AssignTemperatureFactor()
        {
            Random random = new Random();
            temperature = random.Next(50, 105);

        }

        public void Funds()
        {
            Random random = new Random();
            wallet = random.Next(20);
        }


        public void Flavortown()
        {

            Random random = new Random();
            lemon = random.Next(0, 8);
            for (int i = 0; i < IngredientStrength)




        }
        private int lemon;

        public int Lemon
        {

            set
            {
                if ((int > 0) && (int < 9))
                {
                    int = 4;
                }
            }
        }


    }
}

//Inventory inventory = new Inventory();                                       //List<string> IngredientStrength = new List<string>();
//Console.WriteLine(customer.Lemon);
//customer.taste <= 0;
//Console.WriteLine(Customer.Lemon);






//Random random = new Random();
//int index = random.Next(0, 2);
//taste = IngredientStrength[index];




//if (Lemonade < 0.50)
//{
//    Console.WriteLine("I will purchase lemonade.");
//}
//public void Wallet()
//{
//    wallet  20