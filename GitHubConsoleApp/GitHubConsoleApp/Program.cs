// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Win Technologies">
//   Copyright Win Technologies
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace GitHubConsoleApp
{
    using System;

    /// <summary>
    ///     The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Fingers crossed.");
            Console.WriteLine("Hello from the other side.");
            var gad = new MaGad();
            Console.WriteLine(gad.Hola);
            Console.WriteLine("Das ist the master - das ist gut");
            Console.WriteLine("Footie Match!!!!!");
            Console.WriteLine("I am working in the master branch right now...");
            Console.ReadLine();

            var bballMatch = new BasketballMatch();
            Console.WriteLine($"Home Score = {bballMatch.HomeScore} - Away Score = {bballMatch.AwayScore}");
            Console.ReadLine();
        }
    }
}