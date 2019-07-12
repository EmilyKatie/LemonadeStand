using System;
namespace LemonadeStand
{
    public class Player
    {
        Player player = new Player();
        Console.WriteLine(player.Lemon);
        player.Lemon -= 50;
        Console.WriteLine(player.Lemon);


        public Player()
        {
        }
    }
    
}
