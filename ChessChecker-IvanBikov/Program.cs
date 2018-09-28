using ChessDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessChecker_IvanBikov
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"Game.pgn");

            ChessGame game = new ChessGame();
            PgnReader<ChessGame> pgnReader = new PgnReader<ChessGame>();
            try
            {
                pgnReader.ReadPgnFromString(text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("V partiqta ima greshen hod!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Partiqta e vqrna.");
            Console.ReadKey();
        }
    }
}
