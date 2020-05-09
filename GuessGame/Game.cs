using System;

namespace GuessGame
{
    /// <summary>
    /// The <see cref="Game" /> class.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// The maximum range.
        /// </summary>
        public const int MaxRange = 100;


        /// <summary>
        /// The maximum tries.
        /// </summary>
        public const int MaxTries = 10;
        /// <summary>
        /// Gets or sets the random number.
        /// </summary>
        /// <value>The random number.</value>
        public int RandomNumber { get; set;  }


        /// <summary>
        /// Gets or sets the tries left.
        /// </summary>
        /// <value>The tries left.</value>
        public int TriesLeft { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Game"/> class.
        /// </summary>
        public Game()
        {
            ResetGame();
        }

        /// <summary>
        /// Resets the game.
        /// </summary>
        public void ResetGame()
        {
            TriesLeft = MaxTries;
            // Randomize number
            RandomNumber = new Random().Next(MaxRange);
        }

        /// <summary>
        /// Guesses the number.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>When the <see cref="System.Boolean"/> value is set to <see langword="true" /> guess number; otherwise <see langword="false" />.</returns>
        public bool GuessNumber(int value)
        {
            if (value == RandomNumber)
            {
                return true;
            }
            else
            {
                return false;
            }           
        }
    }
}