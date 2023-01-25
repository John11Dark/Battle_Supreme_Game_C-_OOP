using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using DraftHA.Classes;

namespace DraftHA
{
    public partial class Form1 : Form
    {
        //Change 1
        static Panel nextPanel;

        static string nextPanelStr = "";
        static string wandName = "";
        static string weaponName = "";
        static string newCharName = "";

        // ? i set a value of 6 instead of 0 for hit points cause it's never used in the global scope. so i make benefit of it
        static int hitPoints = 6;
        static int tempCharIndex = -1;
        static int chosenCharacterIndex = -1;
        static int randomIndex = -1;
        static int deadCharacters = 0;

        static Character temporaryCharacter;
        static Character playerCharacter;
        static Character enemyCharacter;

        static List<Character> charactersList = new List<Character>();

        static Random random = new Random();

        //Change 2
        public Form1()
        {
            InitializeComponent();
            //--> create a warrior 
            Warrior warrior = new Warrior("Sword Master");
            //--> create a weapon
            Weapon weapon = new Weapon("battle axe", hitPoints);
            //--> assign the weapon to the warrior object
            warrior.setWeapon(weapon);
            //--> add the warrior to the characters list
            charactersList.Add(warrior);
            //--> create a mage
            Mage mage = new Mage("Kazuo Kiriyama");
            //--> create a wand
            Wand wand = new Wand("ultimate energy", hitPoints);
            //--> assign the wand to the mage object
            mage.setWand(wand);
            //--> add the mage to the characters list
            charactersList.Add(mage);
        }

