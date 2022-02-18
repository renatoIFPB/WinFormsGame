
namespace ConsoleApp.Windows
{
    partial class CreateCharacter
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Strength = new System.Windows.Forms.Label();
            this.Dexterity = new System.Windows.Forms.Label();
            this.Agility = new System.Windows.Forms.Label();
            this.Intelligence = new System.Windows.Forms.Label();
            this.Constitution = new System.Windows.Forms.Label();
            this.StrengthValue = new System.Windows.Forms.NumericUpDown();
            this.DexterityValue = new System.Windows.Forms.NumericUpDown();
            this.AgilityValue = new System.Windows.Forms.NumericUpDown();
            this.IntelligenceValue = new System.Windows.Forms.NumericUpDown();
            this.ConstitutionValue = new System.Windows.Forms.NumericUpDown();
            this.NewName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.Points = new System.Windows.Forms.Label();
            this.CountAttributes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StrengthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DexterityValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgilityValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntelligenceValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConstitutionValue)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(328, 294);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(222, 294);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 1;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Strength
            // 
            this.Strength.AutoSize = true;
            this.Strength.Location = new System.Drawing.Point(58, 132);
            this.Strength.Name = "Strength";
            this.Strength.Size = new System.Drawing.Size(62, 17);
            this.Strength.TabIndex = 4;
            this.Strength.Text = "Strength";
            // 
            // Dexterity
            // 
            this.Dexterity.AutoSize = true;
            this.Dexterity.Location = new System.Drawing.Point(58, 176);
            this.Dexterity.Name = "Dexterity";
            this.Dexterity.Size = new System.Drawing.Size(63, 17);
            this.Dexterity.TabIndex = 5;
            this.Dexterity.Text = "Dexterity";
            // 
            // Agility
            // 
            this.Agility.AutoSize = true;
            this.Agility.Location = new System.Drawing.Point(58, 222);
            this.Agility.Name = "Agility";
            this.Agility.Size = new System.Drawing.Size(45, 17);
            this.Agility.TabIndex = 6;
            this.Agility.Text = "Agility";
            // 
            // Intelligence
            // 
            this.Intelligence.AutoSize = true;
            this.Intelligence.Location = new System.Drawing.Point(224, 132);
            this.Intelligence.Name = "Intelligence";
            this.Intelligence.Size = new System.Drawing.Size(79, 17);
            this.Intelligence.TabIndex = 7;
            this.Intelligence.Text = "Intelligence";
            this.Intelligence.Click += new System.EventHandler(this.Intelligence_Click);
            // 
            // Constitution
            // 
            this.Constitution.AutoSize = true;
            this.Constitution.Location = new System.Drawing.Point(224, 176);
            this.Constitution.Name = "Constitution";
            this.Constitution.Size = new System.Drawing.Size(82, 17);
            this.Constitution.TabIndex = 8;
            this.Constitution.Text = "Constitution";
            this.Constitution.Click += new System.EventHandler(this.Constitution_Click);
            // 
            // StrengthValue
            // 
            this.StrengthValue.Location = new System.Drawing.Point(134, 132);
            this.StrengthValue.Name = "StrengthValue";
            this.StrengthValue.Size = new System.Drawing.Size(57, 22);
            this.StrengthValue.TabIndex = 9;
            this.StrengthValue.ValueChanged += new System.EventHandler(this.StrengthValue_ValueChanged);
            // 
            // DexterityValue
            // 
            this.DexterityValue.Location = new System.Drawing.Point(135, 176);
            this.DexterityValue.Name = "DexterityValue";
            this.DexterityValue.Size = new System.Drawing.Size(57, 22);
            this.DexterityValue.TabIndex = 10;
            this.DexterityValue.ValueChanged += new System.EventHandler(this.DexterityValue_ValueChanged);
            // 
            // AgilityValue
            // 
            this.AgilityValue.Location = new System.Drawing.Point(135, 222);
            this.AgilityValue.Name = "AgilityValue";
            this.AgilityValue.Size = new System.Drawing.Size(57, 22);
            this.AgilityValue.TabIndex = 11;
            this.AgilityValue.ValueChanged += new System.EventHandler(this.AgilityValue_ValueChanged);
            // 
            // IntelligenceValue
            // 
            this.IntelligenceValue.Location = new System.Drawing.Point(320, 130);
            this.IntelligenceValue.Name = "IntelligenceValue";
            this.IntelligenceValue.Size = new System.Drawing.Size(57, 22);
            this.IntelligenceValue.TabIndex = 12;
            this.IntelligenceValue.ValueChanged += new System.EventHandler(this.IntelligenceValue_ValueChanged);
            // 
            // ConstitutionValue
            // 
            this.ConstitutionValue.Location = new System.Drawing.Point(320, 176);
            this.ConstitutionValue.Name = "ConstitutionValue";
            this.ConstitutionValue.Size = new System.Drawing.Size(57, 22);
            this.ConstitutionValue.TabIndex = 13;
            this.ConstitutionValue.ValueChanged += new System.EventHandler(this.ConstitutionValue_ValueChanged);
            // 
            // NewName
            // 
            this.NewName.Location = new System.Drawing.Point(132, 40);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(160, 22);
            this.NewName.TabIndex = 14;
            this.NewName.TextChanged += new System.EventHandler(this.NewName_TextChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(58, 44);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 17);
            this.name.TabIndex = 15;
            this.name.Text = "Name";
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.Location = new System.Drawing.Point(58, 87);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(116, 17);
            this.Points.TabIndex = 17;
            this.Points.Text = "Points Remain  - ";
            // 
            // CountAttributes
            // 
            this.CountAttributes.AutoSize = true;
            this.CountAttributes.Location = new System.Drawing.Point(168, 87);
            this.CountAttributes.Name = "CountAttributes";
            this.CountAttributes.Size = new System.Drawing.Size(24, 17);
            this.CountAttributes.TabIndex = 18;
            this.CountAttributes.Text = "20";
            // 
            // CreateCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 355);
            this.Controls.Add(this.CountAttributes);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.name);
            this.Controls.Add(this.NewName);
            this.Controls.Add(this.ConstitutionValue);
            this.Controls.Add(this.IntelligenceValue);
            this.Controls.Add(this.AgilityValue);
            this.Controls.Add(this.DexterityValue);
            this.Controls.Add(this.StrengthValue);
            this.Controls.Add(this.Constitution);
            this.Controls.Add(this.Intelligence);
            this.Controls.Add(this.Agility);
            this.Controls.Add(this.Dexterity);
            this.Controls.Add(this.Strength);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Cancel);
            this.Name = "CreateCharacter";
            this.Text = "New Character";
            this.Load += new System.EventHandler(this.CreateCharacter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StrengthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DexterityValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgilityValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntelligenceValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConstitutionValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label Strength;
        private System.Windows.Forms.Label Dexterity;
        private System.Windows.Forms.Label Agility;
        private System.Windows.Forms.Label Intelligence;
        private System.Windows.Forms.Label Constitution;
        private System.Windows.Forms.NumericUpDown StrengthValue;
        private System.Windows.Forms.NumericUpDown DexterityValue;
        private System.Windows.Forms.NumericUpDown AgilityValue;
        private System.Windows.Forms.NumericUpDown IntelligenceValue;
        private System.Windows.Forms.NumericUpDown ConstitutionValue;
        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Points;
        private System.Windows.Forms.Label CountAttributes;
    }
}