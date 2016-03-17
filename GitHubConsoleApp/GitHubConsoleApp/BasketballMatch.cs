// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BasketballMatch.cs" company="Win Technologies">
//   Copyright Win Technologies
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace GitHubConsoleApp
{
    using System;

    /// <summary>
    /// The basketball match.
    /// </summary>
    internal class BasketballMatch
    {
        /// <summary>
        /// Gets the home score.
        /// </summary>
        public int HomeScore
        {
            get
            {
                var r = new Random();
                return r.Next(0, 100); // for ints
            }
        }

        /// <summary>
        /// Gets the away score.
        /// </summary>
        public int AwayScore
        {
            get
            {
                var r = new Random();
                return r.Next(0, 100); // for ints
            }
        }
    }
}