        //Change 3          
        private void btnAllChars_Click(object sender, EventArgs e)
        {
            if (charactersList.Count <= 0)
            {
                MessageBox.Show(@"You must create a character first!", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Clear the previously shown list of characters to display the updated characters list
            lstBxAllChars.Items.Clear();

            //--> foreach Character in the characters list
            //--> add the type and the character name (formula shown in brief)

            foreach (string value in charactersList.Select(
                         character => $"{character.GetType().Name} : {character.name}"))
            {
                lstBxAllChars.Items.Add(value);
            }

        }

        //Change 4
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //The if statement is used as a Validation, to ensure that an actual character has been selected rather than an empty slot in the list box
            if (lstBxAllChars.SelectedItem == null) return;
            // ? instead of wrapping all code inside if statement just check if the character is equal to null return its a cleaner way
            string selectedItem = lstBxAllChars.SelectedItem.ToString();
            string
                charType = selectedItem
                    .Split(':')[0]; //fetching the first part of the string which is the character's type

            //Depending on the charType the corresponding image will be displayed in the picture box
            switch (charType)
            {
                case "Mage":
                    picBxCharList.Image = imageList1.Images[0];
                    break;
                case "Warrior":
                    picBxCharList.Image = imageList1.Images[1];
                    break;
            }

            //The index of the selected character from the list box is assigned to the tempCharIndex
            //This index should be used to fetch the corresponding character from the characters list since the same index in the list box and the characters list is used
            tempCharIndex = lstBxAllChars.SelectedIndex;

            //--> Fetch the temp player Character object from the characters list using tempCharIndex
            temporaryCharacter = charactersList[tempCharIndex];
            // The following labels should be assigned to the corresponding fields of the tempPlayerCharacter

            //--> lblCharName.Text 
            lblCharName.Text = temporaryCharacter.name;
            //--> lblCharHealth.Text 

            lblCharHealth.Text = temporaryCharacter.health.ToString();
            //--> lblCharPoints.Text 
            lblCharPoints.Text = temporaryCharacter.getPoints().ToString();

            //--> lblCharLevel.Text 
            lblCharLevel.Text = temporaryCharacter.level.ToString();

            //--> lblLoses.Text
            lblLoses.Text = temporaryCharacter.getLoses().ToString();

            //--> lblWins.Text 
            lblWins.Text = temporaryCharacter.getVictories().ToString();


            //--> if tempPlayerCharacter's health is less or equal to 0 then
            //--> btnCharChoose.Enabled = false;
            //--> else
            //-->  btnCharChoose.Enabled = true;


            // if (temporaryCharacter.health <= 0)
            // {
            //     btnCharChoose.Enabled = false;
            // }
            // else
            // {
            //    btnCharChoose.Enabled = true;
            // }

            btnCharChoose.Enabled = temporaryCharacter.health > 0;
        }

        //Change 5
        private void btnCharChoose_Click(object sender, EventArgs e)
        {
            //--> set the player character object to the temp player character object
            playerCharacter = temporaryCharacter;
            //--> set the current character index variable to the temp character index variable
            chosenCharacterIndex = tempCharIndex;
            btnGenRanEnemy.Enabled = true;

            // The following text boxes should be assigned to the corresponding fields of the Player Character object

            //--> txtBxCharNameB.Text
            txtBxCharNameB.Text = playerCharacter.name;

            //--> txtBxCharHealthB.Text
            txtBxCharHealthB.Text = playerCharacter.health.ToString();

            //--> txtBxCharPointsB.Text
            txtBxCharPointsB.Text = playerCharacter.getPoints().ToString();

            //--> txtBxCharLvlB.Text
            txtBxCharLvlB.Text = playerCharacter.level.ToString();
        }

        //Change 6
        private void btnChooseWeapon_Click(object sender, EventArgs e)
        {
            //If the Weapon has been chosen, all the necessary data now has been extracted to create a new Warrior character

            //You need to complete the following comments to actually create this object

            //--> create a new Warrior using newCharName (assigned from the "Character Choice Button" click event)
            Warrior warrior = new Warrior(newCharName);

            //--> create a new Weapon using weaponName and hitPoints
            Weapon weapon = new Weapon(weaponName, hitPoints);

            // ? ==> in the brief it says assign the weapon
            warrior.setWeapon(weapon);

            //--> add the new warrior to the characters list
            charactersList.Add(warrior);

            //panel has been reset accordingly            
            pnlEquipWarrior.Visible = false;
        }

        //Change 7
        private void btnChooseWand_Click(object sender, EventArgs e)
        {
            //If the Wand has been chosen, all the necessary data now has been extracted to create a new Mage character

            //You need to complete the following comments to actually create this object

            //--> create a new Mage using newCharName (assigned from the "Character Choice Button" click event)
            Mage mage = new Mage(newCharName);

            //--> create a new Wand using wandName and hitPoints
            Wand wand = new Wand(wandName, hitPoints);

            // ? ==> in the brief it says assign the weapon
            mage.setWand(wand);

            //--> add the new mage to the characters list
            charactersList.Add(mage);

            //panels have been reset accordingly
            pnlEquipWarrior.Visible = false;
            pnlEquipMage.Visible = false;
        }

        //Change 8
        private void btnGenRanEnemy_Click_1(object sender, EventArgs e)
        {
            if (charactersList.Count <= deadCharacters || playerCharacter.health <= 0) return;


            do
            {
                randomIndex = random.Next(0, charactersList.Count);
                enemyCharacter = charactersList[randomIndex];
            } while (randomIndex == chosenCharacterIndex || enemyCharacter.health <= 0);

            btnFight.Enabled = true;

            txtBxEnemyNameB.Text = enemyCharacter.name;
            txtBxEnemyHealthB.Text = enemyCharacter.health.ToString();
            txtBxEnemyPointsB.Text = enemyCharacter.getPoints().ToString();
            txtBxEnemyLvlB.Text = enemyCharacter.level.ToString();
        }

        //Change 9
        private void btnFight_Click(object sender, EventArgs e)
        {
            int playerRange = playerCharacter.level * 20;
            int enemyRange = enemyCharacter.level * 20;

            int randomRange = random.Next(1, (playerRange + enemyRange));


            if (playerRange >= randomRange)
            {
                playerCharacter.battle(true, enemyCharacter);
                enemyCharacter.battle(false, playerCharacter);
            }
            else
            {
                playerCharacter.battle(false, enemyCharacter);
                enemyCharacter.battle(true, playerCharacter);
            }


            // update Ui 
            // txtBxCharNameB.Text = playerCharacter.name;
            txtBxCharHealthB.Text = playerCharacter.health.ToString();
            txtBxCharPointsB.Text = playerCharacter.getPoints().ToString();
            txtBxCharLvlB.Text = playerCharacter.level.ToString();


            // txtBxEnemyNameB.Text = enemyCharacter.name;
            txtBxEnemyHealthB.Text = enemyCharacter.health.ToString();
            txtBxEnemyPointsB.Text = enemyCharacter.getPoints().ToString();
            txtBxEnemyLvlB.Text = enemyCharacter.level.ToString();


            if (playerCharacter.health <= 0 || enemyCharacter.health <= 0)
            {
                btnFight.Enabled = false;
                deadCharacters++;
            }

        }


        private void btnCharChoice_Click(object sender, EventArgs e)
        {
            //newCharName is assigned with the text inserted in the text box used for the user to write the new character's name
            if (txtBxCharName.Text.Length == 0 || !Regex.IsMatch(txtBxCharName.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show(@"Character name can not be left empty! and must contain only letters", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxCharName.BackColor = Color.Firebrick;
                txtBxCharName.Focus();
            }
            else
            {
                txtBxCharName.BackColor = Color.White;
                newCharName = txtBxCharName.Text;
                txtBxCharName.Text = ""; //clear the text box to be ready for any new characters to be created

                //The below code is set to change the panel viewing to allow the user to create more characters
                if (nextPanelStr == "pnlEquipWarrior")
                    pnlEquipWarrior.Visible = true;
                else if (nextPanelStr == "pnlEquipMage")
                {
                    pnlEquipWarrior.Visible = true;
                    pnlEquipMage.Visible = true;
                }
            }
        }

        //No need to update

        private void rdBtnMage_CheckedChanged(object sender, EventArgs e)
        {
            //If the mage radio button is checked then
            //the picture box should show the first image in the imageList1 since it's a Mage image
            picBxAddChar.Image = imageList1.Images[0];

            //next panel to be shown is the panel having the GUI to choose a wand for the mage
            nextPanel = pnlEquipMage;
            nextPanelStr = "pnlEquipMage";
        }

        private void rdBtnWarrior_CheckedChanged(object sender, EventArgs e)
        {
            //If the warrior radio button is checked then
            //the picture box should show the third image in the imageList1 since it's a Warrior image
            picBxAddChar.Image = imageList1.Images[1];

            //next panel to be shown is the panel having the GUI to choose a weapon for the warrior
            nextPanel = pnlEquipWarrior;
            nextPanelStr = "pnlEquipWarrior";
        }


        private void rdBtnDragon_CheckedChanged(object sender, EventArgs e)
        {
            //If the dragon claw radio button is checked then
            //the picture box should show the first image in the imgListMageEquip since it's a Dragon Claw image
            picBoxMageEquip.Image = imgListMageEquip.Images[0];

            //Set the variables with the details for Dragon Claw to be used when the wand is then created
            wandName = "Dragon Claw";
            hitPoints = 15;
        }

        private void rdBtnUltimate_CheckedChanged(object sender, EventArgs e)
        {
            //If the Ultimate energy radio button is checked then
            //the picture box should show the third image in the imgListMageEquip since it's an Ultimate Energy image
            picBoxMageEquip.Image = imgListMageEquip.Images[2];

            //Set the variables with the details for Ultimate Energy to be used when the wand is then created
            wandName = "Ultimate Energy";
            hitPoints = 25;
        }

        private void rdBtnMother_CheckedChanged(object sender, EventArgs e)
        {
            //If the Mother Nature radio button is checked then
            //the picture box should show the second image in the imgListMageEquip since it's a Mother Nature image
            picBoxMageEquip.Image = imgListMageEquip.Images[1];

            //Set the variables with the details for Mother Nature to be used when the wand is then created
            wandName = "Mother Nature";
            hitPoints = 20;
        }

        private void rdBtnAxe_CheckedChanged_1(object sender, EventArgs e)
        {
            //If the battle Axe radio button is checked then
            //the picture box should show the first image in the imgListMageEquip since it's a battle Axe image
            picBoxWeapons.Image = weaponImageList.Images[0];

            //Set the variables with the details for battle Axe to be used when the weapon is then created
            weaponName = "battle Axe";
            hitPoints = 10;
        }

        private void rdBtnHammer_CheckedChanged_1(object sender, EventArgs e)
        {
            //If the War Hammer radio button is checked then
            //the picture box should show the second image in the imgListMageEquip since it's a War Hammer image
            picBoxWeapons.Image = weaponImageList.Images[1];

            //Set the variables with the details for War Hammer to be used when the weapon is then created
            weaponName = "War Hammer";
            hitPoints = 15;
        }

        private void rdBtnKatana_CheckedChanged_1(object sender, EventArgs e)
        {
            //If the Katana radio button is checked then
            //the picture box should show the third image in the imgListMageEquip since it's a Katana image
            picBoxWeapons.Image = weaponImageList.Images[2];

            //Set the variables with the details for Katana to be used when the weapon is then created
            weaponName = "Katana";
            hitPoints = 20;
        }

    }
}
