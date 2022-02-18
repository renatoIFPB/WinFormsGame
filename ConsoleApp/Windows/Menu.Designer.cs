
namespace ConsoleApp.Windows
{
    partial class Menu
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
            this.NewCharacter = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ShowCharacter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewCharacter
            // 
            this.NewCharacter.Location = new System.Drawing.Point(61, 53);
            this.NewCharacter.Name = "NewCharacter";
            this.NewCharacter.Size = new System.Drawing.Size(127, 27);
            this.NewCharacter.TabIndex = 0;
            this.NewCharacter.Text = "New Character";
            this.NewCharacter.UseVisualStyleBackColor = true;
            this.NewCharacter.Click += new System.EventHandler(this.NewCharacter_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(61, 372);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ShowCharacter
            // 
            this.ShowCharacter.Location = new System.Drawing.Point(61, 101);
            this.ShowCharacter.Name = "ShowCharacter";
            this.ShowCharacter.Size = new System.Drawing.Size(127, 23);
            this.ShowCharacter.TabIndex = 2;
            this.ShowCharacter.Text = "Show Character";
            this.ShowCharacter.UseVisualStyleBackColor = true;
            this.ShowCharacter.Click += new System.EventHandler(this.ShowCharacter_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.ShowCharacter);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NewCharacter);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewCharacter;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button ShowCharacter;
    }
}