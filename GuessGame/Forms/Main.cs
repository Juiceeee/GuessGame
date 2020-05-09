using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessGame
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            gameObject = new Game();
            UpdateTries(gameObject.TriesLeft);
          
        }

        Game gameObject;

        private void UpdateTries(int triesLeft)
        {
            L_Tries.Text = $@"Tries: {triesLeft}";
        }

        private void BTN_Guess_Click(object sender, EventArgs e)
        {
            // TODO: Generate a random value between 0 - 100

            var result = gameObject.GuessNumber(Convert.ToInt32(NUD_Value.Value));

            bool wonGame = false;

            // Loop the game tries until won is true
           
                // Check if run out of tries
                if (gameObject.TriesLeft == 0)
                {
                    // Reset();
                    L_Result.Text = "You lost game. Secret number was: " + gameObject.RandomNumber;          
                   // Restart();
                }
                else // Continue guessing
                {
                    // Get the next guess
                    int currentGuess = Convert.ToInt32(NUD_Value.Value);

                    // Validate the guess with the random value
                    if (currentGuess > gameObject.RandomNumber)
                    {
                        // Decrease tries
                        gameObject.TriesLeft--;
                    // Update 
                    UpdateTries(gameObject.TriesLeft);
                    // Guess too high
                    L_Result.Text = "Try lower.";
                }
                    else if (currentGuess < gameObject.RandomNumber)
                    {
                        // Decrease tries
                        gameObject.TriesLeft--;
                    // Update 
                    UpdateTries(gameObject.TriesLeft);
                    // Guess too low
                    
                    L_Result.Text = "Try higher.";
                }
                    else
                    {
                        // Won the game
                        wonGame = true;

                        MessageBox.Show(@"Correct guess!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        L_Result.Text = "Secret number is: " + gameObject.RandomNumber;
                        
                       
                       // Restart();
                    }
                }
            

           
        }
    
   
    }
}
