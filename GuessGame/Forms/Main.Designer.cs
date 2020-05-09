namespace GuessGame
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Guess = new System.Windows.Forms.Button();
            this.NUD_Value = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.L_Tries = new System.Windows.Forms.Label();
            this.L_Result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Value)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Guess
            // 
            this.BTN_Guess.Location = new System.Drawing.Point(12, 138);
            this.BTN_Guess.Name = "BTN_Guess";
            this.BTN_Guess.Size = new System.Drawing.Size(75, 23);
            this.BTN_Guess.TabIndex = 0;
            this.BTN_Guess.Text = "Guess";
            this.BTN_Guess.UseVisualStyleBackColor = true;
            this.BTN_Guess.Click += new System.EventHandler(this.BTN_Guess_Click);
            // 
            // NUD_Value
            // 
            this.NUD_Value.Location = new System.Drawing.Point(23, 81);
            this.NUD_Value.Name = "NUD_Value";
            this.NUD_Value.Size = new System.Drawing.Size(120, 20);
            this.NUD_Value.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Value:";
            // 
            // L_Tries
            // 
            this.L_Tries.AutoSize = true;
            this.L_Tries.Location = new System.Drawing.Point(22, 21);
            this.L_Tries.Name = "L_Tries";
            this.L_Tries.Size = new System.Drawing.Size(42, 13);
            this.L_Tries.TabIndex = 3;
            this.L_Tries.Text = "Tries: 0";
            // 
            // L_Result
            // 
            this.L_Result.AutoSize = true;
            this.L_Result.Location = new System.Drawing.Point(93, 143);
            this.L_Result.Name = "L_Result";
            this.L_Result.Size = new System.Drawing.Size(164, 13);
            this.L_Result.TabIndex = 4;
            this.L_Result.Text = "Guess the value between 0 - 100";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 188);
            this.Controls.Add(this.L_Result);
            this.Controls.Add(this.L_Tries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUD_Value);
            this.Controls.Add(this.BTN_Guess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Guess Game";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Guess;
        private System.Windows.Forms.NumericUpDown NUD_Value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_Tries;
        private System.Windows.Forms.Label L_Result;
    }
}

