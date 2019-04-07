using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.VaporWinterSale
{
    class GameInfo
    {
        public string Title { get; set; }
        public string Dlc { get; set; }
        public decimal Price { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var gamesWithNoDlc = new Dictionary<string, decimal>();
            var gamesWithDlc = new Dictionary<string, GameInfo>();
            var gameInput = Console.ReadLine().Split(", ");

            for (int i = 0; i < gameInput.Length; i++)
            {
                var gameCheck = gameInput[i];
                if (gameCheck.Contains(':'))
                {
                    var dlcGame = gameCheck.Split(":");
                    var currentGame = dlcGame[0];
                    var dlc = dlcGame[1];

                    if (gamesWithNoDlc.ContainsKey(currentGame))
                    {
                        decimal price = gamesWithNoDlc[currentGame];
                        price += price * 0.2M;
                        GameInfo game = new GameInfo
                        {
                            Title = currentGame,
                            Dlc = dlc,
                            Price = price
                        };
                        gamesWithDlc.Add(currentGame, game);
                }
            }
                else if (gameCheck.Contains('-'))
                {
                    var gameI = gameCheck.Split("-");
                    var currentGame = gameI[0];
                    decimal price = decimal.Parse(gameI[1]);
                    if (!gamesWithNoDlc.ContainsKey(currentGame))
                    {
                        gamesWithNoDlc.Add(currentGame, price);
                    }
                }
        }
            foreach (var game in gamesWithDlc)
            {
                string name = game.Key;

                foreach (var item in gamesWithDlc)
                {
                    if (name.Contains(item.Key))
                    {
                        gamesWithNoDlc.Remove(item.Key);
                    }
                    
                }

            }

            foreach (var item in gamesWithDlc.OrderBy(x => x.Value.Price))
            {
                Console.WriteLine($"{item.Value.Title} - {item.Value.Dlc} - {item.Value.Price / 2.0M:F2}");
            }
            foreach (var item in gamesWithNoDlc.OrderByDescending(x => x.Value))
            {
                decimal discountPrice = item.Value;
                discountPrice -= discountPrice * 0.2M;
                Console.WriteLine($"{item.Key} - {discountPrice:F2}");
            }
    }
}
}
