// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BasketballMatch.cs" company="Win Technologies">
//   Copyright Win Technologies
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace GitHubConsoleApp
{
    using System;

    /// <summary>
    ///     The basketball match.
    /// </summary>
    internal class BasketballMatch
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasketballMatch"/> class.
        /// </summary>
        internal BasketballMatch()
        {
            this.R = new Random();
        }

        /// <summary>
        /// Gets the r.
        /// </summary>
        private Random R { get; }

        /// <summary>
        ///     Gets the home score.
        /// </summary>
        public int HomeScore => this.R.Next(0, 100);

        /// <summary>
        ///     Gets the away score.
        /// </summary>
        public int AwayScore => this.R.Next(0, 100);
    }
}