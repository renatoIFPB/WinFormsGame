
namespace ConsoleApp.Windows
{
    partial class ShowCharacter
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
            this.Back = new System.Windows.Forms.Button();
            this.ListCharacters = new System.Windows.Forms.ListBox();
            this.name = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.Strength = new System.Windows.Forms.Label();
            this.Dexterity = new System.Windows.Forms.Label();
            this.Agility = new System.Windows.Forms.Label();
            this.Intelligence = new System.Windows.Forms.Label();
            this.Constitution = new System.Windows.Forms.Label();
            this.Hp = new System.Windows.Forms.Label();
            this.Experience = new System.Windows.Forms.Label();
            this.Coin = new System.Windows.Forms.Label();
            this.valueStrength = new System.Windows.Forms.Label();
            this.valueAgility = new System.Windows.Forms.Label();
            this.valueDexterity = new System.Windows.Forms.Label();
            this.valueIntelligence = new System.Windows.Forms.Label();
            this.valueConstitution = new System.Windows.Forms.Label();
            this.valueHp = new System.Windows.Forms.Label();
            this.valueExperience = new System.Windows.Forms.Label();
            this.valueCoin = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(460, 222);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 30);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ListCharacters
            // 
            this.ListCharacters.FormattingEnabled = true;
            this.ListCharacters.ItemHeight = 16;
            this.ListCharacters.Location = new System.Drawing.Point(34, 57);
            this.ListCharacters.Name = "ListCharacters";
            this.ListCharacters.Size = new System.Drawing.Size(146, 148);
            this.ListCharacters.TabIndex = 4;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(34, 34);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 17);
            this.name.TabIndex = 5;
            this.name.Text = "Name";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Location = new System.Drawing.Point(121, 34);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(42, 17);
            this.level.TabIndex = 6;
            this.level.Text = "Level";
            // 
            // Strength
            // 
            this.Strength.AutoSize = true;
            this.Strength.Location = new System.Drawing.Point(210, 57);
            this.Strength.Name = "Strength";
            this.Strength.Size = new System.Drawing.Size(66, 17);
            this.Strength.TabIndex = 7;
            this.Strength.Text = " Strength";
            this.Strength.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dexterity
            // 
            this.Dexterity.AutoSize = true;
            this.Dexterity.Location = new System.Drawing.Point(210, 83);
            this.Dexterity.Name = "Dexterity";
            this.Dexterity.Size = new System.Drawing.Size(49, 17);
            this.Dexterity.TabIndex = 8;
            this.Dexterity.Text = " Agility";
            // 
            // Agility
            // 
            this.Agility.AutoSize = true;
            this.Agility.Location = new System.Drawing.Point(210, 112);
            this.Agility.Name = "Agility";
            this.Agility.Size = new System.Drawing.Size(67, 17);
            this.Agility.TabIndex = 9;
            this.Agility.Text = " Dexterity";
            // 
            // Intelligence
            // 
            this.Intelligence.AutoSize = true;
            this.Intelligence.Location = new System.Drawing.Point(210, 141);
            this.Intelligence.Name = "Intelligence";
            this.Intelligence.Size = new System.Drawing.Size(83, 17);
            this.Intelligence.TabIndex = 10;
            this.Intelligence.Text = " Intelligence";
            // 
            // Constitution
            // 
            this.Constitution.AutoSize = true;
            this.Constitution.Location = new System.Drawing.Point(210, 172);
            this.Constitution.Name = "Constitution";
            this.Constitution.Size = new System.Drawing.Size(86, 17);
            this.Constitution.TabIndex = 11;
            this.Constitution.Text = " Constitution";
            // 
            // Hp
            // 
            this.Hp.AutoSize = true;
            this.Hp.Location = new System.Drawing.Point(403, 57);
            this.Hp.Name = "Hp";
            this.Hp.Size = new System.Drawing.Size(31, 17);
            this.Hp.TabIndex = 12;
            this.Hp.Text = " HP";
            // 
            // Experience
            // 
            this.Experience.AutoSize = true;
            this.Experience.Location = new System.Drawing.Point(403, 83);
            this.Experience.Name = "Experience";
            this.Experience.Size = new System.Drawing.Size(30, 17);
            this.Experience.TabIndex = 13;
            this.Experience.Text = " XP";
            // 
            // Coin
            // 
            this.Coin.AutoSize = true;
            this.Coin.Location = new System.Drawing.Point(403, 112);
            this.Coin.Name = "Coin";
            this.Coin.Size = new System.Drawing.Size(40, 17);
            this.Coin.TabIndex = 14;
            this.Coin.Text = " Coin";
            // 
            // valueStrength
            // 
            this.valueStrength.AutoSize = true;
            this.valueStrength.Location = new System.Drawing.Point(301, 57);
            this.valueStrength.Name = "valueStrength";
            this.valueStrength.Size = new System.Drawing.Size(16, 17);
            this.valueStrength.TabIndex = 15;
            this.valueStrength.Text = "  ";
            // 
            // valueAgility
            // 
            this.valueAgility.AutoSize = true;
            this.valueAgility.Location = new System.Drawing.Point(301, 83);
            this.valueAgility.Name = "valueAgility";
            this.valueAgility.Size = new System.Drawing.Size(16, 17);
            this.valueAgility.TabIndex = 16;
            this.valueAgility.Text = "  ";
            // 
            // valueDexterity
            // 
            this.valueDexterity.AutoSize = true;
            this.valueDexterity.Location = new System.Drawing.Point(301, 112);
            this.valueDexterity.Name = "valueDexterity";
            this.valueDexterity.Size = new System.Drawing.Size(16, 17);
            this.valueDexterity.TabIndex = 17;
            this.valueDexterity.Text = "  ";
            // 
            // valueIntelligence
            // 
            this.valueIntelligence.AutoSize = true;
            this.valueIntelligence.Location = new System.Drawing.Point(301, 141);
            this.valueIntelligence.Name = "valueIntelligence";
            this.valueIntelligence.Size = new System.Drawing.Size(16, 17);
            this.valueIntelligence.TabIndex = 18;
            this.valueIntelligence.Text = "  ";
            // 
            // valueConstitution
            // 
            this.valueConstitution.AutoSize = true;
            this.valueConstitution.Location = new System.Drawing.Point(301, 172);
            this.valueConstitution.Name = "valueConstitution";
            this.valueConstitution.Size = new System.Drawing.Size(16, 17);
            this.valueConstitution.TabIndex = 19;
            this.valueConstitution.Text = "  ";
            // 
            // valueHp
            // 
            this.valueHp.AutoSize = true;
            this.valueHp.Location = new System.Drawing.Point(457, 57);
            this.valueHp.Name = "valueHp";
            this.valueHp.Size = new System.Drawing.Size(16, 17);
            this.valueHp.TabIndex = 20;
            this.valueHp.Text = "  ";
            // 
            // valueExperience
            // 
            this.valueExperience.AutoSize = true;
            this.valueExperience.Location = new System.Drawing.Point(457, 83);
            this.valueExperience.Name = "valueExperience";
            this.valueExperience.Size = new System.Drawing.Size(16, 17);
            this.valueExperience.TabIndex = 21;
            this.valueExperience.Text = "  ";
            // 
            // valueCoin
            // 
            this.valueCoin.AutoSize = true;
            this.valueCoin.Location = new System.Drawing.Point(457, 112);
            this.valueCoin.Name = "valueCoin";
            this.valueCoin.Size = new System.Drawing.Size(16, 17);
            this.valueCoin.TabIndex = 22;
            this.valueCoin.Text = "  ";
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(368, 222);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 30);
            this.play.TabIndex = 23;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // ShowCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 275);
            this.Controls.Add(this.play);
            this.Controls.Add(this.valueCoin);
            this.Controls.Add(this.valueExperience);
            this.Controls.Add(this.valueHp);
            this.Controls.Add(this.valueConstitution);
            this.Controls.Add(this.valueIntelligence);
            this.Controls.Add(this.valueDexterity);
            this.Controls.Add(this.valueAgility);
            this.Controls.Add(this.valueStrength);
            this.Controls.Add(this.Coin);
            this.Controls.Add(this.Experience);
            this.Controls.Add(this.Hp);
            this.Controls.Add(this.Constitution);
            this.Controls.Add(this.Intelligence);
            this.Controls.Add(this.Agility);
            this.Controls.Add(this.Dexterity);
            this.Controls.Add(this.Strength);
            this.Controls.Add(this.level);
            this.Controls.Add(this.name);
            this.Controls.Add(this.ListCharacters);
            this.Controls.Add(this.Back);
            this.Name = "ShowCharacter";
            this.Text = "Characters";
            this.Load += new System.EventHandler(this.ShowCharacter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ListBox ListCharacters;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label Strength;
        private System.Windows.Forms.Label Dexterity;
        private System.Windows.Forms.Label Agility;
        private System.Windows.Forms.Label Intelligence;
        private System.Windows.Forms.Label Constitution;
        private System.Windows.Forms.Label Hp;
        private System.Windows.Forms.Label Experience;
        private System.Windows.Forms.Label Coin;
        private System.Windows.Forms.Label valueStrength;
        private System.Windows.Forms.Label valueAgility;
        private System.Windows.Forms.Label valueDexterity;
        private System.Windows.Forms.Label valueIntelligence;
        private System.Windows.Forms.Label valueConstitution;
        private System.Windows.Forms.Label valueHp;
        private System.Windows.Forms.Label valueExperience;
        private System.Windows.Forms.Label valueCoin;
        private System.Windows.Forms.Button play;
    }
}