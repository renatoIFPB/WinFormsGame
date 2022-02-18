
namespace ConsoleApp.Windows
{
    partial class MenuGame
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
            this.inventory = new System.Windows.Forms.Button();
            this.buttonMarket = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inventory
            // 
            this.inventory.Location = new System.Drawing.Point(38, 41);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(80, 26);
            this.inventory.TabIndex = 0;
            this.inventory.Text = "Inventory";
            this.inventory.UseVisualStyleBackColor = true;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
            // 
            // buttonMarket
            // 
            this.buttonMarket.Location = new System.Drawing.Point(38, 74);
            this.buttonMarket.Name = "buttonMarket";
            this.buttonMarket.Size = new System.Drawing.Size(80, 23);
            this.buttonMarket.TabIndex = 1;
            this.buttonMarket.Text = "Market";
            this.buttonMarket.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(645, 396);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // MenuGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonMarket);
            this.Controls.Add(this.inventory);
            this.Name = "MenuGame";
            this.Text = "MenuGame";
            this.Load += new System.EventHandler(this.MenuGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Button buttonMarket;
        private System.Windows.Forms.Button buttonBack;
    }
}