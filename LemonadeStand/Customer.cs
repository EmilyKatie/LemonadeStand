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

            switch (Thirsty)
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
            money = random.Next(10, 99);

        }
        public void AssignTemperatureFactor()
        {
            Random random = new Random();
            temperature = random.Next(45, 105);

        }

        public void Funds()
        {
            Random random = new Random();
            wallet = random.Next(20);
        }


        public void Flavortown()
        {
            public int Lemon { get; set; }

            public int Sugar { get; set; }
            public int Ice { get; set; }
        }
        
    }
}        //Random random = new Random();
            
            //for (int i = 0; i < IngredientStrength.customer; i++)
            //{
            //    Console.WriteLine();
            
        

       


    


//Inventory inventory = new Inventory();                     //List<string> IngredientStrength = new List<string>();
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