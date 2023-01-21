namespace DraftHA
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlPlayerChoose = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPgCharList = new System.Windows.Forms.TabPage();
            this.lblLoses = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCharLevel = new System.Windows.Forms.Label();
            this.lblCharPoints = new System.Windows.Forms.Label();
            this.lblCharHealth = new System.Windows.Forms.Label();
            this.lblCharName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCharChoose = new System.Windows.Forms.Button();
            this.btnAllChars = new System.Windows.Forms.Button();
            this.lstBxAllChars = new System.Windows.Forms.ListBox();
            this.picBxCharList = new System.Windows.Forms.PictureBox();
            this.tbPgNewCharacter = new System.Windows.Forms.TabPage();
            this.pnlEquipWarrior = new System.Windows.Forms.Panel();
            this.pnlEquipMage = new System.Windows.Forms.Panel();
            this.btnChooseWand = new System.Windows.Forms.Button();
            this.picBoxMageEquip = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdBtnMother = new System.Windows.Forms.RadioButton();
            this.rdBtnUltimate = new System.Windows.Forms.RadioButton();
            this.rdBtnDragon = new System.Windows.Forms.RadioButton();
            this.btnChooseWeapon = new System.Windows.Forms.Button();
            this.picBoxWeapons = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdBtnKatana = new System.Windows.Forms.RadioButton();
            this.rdBtnHammer = new System.Windows.Forms.RadioButton();
            this.rdBtnAxe = new System.Windows.Forms.RadioButton();
            this.picBxAddChar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnWarrior = new System.Windows.Forms.RadioButton();
            this.rdBtnMage = new System.Windows.Forms.RadioButton();
            this.btnCharChoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxCharName = new System.Windows.Forms.TextBox();
            this.tbPgBattle = new System.Windows.Forms.TabPage();
            this.pnlBattle = new System.Windows.Forms.Panel();
            this.btnFight = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBxEnemyLvlB = new System.Windows.Forms.TextBox();
            this.txtBxCharLvlB = new System.Windows.Forms.TextBox();
            this.txtBxEnemyPointsB = new System.Windows.Forms.TextBox();
            this.txtBxLevel = new System.Windows.Forms.TextBox();
            this.txtBxEnemyNameB = new System.Windows.Forms.TextBox();
            this.txtBxEnemyHealthB = new System.Windows.Forms.TextBox();
            this.txtBxCharPointsB = new System.Windows.Forms.TextBox();
            this.txtBxPoints = new System.Windows.Forms.TextBox();
            this.txtBxCharNameB = new System.Windows.Forms.TextBox();
            this.txtBxCharHealthB = new System.Windows.Forms.TextBox();
            this.txtBxNameLabel = new System.Windows.Forms.TextBox();
            this.txtBxHealthLabel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenRanEnemy = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.weaponImageList = new System.Windows.Forms.ImageList(this.components);
            this.imgListMageEquip = new System.Windows.Forms.ImageList(this.components);
            this.pnlPlayerChoose.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbPgCharList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxCharList)).BeginInit();
            this.tbPgNewCharacter.SuspendLayout();
            this.pnlEquipWarrior.SuspendLayout();
            this.pnlEquipMage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMageEquip)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWeapons)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxAddChar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbPgBattle.SuspendLayout();
            this.pnlBattle.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPlayerChoose
            // 
            this.pnlPlayerChoose.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlPlayerChoose.Controls.Add(this.tabControl1);
            this.pnlPlayerChoose.Controls.Add(this.lblWelcome);
            this.pnlPlayerChoose.Location = new System.Drawing.Point(25, 12);
            this.pnlPlayerChoose.Name = "pnlPlayerChoose";
            this.pnlPlayerChoose.Size = new System.Drawing.Size(1324, 669);
            this.pnlPlayerChoose.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPgCharList);
            this.tabControl1.Controls.Add(this.tbPgNewCharacter);
            this.tabControl1.Controls.Add(this.tbPgBattle);
            this.tabControl1.Location = new System.Drawing.Point(68, 121);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1171, 502);
            this.tabControl1.TabIndex = 7;
            // 
            // tbPgCharList
            // 
            this.tbPgCharList.Controls.Add(this.lblLoses);
            this.tbPgCharList.Controls.Add(this.label9);
            this.tbPgCharList.Controls.Add(this.lblWins);
            this.tbPgCharList.Controls.Add(this.label8);
            this.tbPgCharList.Controls.Add(this.lblCharLevel);
            this.tbPgCharList.Controls.Add(this.lblCharPoints);
            this.tbPgCharList.Controls.Add(this.lblCharHealth);
            this.tbPgCharList.Controls.Add(this.lblCharName);
            this.tbPgCharList.Controls.Add(this.label6);
            this.tbPgCharList.Controls.Add(this.label5);
            this.tbPgCharList.Controls.Add(this.label4);
            this.tbPgCharList.Controls.Add(this.label3);
            this.tbPgCharList.Controls.Add(this.label2);
            this.tbPgCharList.Controls.Add(this.btnCharChoose);
            this.tbPgCharList.Controls.Add(this.btnAllChars);
            this.tbPgCharList.Controls.Add(this.lstBxAllChars);
            this.tbPgCharList.Controls.Add(this.picBxCharList);
            this.tbPgCharList.Location = new System.Drawing.Point(4, 25);
            this.tbPgCharList.Name = "tbPgCharList";
            this.tbPgCharList.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgCharList.Size = new System.Drawing.Size(1163, 473);
            this.tbPgCharList.TabIndex = 0;
            this.tbPgCharList.Text = "List of Characters";
            this.tbPgCharList.UseVisualStyleBackColor = true;
            // 
            // lblLoses
            // 
            this.lblLoses.AutoSize = true;
            this.lblLoses.Location = new System.Drawing.Point(1005, 252);
            this.lblLoses.Name = "lblLoses";
            this.lblLoses.Size = new System.Drawing.Size(0, 17);
            this.lblLoses.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(879, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Loses:";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(1005, 221);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(0, 17);
            this.lblWins.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(879, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Wins:";
            // 
            // lblCharLevel
            // 
            this.lblCharLevel.AutoSize = true;
            this.lblCharLevel.Location = new System.Drawing.Point(1002, 188);
            this.lblCharLevel.Name = "lblCharLevel";
            this.lblCharLevel.Size = new System.Drawing.Size(0, 17);
            this.lblCharLevel.TabIndex = 18;
            // 
            // lblCharPoints
            // 
            this.lblCharPoints.AutoSize = true;
            this.lblCharPoints.Location = new System.Drawing.Point(1002, 153);
            this.lblCharPoints.Name = "lblCharPoints";
            this.lblCharPoints.Size = new System.Drawing.Size(0, 17);
            this.lblCharPoints.TabIndex = 17;
            // 
            // lblCharHealth
            // 
            this.lblCharHealth.AutoSize = true;
            this.lblCharHealth.Location = new System.Drawing.Point(1002, 119);
            this.lblCharHealth.Name = "lblCharHealth";
            this.lblCharHealth.Size = new System.Drawing.Size(0, 17);
            this.lblCharHealth.TabIndex = 16;
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.Location = new System.Drawing.Point(1002, 85);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(0, 17);
            this.lblCharName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(879, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Level:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(879, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Points:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(879, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Health:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(876, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(949, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Statistics";
            // 
            // btnCharChoose
            // 
            this.btnCharChoose.Enabled = false;
            this.btnCharChoose.Location = new System.Drawing.Point(192, 367);
            this.btnCharChoose.Name = "btnCharChoose";
            this.btnCharChoose.Size = new System.Drawing.Size(126, 57);
            this.btnCharChoose.TabIndex = 9;
            this.btnCharChoose.Text = "Choose Character";
            this.btnCharChoose.UseVisualStyleBackColor = true;
            this.btnCharChoose.Click += new System.EventHandler(this.btnCharChoose_Click);
            // 
            // btnAllChars
            // 
            this.btnAllChars.Location = new System.Drawing.Point(19, 367);
            this.btnAllChars.Name = "btnAllChars";
            this.btnAllChars.Size = new System.Drawing.Size(163, 57);
            this.btnAllChars.TabIndex = 8;
            this.btnAllChars.Text = "Show Updated Character List";
            this.btnAllChars.UseVisualStyleBackColor = true;
            this.btnAllChars.Click += new System.EventHandler(this.btnAllChars_Click);
            // 
            // lstBxAllChars
            // 
            this.lstBxAllChars.FormattingEnabled = true;
            this.lstBxAllChars.ItemHeight = 16;
            this.lstBxAllChars.Location = new System.Drawing.Point(71, 49);
            this.lstBxAllChars.Name = "lstBxAllChars";
            this.lstBxAllChars.Size = new System.Drawing.Size(197, 292);
            this.lstBxAllChars.TabIndex = 7;
            this.lstBxAllChars.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // picBxCharList
            // 
            this.picBxCharList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBxCharList.Image = global::DraftHA.Properties.Resources.images;
            this.picBxCharList.Location = new System.Drawing.Point(349, 49);
            this.picBxCharList.Name = "picBxCharList";
            this.picBxCharList.Size = new System.Drawing.Size(489, 399);
            this.picBxCharList.TabIndex = 5;
            this.picBxCharList.TabStop = false;
            // 
            // tbPgNewCharacter
            // 
            this.tbPgNewCharacter.Controls.Add(this.pnlEquipWarrior);
            this.tbPgNewCharacter.Controls.Add(this.picBxAddChar);
            this.tbPgNewCharacter.Controls.Add(this.groupBox1);
            this.tbPgNewCharacter.Controls.Add(this.btnCharChoice);
            this.tbPgNewCharacter.Controls.Add(this.label1);
            this.tbPgNewCharacter.Controls.Add(this.txtBxCharName);
            this.tbPgNewCharacter.Location = new System.Drawing.Point(4, 25);
            this.tbPgNewCharacter.Name = "tbPgNewCharacter";
            this.tbPgNewCharacter.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgNewCharacter.Size = new System.Drawing.Size(1163, 473);
            this.tbPgNewCharacter.TabIndex = 1;
            this.tbPgNewCharacter.Text = "Add New Character";
            this.tbPgNewCharacter.UseVisualStyleBackColor = true;
            // 
            // pnlEquipWarrior
            // 
            this.pnlEquipWarrior.Controls.Add(this.pnlEquipMage);
            this.pnlEquipWarrior.Controls.Add(this.btnChooseWeapon);
            this.pnlEquipWarrior.Controls.Add(this.picBoxWeapons);
            this.pnlEquipWarrior.Controls.Add(this.groupBox2);
            this.pnlEquipWarrior.Location = new System.Drawing.Point(6, 3);
            this.pnlEquipWarrior.Name = "pnlEquipWarrior";
            this.pnlEquipWarrior.Size = new System.Drawing.Size(1081, 461);
            this.pnlEquipWarrior.TabIndex = 7;
            this.pnlEquipWarrior.Visible = false;
            // 
            // pnlEquipMage
            // 
            this.pnlEquipMage.Controls.Add(this.btnChooseWand);
            this.pnlEquipMage.Controls.Add(this.picBoxMageEquip);
            this.pnlEquipMage.Controls.Add(this.groupBox3);
            this.pnlEquipMage.Location = new System.Drawing.Point(0, 3);
            this.pnlEquipMage.Name = "pnlEquipMage";
            this.pnlEquipMage.Size = new System.Drawing.Size(1148, 444);
            this.pnlEquipMage.TabIndex = 8;
            this.pnlEquipMage.Visible = false;
            // 
            // btnChooseWand
            // 
            this.btnChooseWand.Location = new System.Drawing.Point(703, 187);
            this.btnChooseWand.Name = "btnChooseWand";
            this.btnChooseWand.Size = new System.Drawing.Size(135, 38);
            this.btnChooseWand.TabIndex = 2;
            this.btnChooseWand.Text = "Choose Wand";
            this.btnChooseWand.UseVisualStyleBackColor = true;
            this.btnChooseWand.Click += new System.EventHandler(this.btnChooseWand_Click);
            // 
            // picBoxMageEquip
            // 
            this.picBoxMageEquip.Location = new System.Drawing.Point(396, 21);
            this.picBoxMageEquip.Name = "picBoxMageEquip";
            this.picBoxMageEquip.Size = new System.Drawing.Size(88, 408);
            this.picBoxMageEquip.TabIndex = 1;
            this.picBoxMageEquip.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdBtnMother);
            this.groupBox3.Controls.Add(this.rdBtnUltimate);
            this.groupBox3.Controls.Add(this.rdBtnDragon);
            this.groupBox3.Location = new System.Drawing.Point(54, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 182);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wand Choice";
            // 
            // rdBtnMother
            // 
            this.rdBtnMother.AutoSize = true;
            this.rdBtnMother.Location = new System.Drawing.Point(19, 85);
            this.rdBtnMother.Name = "rdBtnMother";
            this.rdBtnMother.Size = new System.Drawing.Size(120, 21);
            this.rdBtnMother.TabIndex = 2;
            this.rdBtnMother.TabStop = true;
            this.rdBtnMother.Text = "Mother Nature";
            this.rdBtnMother.UseVisualStyleBackColor = true;
            this.rdBtnMother.CheckedChanged += new System.EventHandler(this.rdBtnMother_CheckedChanged);
            // 
            // rdBtnUltimate
            // 
            this.rdBtnUltimate.AutoSize = true;
            this.rdBtnUltimate.Location = new System.Drawing.Point(19, 57);
            this.rdBtnUltimate.Name = "rdBtnUltimate";
            this.rdBtnUltimate.Size = new System.Drawing.Size(129, 21);
            this.rdBtnUltimate.TabIndex = 1;
            this.rdBtnUltimate.TabStop = true;
            this.rdBtnUltimate.Text = "Ultimate Energy";
            this.rdBtnUltimate.UseVisualStyleBackColor = true;
            this.rdBtnUltimate.CheckedChanged += new System.EventHandler(this.rdBtnUltimate_CheckedChanged);
            // 
            // rdBtnDragon
            // 
            this.rdBtnDragon.AutoSize = true;
            this.rdBtnDragon.Location = new System.Drawing.Point(19, 29);
            this.rdBtnDragon.Name = "rdBtnDragon";
            this.rdBtnDragon.Size = new System.Drawing.Size(109, 21);
            this.rdBtnDragon.TabIndex = 0;
            this.rdBtnDragon.TabStop = true;
            this.rdBtnDragon.Text = "Dragon Claw";
            this.rdBtnDragon.UseVisualStyleBackColor = true;
            this.rdBtnDragon.CheckedChanged += new System.EventHandler(this.rdBtnDragon_CheckedChanged);
            // 
            // btnChooseWeapon
            // 
            this.btnChooseWeapon.Location = new System.Drawing.Point(865, 176);
            this.btnChooseWeapon.Name = "btnChooseWeapon";
            this.btnChooseWeapon.Size = new System.Drawing.Size(115, 49);
            this.btnChooseWeapon.TabIndex = 9;
            this.btnChooseWeapon.Text = "Choose Weapon";
            this.btnChooseWeapon.UseVisualStyleBackColor = true;
            this.btnChooseWeapon.Click += new System.EventHandler(this.btnChooseWeapon_Click);
            // 
            // picBoxWeapons
            // 
            this.picBoxWeapons.Image = global::DraftHA.Properties.Resources.images;
            this.picBoxWeapons.Location = new System.Drawing.Point(399, 49);
            this.picBoxWeapons.Name = "picBoxWeapons";
            this.picBoxWeapons.Size = new System.Drawing.Size(334, 350);
            this.picBoxWeapons.TabIndex = 1;
            this.picBoxWeapons.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdBtnKatana);
            this.groupBox2.Controls.Add(this.rdBtnHammer);
            this.groupBox2.Controls.Add(this.rdBtnAxe);
            this.groupBox2.Location = new System.Drawing.Point(54, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 182);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weapon Choice";
            // 
            // rdBtnKatana
            // 
            this.rdBtnKatana.AutoSize = true;
            this.rdBtnKatana.Location = new System.Drawing.Point(19, 85);
            this.rdBtnKatana.Name = "rdBtnKatana";
            this.rdBtnKatana.Size = new System.Drawing.Size(74, 21);
            this.rdBtnKatana.TabIndex = 2;
            this.rdBtnKatana.TabStop = true;
            this.rdBtnKatana.Text = "Katana";
            this.rdBtnKatana.UseVisualStyleBackColor = true;
            this.rdBtnKatana.CheckedChanged += new System.EventHandler(this.rdBtnKatana_CheckedChanged_1);
            // 
            // rdBtnHammer
            // 
            this.rdBtnHammer.AutoSize = true;
            this.rdBtnHammer.Location = new System.Drawing.Point(19, 57);
            this.rdBtnHammer.Name = "rdBtnHammer";
            this.rdBtnHammer.Size = new System.Drawing.Size(112, 21);
            this.rdBtnHammer.TabIndex = 1;
            this.rdBtnHammer.TabStop = true;
            this.rdBtnHammer.Text = "War Hammer";
            this.rdBtnHammer.UseVisualStyleBackColor = true;
            this.rdBtnHammer.CheckedChanged += new System.EventHandler(this.rdBtnHammer_CheckedChanged_1);
            // 
            // rdBtnAxe
            // 
            this.rdBtnAxe.AutoSize = true;
            this.rdBtnAxe.Location = new System.Drawing.Point(19, 29);
            this.rdBtnAxe.Name = "rdBtnAxe";
            this.rdBtnAxe.Size = new System.Drawing.Size(92, 21);
            this.rdBtnAxe.TabIndex = 0;
            this.rdBtnAxe.TabStop = true;
            this.rdBtnAxe.Text = "Battle Axe";
            this.rdBtnAxe.UseVisualStyleBackColor = true;
            this.rdBtnAxe.CheckedChanged += new System.EventHandler(this.rdBtnAxe_CheckedChanged_1);
            // 
            // picBxAddChar
            // 
            this.picBxAddChar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBxAddChar.Image = global::DraftHA.Properties.Resources.images;
            this.picBxAddChar.Location = new System.Drawing.Point(399, 32);
            this.picBxAddChar.Name = "picBxAddChar";
            this.picBxAddChar.Size = new System.Drawing.Size(489, 399);
            this.picBxAddChar.TabIndex = 4;
            this.picBxAddChar.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnWarrior);
            this.groupBox1.Controls.Add(this.rdBtnMage);
            this.groupBox1.Location = new System.Drawing.Point(85, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 142);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Characters";
            // 
            // rdBtnWarrior
            // 
            this.rdBtnWarrior.AutoSize = true;
            this.rdBtnWarrior.Location = new System.Drawing.Point(19, 60);
            this.rdBtnWarrior.Name = "rdBtnWarrior";
            this.rdBtnWarrior.Size = new System.Drawing.Size(76, 21);
            this.rdBtnWarrior.TabIndex = 2;
            this.rdBtnWarrior.Text = "Warrior";
            this.rdBtnWarrior.UseVisualStyleBackColor = true;
            this.rdBtnWarrior.CheckedChanged += new System.EventHandler(this.rdBtnWarrior_CheckedChanged);
            // 
            // rdBtnMage
            // 
            this.rdBtnMage.AutoSize = true;
            this.rdBtnMage.Location = new System.Drawing.Point(19, 22);
            this.rdBtnMage.Name = "rdBtnMage";
            this.rdBtnMage.Size = new System.Drawing.Size(64, 21);
            this.rdBtnMage.TabIndex = 0;
            this.rdBtnMage.Text = "Mage";
            this.rdBtnMage.UseVisualStyleBackColor = true;
            this.rdBtnMage.CheckedChanged += new System.EventHandler(this.rdBtnMage_CheckedChanged);
            // 
            // btnCharChoice
            // 
            this.btnCharChoice.Location = new System.Drawing.Point(63, 403);
            this.btnCharChoice.Name = "btnCharChoice";
            this.btnCharChoice.Size = new System.Drawing.Size(142, 39);
            this.btnCharChoice.TabIndex = 6;
            this.btnCharChoice.Text = "Create";
            this.btnCharChoice.UseVisualStyleBackColor = true;
            this.btnCharChoice.Click += new System.EventHandler(this.btnCharChoice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Character Name: ";
            // 
            // txtBxCharName
            // 
            this.txtBxCharName.Location = new System.Drawing.Point(149, 288);
            this.txtBxCharName.Name = "txtBxCharName";
            this.txtBxCharName.Size = new System.Drawing.Size(187, 22);
            this.txtBxCharName.TabIndex = 13;
            // 
            // tbPgBattle
            // 
            this.tbPgBattle.Controls.Add(this.pnlBattle);
            this.tbPgBattle.Location = new System.Drawing.Point(4, 25);
            this.tbPgBattle.Name = "tbPgBattle";
            this.tbPgBattle.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgBattle.Size = new System.Drawing.Size(1163, 473);
            this.tbPgBattle.TabIndex = 2;
            this.tbPgBattle.Text = "Battle";
            this.tbPgBattle.UseVisualStyleBackColor = true;
            // 
            // pnlBattle
            // 
            this.pnlBattle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlBattle.Controls.Add(this.btnFight);
            this.pnlBattle.Controls.Add(this.tableLayoutPanel1);
            this.pnlBattle.Controls.Add(this.label7);
            this.pnlBattle.Controls.Add(this.btnGenRanEnemy);
            this.pnlBattle.Location = new System.Drawing.Point(-32, -59);
            this.pnlBattle.Name = "pnlBattle";
            this.pnlBattle.Size = new System.Drawing.Size(1227, 590);
            this.pnlBattle.TabIndex = 2;
            // 
            // btnFight
            // 
            this.btnFight.Enabled = false;
            this.btnFight.Location = new System.Drawing.Point(934, 185);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(110, 56);
            this.btnFight.TabIndex = 6;
            this.btnFight.Text = "Fight!";
            this.btnFight.UseVisualStyleBackColor = true;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.50388F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.49612F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.Controls.Add(this.txtBxEnemyLvlB, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBxCharLvlB, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBxEnemyPointsB, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBxLevel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBxEnemyNameB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBxEnemyHealthB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBxCharPointsB, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBxPoints, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBxCharNameB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBxCharHealthB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBxNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBxHealthLabel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(301, 86);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.28318F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.71682F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 188);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // txtBxEnemyLvlB
            // 
            this.txtBxEnemyLvlB.Location = new System.Drawing.Point(376, 116);
            this.txtBxEnemyLvlB.Name = "txtBxEnemyLvlB";
            this.txtBxEnemyLvlB.Size = new System.Drawing.Size(79, 22);
            this.txtBxEnemyLvlB.TabIndex = 11;
            this.txtBxEnemyLvlB.Text = "Level";
            // 
            // txtBxCharLvlB
            // 
            this.txtBxCharLvlB.Location = new System.Drawing.Point(376, 44);
            this.txtBxCharLvlB.Name = "txtBxCharLvlB";
            this.txtBxCharLvlB.Size = new System.Drawing.Size(79, 22);
            this.txtBxCharLvlB.TabIndex = 11;
            this.txtBxCharLvlB.Text = "Level";
            // 
            // txtBxEnemyPointsB
            // 
            this.txtBxEnemyPointsB.Location = new System.Drawing.Point(274, 116);
            this.txtBxEnemyPointsB.Name = "txtBxEnemyPointsB";
            this.txtBxEnemyPointsB.Size = new System.Drawing.Size(79, 22);
            this.txtBxEnemyPointsB.TabIndex = 10;
            this.txtBxEnemyPointsB.Text = "Points";
            // 
            // txtBxLevel
            // 
            this.txtBxLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxLevel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBxLevel.Location = new System.Drawing.Point(376, 3);
            this.txtBxLevel.Name = "txtBxLevel";
            this.txtBxLevel.Size = new System.Drawing.Size(79, 26);
            this.txtBxLevel.TabIndex = 7;
            this.txtBxLevel.Text = "Level";
            // 
            // txtBxEnemyNameB
            // 
            this.txtBxEnemyNameB.Location = new System.Drawing.Point(3, 116);
            this.txtBxEnemyNameB.Name = "txtBxEnemyNameB";
            this.txtBxEnemyNameB.Size = new System.Drawing.Size(158, 22);
            this.txtBxEnemyNameB.TabIndex = 8;
            this.txtBxEnemyNameB.Text = "Name";
            // 
            // txtBxEnemyHealthB
            // 
            this.txtBxEnemyHealthB.Location = new System.Drawing.Point(181, 116);
            this.txtBxEnemyHealthB.Name = "txtBxEnemyHealthB";
            this.txtBxEnemyHealthB.Size = new System.Drawing.Size(79, 22);
            this.txtBxEnemyHealthB.TabIndex = 9;
            this.txtBxEnemyHealthB.Text = "Health";
            // 
            // txtBxCharPointsB
            // 
            this.txtBxCharPointsB.Location = new System.Drawing.Point(274, 44);
            this.txtBxCharPointsB.Name = "txtBxCharPointsB";
            this.txtBxCharPointsB.Size = new System.Drawing.Size(79, 22);
            this.txtBxCharPointsB.TabIndex = 10;
            this.txtBxCharPointsB.Text = "Points";
            // 
            // txtBxPoints
            // 
            this.txtBxPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPoints.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBxPoints.Location = new System.Drawing.Point(274, 3);
            this.txtBxPoints.Name = "txtBxPoints";
            this.txtBxPoints.Size = new System.Drawing.Size(79, 26);
            this.txtBxPoints.TabIndex = 6;
            this.txtBxPoints.Text = "Points";
            // 
            // txtBxCharNameB
            // 
            this.txtBxCharNameB.Location = new System.Drawing.Point(3, 44);
            this.txtBxCharNameB.Name = "txtBxCharNameB";
            this.txtBxCharNameB.Size = new System.Drawing.Size(158, 22);
            this.txtBxCharNameB.TabIndex = 8;
            this.txtBxCharNameB.Text = "Name";
            // 
            // txtBxCharHealthB
            // 
            this.txtBxCharHealthB.Location = new System.Drawing.Point(181, 44);
            this.txtBxCharHealthB.Name = "txtBxCharHealthB";
            this.txtBxCharHealthB.Size = new System.Drawing.Size(79, 22);
            this.txtBxCharHealthB.TabIndex = 9;
            this.txtBxCharHealthB.Text = "Health";
            // 
            // txtBxNameLabel
            // 
            this.txtBxNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBxNameLabel.Location = new System.Drawing.Point(3, 3);
            this.txtBxNameLabel.Name = "txtBxNameLabel";
            this.txtBxNameLabel.Size = new System.Drawing.Size(158, 26);
            this.txtBxNameLabel.TabIndex = 0;
            this.txtBxNameLabel.Text = "Name";
            // 
            // txtBxHealthLabel
            // 
            this.txtBxHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxHealthLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBxHealthLabel.Location = new System.Drawing.Point(181, 3);
            this.txtBxHealthLabel.Name = "txtBxHealthLabel";
            this.txtBxHealthLabel.Size = new System.Drawing.Size(79, 26);
            this.txtBxHealthLabel.TabIndex = 4;
            this.txtBxHealthLabel.Text = "Health";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Your Chosen Character: ";
            // 
            // btnGenRanEnemy
            // 
            this.btnGenRanEnemy.Enabled = false;
            this.btnGenRanEnemy.Location = new System.Drawing.Point(95, 185);
            this.btnGenRanEnemy.Name = "btnGenRanEnemy";
            this.btnGenRanEnemy.Size = new System.Drawing.Size(164, 57);
            this.btnGenRanEnemy.TabIndex = 1;
            this.btnGenRanEnemy.Text = "Generate a random enemy";
            this.btnGenRanEnemy.UseVisualStyleBackColor = true;
            this.btnGenRanEnemy.Click += new System.EventHandler(this.btnGenRanEnemy_Click_1);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(304, 51);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(729, 50);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Dungeons and Dragons!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Mage2.png");
            this.imageList1.Images.SetKeyName(1, "Warrior2.png");
            // 
            // weaponImageList
            // 
            this.weaponImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("weaponImageList.ImageStream")));
            this.weaponImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.weaponImageList.Images.SetKeyName(0, "Weapon1.png");
            this.weaponImageList.Images.SetKeyName(1, "Weapon2.png");
            this.weaponImageList.Images.SetKeyName(2, "Weapon3.png");
            // 
            // imgListMageEquip
            // 
            this.imgListMageEquip.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListMageEquip.ImageStream")));
            this.imgListMageEquip.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListMageEquip.Images.SetKeyName(0, "Dragon Claw.jpg");
            this.imgListMageEquip.Images.SetKeyName(1, "Mother Nature.jpg");
            this.imgListMageEquip.Images.SetKeyName(2, "Ultimate Energy.jpg");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 693);
            this.Controls.Add(this.pnlPlayerChoose);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.pnlPlayerChoose.ResumeLayout(false);
            this.pnlPlayerChoose.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbPgCharList.ResumeLayout(false);
            this.tbPgCharList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxCharList)).EndInit();
            this.tbPgNewCharacter.ResumeLayout(false);
            this.tbPgNewCharacter.PerformLayout();
            this.pnlEquipWarrior.ResumeLayout(false);
            this.pnlEquipMage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMageEquip)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWeapons)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxAddChar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbPgBattle.ResumeLayout(false);
            this.pnlBattle.ResumeLayout(false);
            this.pnlBattle.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlayerChoose;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picBxAddChar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtnWarrior;
        private System.Windows.Forms.RadioButton rdBtnMage;
        private System.Windows.Forms.Button btnCharChoice;
        private System.Windows.Forms.ImageList weaponImageList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPgCharList;
        private System.Windows.Forms.TabPage tbPgNewCharacter;
        private System.Windows.Forms.PictureBox picBxCharList;
        private System.Windows.Forms.ListBox lstBxAllChars;
        private System.Windows.Forms.Button btnAllChars;
        private System.Windows.Forms.Button btnCharChoose;
        private System.Windows.Forms.TabPage tbPgBattle;
        private System.Windows.Forms.Panel pnlEquipWarrior;
        private System.Windows.Forms.PictureBox picBoxWeapons;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdBtnKatana;
        private System.Windows.Forms.RadioButton rdBtnHammer;
        private System.Windows.Forms.RadioButton rdBtnAxe;
        private System.Windows.Forms.Panel pnlBattle;
        private System.Windows.Forms.Button btnGenRanEnemy;
        private System.Windows.Forms.Panel pnlEquipMage;
        private System.Windows.Forms.PictureBox picBoxMageEquip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdBtnMother;
        private System.Windows.Forms.RadioButton rdBtnUltimate;
        private System.Windows.Forms.RadioButton rdBtnDragon;
        private System.Windows.Forms.ImageList imgListMageEquip;
        private System.Windows.Forms.Button btnChooseWand;
        private System.Windows.Forms.Button btnChooseWeapon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCharLevel;
        private System.Windows.Forms.Label lblCharPoints;
        private System.Windows.Forms.Label lblCharHealth;
        private System.Windows.Forms.Label lblCharName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxCharName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBxHealthLabel;
        private System.Windows.Forms.TextBox txtBxNameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtBxEnemyLvlB;
        private System.Windows.Forms.TextBox txtBxCharLvlB;
        private System.Windows.Forms.TextBox txtBxEnemyPointsB;
        private System.Windows.Forms.TextBox txtBxLevel;
        private System.Windows.Forms.TextBox txtBxEnemyNameB;
        private System.Windows.Forms.TextBox txtBxEnemyHealthB;
        private System.Windows.Forms.TextBox txtBxCharPointsB;
        private System.Windows.Forms.TextBox txtBxPoints;
        private System.Windows.Forms.TextBox txtBxCharNameB;
        private System.Windows.Forms.TextBox txtBxCharHealthB;
        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.Label lblLoses;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label label8;
    }
}

