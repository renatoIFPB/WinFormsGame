
namespace ConsoleApp.Windows
{
    partial class InventoryGame
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
            this.pictureCharacter = new System.Windows.Forms.PictureBox();
            this.progressXp = new System.Windows.Forms.ProgressBar();
            this.level = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Label();
            this.labelStrength = new System.Windows.Forms.Label();
            this.labelDexterity = new System.Windows.Forms.Label();
            this.labelAgility = new System.Windows.Forms.Label();
            this.labelConstitution = new System.Windows.Forms.Label();
            this.labelIntelligence = new System.Windows.Forms.Label();
            this.valueStrength = new System.Windows.Forms.Label();
            this.valueDexterity = new System.Windows.Forms.Label();
            this.valueAgility = new System.Windows.Forms.Label();
            this.valueIntelligence = new System.Windows.Forms.Label();
            this.valueConstitution = new System.Windows.Forms.Label();
            this.labelTextLevel = new System.Windows.Forms.Label();
            this.progressHp = new System.Windows.Forms.ProgressBar();
            this.labelHp = new System.Windows.Forms.Label();
            this.valueTotalHp = new System.Windows.Forms.Label();
            this.listEquip = new System.Windows.Forms.ListBox();
            this.listInventory = new System.Windows.Forms.ListBox();
            this.valueConstItem = new System.Windows.Forms.Label();
            this.valueIntItem = new System.Windows.Forms.Label();
            this.valueAgilItem = new System.Windows.Forms.Label();
            this.valueDexItem = new System.Windows.Forms.Label();
            this.valueStrItem = new System.Windows.Forms.Label();
            this.labelIntItem = new System.Windows.Forms.Label();
            this.labelConstItem = new System.Windows.Forms.Label();
            this.labelAglItem = new System.Windows.Forms.Label();
            this.labelDexItem = new System.Windows.Forms.Label();
            this.labelStrItem = new System.Windows.Forms.Label();
            this.valueLevelItem = new System.Windows.Forms.Label();
            this.labelLevelItem = new System.Windows.Forms.Label();
            this.valueHpItem = new System.Windows.Forms.Label();
            this.labelHpItem = new System.Windows.Forms.Label();
            this.valueDmgItem = new System.Windows.Forms.Label();
            this.labelDmgItem = new System.Windows.Forms.Label();
            this.valueProtectItem = new System.Windows.Forms.Label();
            this.labelProtctItem = new System.Windows.Forms.Label();
            this.valueProtectEquip = new System.Windows.Forms.Label();
            this.labelProtecEquip = new System.Windows.Forms.Label();
            this.valueDmgEquip = new System.Windows.Forms.Label();
            this.labelDmgEquip = new System.Windows.Forms.Label();
            this.valueHpEquip = new System.Windows.Forms.Label();
            this.labelHpEquip = new System.Windows.Forms.Label();
            this.valueLevelEquip = new System.Windows.Forms.Label();
            this.labelLevelEquip = new System.Windows.Forms.Label();
            this.valueConstEquip = new System.Windows.Forms.Label();
            this.valueIntEquip = new System.Windows.Forms.Label();
            this.valueAgilEquip = new System.Windows.Forms.Label();
            this.valueDexEquip = new System.Windows.Forms.Label();
            this.valueStrEquip = new System.Windows.Forms.Label();
            this.labelIntEquip = new System.Windows.Forms.Label();
            this.labelConstEquip = new System.Windows.Forms.Label();
            this.labelAgilEquip = new System.Windows.Forms.Label();
            this.labelDexEquip = new System.Windows.Forms.Label();
            this.labelStrEquip = new System.Windows.Forms.Label();
            this.buttonEquipItem = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureCharacter
            // 
            this.pictureCharacter.Location = new System.Drawing.Point(48, 24);
            this.pictureCharacter.Name = "pictureCharacter";
            this.pictureCharacter.Size = new System.Drawing.Size(200, 222);
            this.pictureCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCharacter.TabIndex = 0;
            this.pictureCharacter.TabStop = false;
            // 
            // progressXp
            // 
            this.progressXp.BackColor = System.Drawing.SystemColors.Highlight;
            this.progressXp.Location = new System.Drawing.Point(128, 278);
            this.progressXp.Name = "progressXp";
            this.progressXp.Size = new System.Drawing.Size(120, 10);
            this.progressXp.TabIndex = 1;
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Location = new System.Drawing.Point(107, 271);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(16, 17);
            this.level.TabIndex = 2;
            this.level.Text = "  ";
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.BackColor = System.Drawing.SystemColors.Control;
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.Location = new System.Drawing.Point(182, 262);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(13, 13);
            this.percent.TabIndex = 3;
            this.percent.Text = "  ";
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Location = new System.Drawing.Point(41, 345);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(75, 17);
            this.labelStrength.TabIndex = 4;
            this.labelStrength.Text = "Strength - ";
            // 
            // labelDexterity
            // 
            this.labelDexterity.AutoSize = true;
            this.labelDexterity.Location = new System.Drawing.Point(41, 373);
            this.labelDexterity.Name = "labelDexterity";
            this.labelDexterity.Size = new System.Drawing.Size(76, 17);
            this.labelDexterity.TabIndex = 5;
            this.labelDexterity.Text = "Dexterity - ";
            // 
            // labelAgility
            // 
            this.labelAgility.AutoSize = true;
            this.labelAgility.Location = new System.Drawing.Point(41, 401);
            this.labelAgility.Name = "labelAgility";
            this.labelAgility.Size = new System.Drawing.Size(58, 17);
            this.labelAgility.TabIndex = 6;
            this.labelAgility.Text = "Agility - ";
            // 
            // labelConstitution
            // 
            this.labelConstitution.AutoSize = true;
            this.labelConstitution.Location = new System.Drawing.Point(156, 373);
            this.labelConstitution.Name = "labelConstitution";
            this.labelConstitution.Size = new System.Drawing.Size(88, 17);
            this.labelConstitution.TabIndex = 7;
            this.labelConstitution.Text = "Contitution - ";
            // 
            // labelIntelligence
            // 
            this.labelIntelligence.AutoSize = true;
            this.labelIntelligence.Location = new System.Drawing.Point(156, 345);
            this.labelIntelligence.Name = "labelIntelligence";
            this.labelIntelligence.Size = new System.Drawing.Size(92, 17);
            this.labelIntelligence.TabIndex = 8;
            this.labelIntelligence.Text = "Intelligence - ";
            // 
            // valueStrength
            // 
            this.valueStrength.AutoSize = true;
            this.valueStrength.Location = new System.Drawing.Point(117, 345);
            this.valueStrength.Name = "valueStrength";
            this.valueStrength.Size = new System.Drawing.Size(16, 17);
            this.valueStrength.TabIndex = 9;
            this.valueStrength.Text = "  ";
            // 
            // valueDexterity
            // 
            this.valueDexterity.AutoSize = true;
            this.valueDexterity.Location = new System.Drawing.Point(114, 373);
            this.valueDexterity.Name = "valueDexterity";
            this.valueDexterity.Size = new System.Drawing.Size(16, 17);
            this.valueDexterity.TabIndex = 10;
            this.valueDexterity.Text = "  ";
            // 
            // valueAgility
            // 
            this.valueAgility.AutoSize = true;
            this.valueAgility.Location = new System.Drawing.Point(95, 401);
            this.valueAgility.Name = "valueAgility";
            this.valueAgility.Size = new System.Drawing.Size(16, 17);
            this.valueAgility.TabIndex = 11;
            this.valueAgility.Text = "  ";
            // 
            // valueIntelligence
            // 
            this.valueIntelligence.AutoSize = true;
            this.valueIntelligence.Location = new System.Drawing.Point(243, 345);
            this.valueIntelligence.Name = "valueIntelligence";
            this.valueIntelligence.Size = new System.Drawing.Size(16, 17);
            this.valueIntelligence.TabIndex = 12;
            this.valueIntelligence.Text = "  ";
            // 
            // valueConstitution
            // 
            this.valueConstitution.AutoSize = true;
            this.valueConstitution.Location = new System.Drawing.Point(242, 372);
            this.valueConstitution.Name = "valueConstitution";
            this.valueConstitution.Size = new System.Drawing.Size(16, 17);
            this.valueConstitution.TabIndex = 13;
            this.valueConstitution.Text = "  ";
            // 
            // labelTextLevel
            // 
            this.labelTextLevel.AutoSize = true;
            this.labelTextLevel.Location = new System.Drawing.Point(46, 271);
            this.labelTextLevel.Name = "labelTextLevel";
            this.labelTextLevel.Size = new System.Drawing.Size(55, 17);
            this.labelTextLevel.TabIndex = 14;
            this.labelTextLevel.Text = "Level - ";
            // 
            // progressHp
            // 
            this.progressHp.Location = new System.Drawing.Point(83, 319);
            this.progressHp.Name = "progressHp";
            this.progressHp.Size = new System.Drawing.Size(165, 10);
            this.progressHp.TabIndex = 15;
            // 
            // labelHp
            // 
            this.labelHp.AutoSize = true;
            this.labelHp.Location = new System.Drawing.Point(44, 312);
            this.labelHp.Name = "labelHp";
            this.labelHp.Size = new System.Drawing.Size(39, 17);
            this.labelHp.TabIndex = 16;
            this.labelHp.Text = "Hp - ";
            // 
            // valueTotalHp
            // 
            this.valueTotalHp.AutoSize = true;
            this.valueTotalHp.BackColor = System.Drawing.SystemColors.Control;
            this.valueTotalHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueTotalHp.Location = new System.Drawing.Point(140, 303);
            this.valueTotalHp.Name = "valueTotalHp";
            this.valueTotalHp.Size = new System.Drawing.Size(31, 13);
            this.valueTotalHp.TabIndex = 17;
            this.valueTotalHp.Text = "        ";
            // 
            // listEquip
            // 
            this.listEquip.FormattingEnabled = true;
            this.listEquip.ItemHeight = 16;
            this.listEquip.Location = new System.Drawing.Point(279, 24);
            this.listEquip.Name = "listEquip";
            this.listEquip.Size = new System.Drawing.Size(158, 148);
            this.listEquip.TabIndex = 18;
            // 
            // listInventory
            // 
            this.listInventory.FormattingEnabled = true;
            this.listInventory.ItemHeight = 16;
            this.listInventory.Location = new System.Drawing.Point(524, 24);
            this.listInventory.Name = "listInventory";
            this.listInventory.Size = new System.Drawing.Size(155, 148);
            this.listInventory.TabIndex = 19;
            // 
            // valueConstItem
            // 
            this.valueConstItem.AutoSize = true;
            this.valueConstItem.Location = new System.Drawing.Point(640, 393);
            this.valueConstItem.Name = "valueConstItem";
            this.valueConstItem.Size = new System.Drawing.Size(16, 17);
            this.valueConstItem.TabIndex = 29;
            this.valueConstItem.Text = "  ";
            // 
            // valueIntItem
            // 
            this.valueIntItem.AutoSize = true;
            this.valueIntItem.Location = new System.Drawing.Point(642, 371);
            this.valueIntItem.Name = "valueIntItem";
            this.valueIntItem.Size = new System.Drawing.Size(16, 17);
            this.valueIntItem.TabIndex = 28;
            this.valueIntItem.Text = "  ";
            // 
            // valueAgilItem
            // 
            this.valueAgilItem.AutoSize = true;
            this.valueAgilItem.Location = new System.Drawing.Point(609, 347);
            this.valueAgilItem.Name = "valueAgilItem";
            this.valueAgilItem.Size = new System.Drawing.Size(16, 17);
            this.valueAgilItem.TabIndex = 27;
            this.valueAgilItem.Text = "  ";
            // 
            // valueDexItem
            // 
            this.valueDexItem.AutoSize = true;
            this.valueDexItem.Location = new System.Drawing.Point(628, 324);
            this.valueDexItem.Name = "valueDexItem";
            this.valueDexItem.Size = new System.Drawing.Size(16, 17);
            this.valueDexItem.TabIndex = 26;
            this.valueDexItem.Text = "  ";
            // 
            // valueStrItem
            // 
            this.valueStrItem.AutoSize = true;
            this.valueStrItem.Location = new System.Drawing.Point(630, 297);
            this.valueStrItem.Name = "valueStrItem";
            this.valueStrItem.Size = new System.Drawing.Size(16, 17);
            this.valueStrItem.TabIndex = 25;
            this.valueStrItem.Text = "  ";
            // 
            // labelIntItem
            // 
            this.labelIntItem.AutoSize = true;
            this.labelIntItem.Location = new System.Drawing.Point(555, 371);
            this.labelIntItem.Name = "labelIntItem";
            this.labelIntItem.Size = new System.Drawing.Size(87, 17);
            this.labelIntItem.TabIndex = 24;
            this.labelIntItem.Text = "Intelligence  ";
            // 
            // labelConstItem
            // 
            this.labelConstItem.AutoSize = true;
            this.labelConstItem.Location = new System.Drawing.Point(554, 394);
            this.labelConstItem.Name = "labelConstItem";
            this.labelConstItem.Size = new System.Drawing.Size(83, 17);
            this.labelConstItem.TabIndex = 23;
            this.labelConstItem.Text = "Contitution  ";
            // 
            // labelAglItem
            // 
            this.labelAglItem.AutoSize = true;
            this.labelAglItem.Location = new System.Drawing.Point(555, 347);
            this.labelAglItem.Name = "labelAglItem";
            this.labelAglItem.Size = new System.Drawing.Size(53, 17);
            this.labelAglItem.TabIndex = 22;
            this.labelAglItem.Text = "Agility  ";
            // 
            // labelDexItem
            // 
            this.labelDexItem.AutoSize = true;
            this.labelDexItem.Location = new System.Drawing.Point(555, 324);
            this.labelDexItem.Name = "labelDexItem";
            this.labelDexItem.Size = new System.Drawing.Size(71, 17);
            this.labelDexItem.TabIndex = 21;
            this.labelDexItem.Text = "Dexterity  ";
            // 
            // labelStrItem
            // 
            this.labelStrItem.AutoSize = true;
            this.labelStrItem.Location = new System.Drawing.Point(554, 297);
            this.labelStrItem.Name = "labelStrItem";
            this.labelStrItem.Size = new System.Drawing.Size(70, 17);
            this.labelStrItem.TabIndex = 20;
            this.labelStrItem.Text = "Strength  ";
            // 
            // valueLevelItem
            // 
            this.valueLevelItem.AutoSize = true;
            this.valueLevelItem.Location = new System.Drawing.Point(607, 184);
            this.valueLevelItem.Name = "valueLevelItem";
            this.valueLevelItem.Size = new System.Drawing.Size(16, 17);
            this.valueLevelItem.TabIndex = 31;
            this.valueLevelItem.Text = "  ";
            // 
            // labelLevelItem
            // 
            this.labelLevelItem.AutoSize = true;
            this.labelLevelItem.Location = new System.Drawing.Point(554, 184);
            this.labelLevelItem.Name = "labelLevelItem";
            this.labelLevelItem.Size = new System.Drawing.Size(50, 17);
            this.labelLevelItem.TabIndex = 30;
            this.labelLevelItem.Text = "Level  ";
            // 
            // valueHpItem
            // 
            this.valueHpItem.AutoSize = true;
            this.valueHpItem.Location = new System.Drawing.Point(599, 207);
            this.valueHpItem.Name = "valueHpItem";
            this.valueHpItem.Size = new System.Drawing.Size(16, 17);
            this.valueHpItem.TabIndex = 33;
            this.valueHpItem.Text = "  ";
            // 
            // labelHpItem
            // 
            this.labelHpItem.AutoSize = true;
            this.labelHpItem.Location = new System.Drawing.Point(554, 207);
            this.labelHpItem.Name = "labelHpItem";
            this.labelHpItem.Size = new System.Drawing.Size(34, 17);
            this.labelHpItem.TabIndex = 32;
            this.labelHpItem.Text = "Hp  ";
            // 
            // valueDmgItem
            // 
            this.valueDmgItem.AutoSize = true;
            this.valueDmgItem.Location = new System.Drawing.Point(630, 229);
            this.valueDmgItem.Name = "valueDmgItem";
            this.valueDmgItem.Size = new System.Drawing.Size(16, 17);
            this.valueDmgItem.TabIndex = 35;
            this.valueDmgItem.Text = "  ";
            // 
            // labelDmgItem
            // 
            this.labelDmgItem.AutoSize = true;
            this.labelDmgItem.Location = new System.Drawing.Point(554, 229);
            this.labelDmgItem.Name = "labelDmgItem";
            this.labelDmgItem.Size = new System.Drawing.Size(69, 17);
            this.labelDmgItem.TabIndex = 34;
            this.labelDmgItem.Text = "Damage  ";
            // 
            // valueProtectItem
            // 
            this.valueProtectItem.AutoSize = true;
            this.valueProtectItem.Location = new System.Drawing.Point(641, 253);
            this.valueProtectItem.Name = "valueProtectItem";
            this.valueProtectItem.Size = new System.Drawing.Size(16, 17);
            this.valueProtectItem.TabIndex = 37;
            this.valueProtectItem.Text = "  ";
            // 
            // labelProtctItem
            // 
            this.labelProtctItem.AutoSize = true;
            this.labelProtctItem.Location = new System.Drawing.Point(554, 253);
            this.labelProtctItem.Name = "labelProtctItem";
            this.labelProtctItem.Size = new System.Drawing.Size(80, 17);
            this.labelProtctItem.TabIndex = 36;
            this.labelProtctItem.Text = "Protection  ";
            // 
            // valueProtectEquip
            // 
            this.valueProtectEquip.AutoSize = true;
            this.valueProtectEquip.Location = new System.Drawing.Point(393, 253);
            this.valueProtectEquip.Name = "valueProtectEquip";
            this.valueProtectEquip.Size = new System.Drawing.Size(16, 17);
            this.valueProtectEquip.TabIndex = 55;
            this.valueProtectEquip.Text = "  ";
            // 
            // labelProtecEquip
            // 
            this.labelProtecEquip.AutoSize = true;
            this.labelProtecEquip.Location = new System.Drawing.Point(306, 253);
            this.labelProtecEquip.Name = "labelProtecEquip";
            this.labelProtecEquip.Size = new System.Drawing.Size(76, 17);
            this.labelProtecEquip.TabIndex = 54;
            this.labelProtecEquip.Text = "Protection ";
            // 
            // valueDmgEquip
            // 
            this.valueDmgEquip.AutoSize = true;
            this.valueDmgEquip.Location = new System.Drawing.Point(382, 229);
            this.valueDmgEquip.Name = "valueDmgEquip";
            this.valueDmgEquip.Size = new System.Drawing.Size(16, 17);
            this.valueDmgEquip.TabIndex = 53;
            this.valueDmgEquip.Text = "  ";
            // 
            // labelDmgEquip
            // 
            this.labelDmgEquip.AutoSize = true;
            this.labelDmgEquip.Location = new System.Drawing.Point(306, 229);
            this.labelDmgEquip.Name = "labelDmgEquip";
            this.labelDmgEquip.Size = new System.Drawing.Size(65, 17);
            this.labelDmgEquip.TabIndex = 52;
            this.labelDmgEquip.Text = "Damage ";
            // 
            // valueHpEquip
            // 
            this.valueHpEquip.AutoSize = true;
            this.valueHpEquip.Location = new System.Drawing.Point(351, 207);
            this.valueHpEquip.Name = "valueHpEquip";
            this.valueHpEquip.Size = new System.Drawing.Size(16, 17);
            this.valueHpEquip.TabIndex = 51;
            this.valueHpEquip.Text = "  ";
            // 
            // labelHpEquip
            // 
            this.labelHpEquip.AutoSize = true;
            this.labelHpEquip.Location = new System.Drawing.Point(306, 207);
            this.labelHpEquip.Name = "labelHpEquip";
            this.labelHpEquip.Size = new System.Drawing.Size(30, 17);
            this.labelHpEquip.TabIndex = 50;
            this.labelHpEquip.Text = "Hp ";
            // 
            // valueLevelEquip
            // 
            this.valueLevelEquip.AutoSize = true;
            this.valueLevelEquip.Location = new System.Drawing.Point(355, 184);
            this.valueLevelEquip.Name = "valueLevelEquip";
            this.valueLevelEquip.Size = new System.Drawing.Size(16, 17);
            this.valueLevelEquip.TabIndex = 49;
            this.valueLevelEquip.Text = "  ";
            // 
            // labelLevelEquip
            // 
            this.labelLevelEquip.AutoSize = true;
            this.labelLevelEquip.Location = new System.Drawing.Point(306, 184);
            this.labelLevelEquip.Name = "labelLevelEquip";
            this.labelLevelEquip.Size = new System.Drawing.Size(46, 17);
            this.labelLevelEquip.TabIndex = 48;
            this.labelLevelEquip.Text = "Level ";
            // 
            // valueConstEquip
            // 
            this.valueConstEquip.AutoSize = true;
            this.valueConstEquip.Location = new System.Drawing.Point(392, 393);
            this.valueConstEquip.Name = "valueConstEquip";
            this.valueConstEquip.Size = new System.Drawing.Size(16, 17);
            this.valueConstEquip.TabIndex = 47;
            this.valueConstEquip.Text = "  ";
            // 
            // valueIntEquip
            // 
            this.valueIntEquip.AutoSize = true;
            this.valueIntEquip.Location = new System.Drawing.Point(394, 371);
            this.valueIntEquip.Name = "valueIntEquip";
            this.valueIntEquip.Size = new System.Drawing.Size(16, 17);
            this.valueIntEquip.TabIndex = 46;
            this.valueIntEquip.Text = "  ";
            // 
            // valueAgilEquip
            // 
            this.valueAgilEquip.AutoSize = true;
            this.valueAgilEquip.Location = new System.Drawing.Point(361, 347);
            this.valueAgilEquip.Name = "valueAgilEquip";
            this.valueAgilEquip.Size = new System.Drawing.Size(16, 17);
            this.valueAgilEquip.TabIndex = 45;
            this.valueAgilEquip.Text = "  ";
            // 
            // valueDexEquip
            // 
            this.valueDexEquip.AutoSize = true;
            this.valueDexEquip.Location = new System.Drawing.Point(380, 324);
            this.valueDexEquip.Name = "valueDexEquip";
            this.valueDexEquip.Size = new System.Drawing.Size(16, 17);
            this.valueDexEquip.TabIndex = 44;
            this.valueDexEquip.Text = "  ";
            // 
            // valueStrEquip
            // 
            this.valueStrEquip.AutoSize = true;
            this.valueStrEquip.Location = new System.Drawing.Point(382, 297);
            this.valueStrEquip.Name = "valueStrEquip";
            this.valueStrEquip.Size = new System.Drawing.Size(16, 17);
            this.valueStrEquip.TabIndex = 43;
            this.valueStrEquip.Text = "  ";
            // 
            // labelIntEquip
            // 
            this.labelIntEquip.AutoSize = true;
            this.labelIntEquip.Location = new System.Drawing.Point(307, 371);
            this.labelIntEquip.Name = "labelIntEquip";
            this.labelIntEquip.Size = new System.Drawing.Size(83, 17);
            this.labelIntEquip.TabIndex = 42;
            this.labelIntEquip.Text = "Intelligence ";
            // 
            // labelConstEquip
            // 
            this.labelConstEquip.AutoSize = true;
            this.labelConstEquip.Location = new System.Drawing.Point(307, 393);
            this.labelConstEquip.Name = "labelConstEquip";
            this.labelConstEquip.Size = new System.Drawing.Size(79, 17);
            this.labelConstEquip.TabIndex = 41;
            this.labelConstEquip.Text = "Contitution ";
            // 
            // labelAgilEquip
            // 
            this.labelAgilEquip.AutoSize = true;
            this.labelAgilEquip.Location = new System.Drawing.Point(307, 347);
            this.labelAgilEquip.Name = "labelAgilEquip";
            this.labelAgilEquip.Size = new System.Drawing.Size(49, 17);
            this.labelAgilEquip.TabIndex = 40;
            this.labelAgilEquip.Text = "Agility ";
            // 
            // labelDexEquip
            // 
            this.labelDexEquip.AutoSize = true;
            this.labelDexEquip.Location = new System.Drawing.Point(307, 324);
            this.labelDexEquip.Name = "labelDexEquip";
            this.labelDexEquip.Size = new System.Drawing.Size(67, 17);
            this.labelDexEquip.TabIndex = 39;
            this.labelDexEquip.Text = "Dexterity ";
            // 
            // labelStrEquip
            // 
            this.labelStrEquip.AutoSize = true;
            this.labelStrEquip.Location = new System.Drawing.Point(306, 297);
            this.labelStrEquip.Name = "labelStrEquip";
            this.labelStrEquip.Size = new System.Drawing.Size(70, 17);
            this.labelStrEquip.TabIndex = 38;
            this.labelStrEquip.Text = "Strength  ";
            // 
            // buttonEquipItem
            // 
            this.buttonEquipItem.Location = new System.Drawing.Point(443, 55);
            this.buttonEquipItem.Name = "buttonEquipItem";
            this.buttonEquipItem.Size = new System.Drawing.Size(75, 24);
            this.buttonEquipItem.TabIndex = 56;
            this.buttonEquipItem.Text = "Equip";
            this.buttonEquipItem.UseVisualStyleBackColor = true;
            this.buttonEquipItem.Click += new System.EventHandler(this.buttonEquipItem_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(612, 438);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 57;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // InventoryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 485);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonEquipItem);
            this.Controls.Add(this.valueProtectEquip);
            this.Controls.Add(this.labelProtecEquip);
            this.Controls.Add(this.valueDmgEquip);
            this.Controls.Add(this.labelDmgEquip);
            this.Controls.Add(this.valueHpEquip);
            this.Controls.Add(this.labelHpEquip);
            this.Controls.Add(this.valueLevelEquip);
            this.Controls.Add(this.labelLevelEquip);
            this.Controls.Add(this.valueConstEquip);
            this.Controls.Add(this.valueIntEquip);
            this.Controls.Add(this.valueAgilEquip);
            this.Controls.Add(this.valueDexEquip);
            this.Controls.Add(this.valueStrEquip);
            this.Controls.Add(this.labelIntEquip);
            this.Controls.Add(this.labelConstEquip);
            this.Controls.Add(this.labelAgilEquip);
            this.Controls.Add(this.labelDexEquip);
            this.Controls.Add(this.labelStrEquip);
            this.Controls.Add(this.valueProtectItem);
            this.Controls.Add(this.labelProtctItem);
            this.Controls.Add(this.valueDmgItem);
            this.Controls.Add(this.labelDmgItem);
            this.Controls.Add(this.valueHpItem);
            this.Controls.Add(this.labelHpItem);
            this.Controls.Add(this.valueLevelItem);
            this.Controls.Add(this.labelLevelItem);
            this.Controls.Add(this.valueConstItem);
            this.Controls.Add(this.valueIntItem);
            this.Controls.Add(this.valueAgilItem);
            this.Controls.Add(this.valueDexItem);
            this.Controls.Add(this.valueStrItem);
            this.Controls.Add(this.labelIntItem);
            this.Controls.Add(this.labelConstItem);
            this.Controls.Add(this.labelAglItem);
            this.Controls.Add(this.labelDexItem);
            this.Controls.Add(this.labelStrItem);
            this.Controls.Add(this.listInventory);
            this.Controls.Add(this.listEquip);
            this.Controls.Add(this.valueTotalHp);
            this.Controls.Add(this.labelHp);
            this.Controls.Add(this.progressHp);
            this.Controls.Add(this.labelTextLevel);
            this.Controls.Add(this.valueConstitution);
            this.Controls.Add(this.valueIntelligence);
            this.Controls.Add(this.valueAgility);
            this.Controls.Add(this.valueDexterity);
            this.Controls.Add(this.valueStrength);
            this.Controls.Add(this.labelIntelligence);
            this.Controls.Add(this.labelConstitution);
            this.Controls.Add(this.labelAgility);
            this.Controls.Add(this.labelDexterity);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.level);
            this.Controls.Add(this.progressXp);
            this.Controls.Add(this.pictureCharacter);
            this.Name = "InventoryGame";
            this.Text = "InventoryGame";
            this.Load += new System.EventHandler(this.InventoryGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCharacter;
        private System.Windows.Forms.ProgressBar progressXp;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Label labelDexterity;
        private System.Windows.Forms.Label labelAgility;
        private System.Windows.Forms.Label labelConstitution;
        private System.Windows.Forms.Label labelIntelligence;
        private System.Windows.Forms.Label valueStrength;
        private System.Windows.Forms.Label valueDexterity;
        private System.Windows.Forms.Label valueAgility;
        private System.Windows.Forms.Label valueIntelligence;
        private System.Windows.Forms.Label valueConstitution;
        private System.Windows.Forms.Label labelTextLevel;
        private System.Windows.Forms.ProgressBar progressHp;
        private System.Windows.Forms.Label labelHp;
        private System.Windows.Forms.Label valueTotalHp;
        private System.Windows.Forms.ListBox listEquip;
        private System.Windows.Forms.ListBox listInventory;
        private System.Windows.Forms.Label valueConstItem;
        private System.Windows.Forms.Label valueIntItem;
        private System.Windows.Forms.Label valueAgilItem;
        private System.Windows.Forms.Label valueDexItem;
        private System.Windows.Forms.Label valueStrItem;
        private System.Windows.Forms.Label labelIntItem;
        private System.Windows.Forms.Label labelConstItem;
        private System.Windows.Forms.Label labelAglItem;
        private System.Windows.Forms.Label labelDexItem;
        private System.Windows.Forms.Label labelStrItem;
        private System.Windows.Forms.Label valueLevelItem;
        private System.Windows.Forms.Label labelLevelItem;
        private System.Windows.Forms.Label valueHpItem;
        private System.Windows.Forms.Label labelHpItem;
        private System.Windows.Forms.Label valueDmgItem;
        private System.Windows.Forms.Label labelDmgItem;
        private System.Windows.Forms.Label valueProtectItem;
        private System.Windows.Forms.Label labelProtctItem;
        private System.Windows.Forms.Label valueProtectEquip;
        private System.Windows.Forms.Label labelProtecEquip;
        private System.Windows.Forms.Label valueDmgEquip;
        private System.Windows.Forms.Label labelDmgEquip;
        private System.Windows.Forms.Label valueHpEquip;
        private System.Windows.Forms.Label labelHpEquip;
        private System.Windows.Forms.Label valueLevelEquip;
        private System.Windows.Forms.Label labelLevelEquip;
        private System.Windows.Forms.Label valueConstEquip;
        private System.Windows.Forms.Label valueIntEquip;
        private System.Windows.Forms.Label valueAgilEquip;
        private System.Windows.Forms.Label valueDexEquip;
        private System.Windows.Forms.Label valueStrEquip;
        private System.Windows.Forms.Label labelIntEquip;
        private System.Windows.Forms.Label labelConstEquip;
        private System.Windows.Forms.Label labelAgilEquip;
        private System.Windows.Forms.Label labelDexEquip;
        private System.Windows.Forms.Label labelStrEquip;
        private System.Windows.Forms.Button buttonEquipItem;
        private System.Windows.Forms.Button buttonBack;
    }
}