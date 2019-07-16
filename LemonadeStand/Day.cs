using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Day
    {
        public string inventory;

        List<Customer> customers = new List<Customer>();
        public Weather Weather = new Weather();
        public Player Player = new Player();

        public Day()
        {

        }

        public void GenerateCustomers()
        {

            Random random = new Random();

            for (int i = 0; i < 30; i++)
            {
                Customer customer = new Customer();
                customer.AssignMoneyFactor();
                customer.AssignTemperatureFactor();
                
                customer.Funds();
                customer.Flavortown();
                
                if (customer.money <= 0.25 && customer.temperature >= 80)
                {
                    customers.Add(customer);
                    
                    Console.WriteLine(true);
                    customer.money -= 0.25;
                    //Player.inventory += 0.25;
                   
                }
                    else
                {
                    Console.WriteLine(false);

                }
                if (customer.money <= 0.50 && customer.temperature >= 90)
                {
                    customers.Add(customer);
                    Console.WriteLine(true);
                    customer.money -= 0.50;

                }
                else
                {
                    Console.WriteLine(false);
                }
                if (customer.money <= 0.75 && customer.temperature >= 105)
                {
                    customers.Add(customer);
                    Console.WriteLine(true);
                    customer.money -= 0.75;

                }
                    else
                {
                    Console.WriteLine(false);
                }


                if (customer.money <= 0.60 && customer.temperature <= 95)
                {
                    customers.Add(customer);
                    Console.WriteLine(true);
                    customer.money -= 0.60;
                }
                    else
                {
                    Console.WriteLine(false);
                }
                

                if (customer.money <= 0.65 && customer.temperature < 99)
                 {
                    customers.Add(customer);
                    Console.WriteLine(true);
                    customer.money -= 0.65;
                }
                    else
                {
                    Console.WriteLine(false);
                }

                if (customer.money <= 0.20 && customer.temperature <= 75)
                {
                    customers.Add(customer);
                    Console.WriteLine(true);
                    customer.money -= 0.20;
                }
                else
                {
                    Console.WriteLine(false);
                }
                if (customer.money <= 0.15 && customer.temperature <= 55)
                {
                    customers.Add(customer);
                    Console.WriteLine(true);
                    customer.money -= 0.15;

                }
                else
                {
                    Console.WriteLine(false);
                }
            }



            


            //logic to assign a thirst, money, and temperature preference


    }

}            


//Customer customer = new Customer();
                //string[] customers = 
            
        //public void ecipeIngredients()
        //public List<Inventory> inventoryList;


        //public string weather;
        
        //public Day(string weather) 
        

           
            //customerList = new List<Customer>();
            
                //String Customer.Add(Zombie);
                //Customer.Add()
            
        
        
    }
}

