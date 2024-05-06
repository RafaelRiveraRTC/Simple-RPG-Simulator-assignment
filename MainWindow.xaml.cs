//Rafael Rivera Harrison
//5/5/2024
//Assignment: Classes, Lists, and All of our controls
//CSI122 002 13635
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Simple_RPG_Simulator_assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Dnd_Classes> classes = new List<Dnd_Classes>();//This list holds the main dnd Classes

      //These Lists Below hold the subClasses for each class respectively


        //For each of the classes i gave each of them the ability to have their stats randomly generated,however depending on the class that you selected,you will 
        //have increased rolling odds in certain stats
        List<string> fighterSubClass = new List<string>
        {
            "(Champion)",
            "(Eldritch Knight)",
            "(Samurai)",
            "(Arcane Archer)",
            "(Gunslinger)"

        };

        List<int> fighterStats = new List<int>
        {
             20 , 80,//This Represents the Health you can roll

             14, 18,//This Represents the Strength You Can roll

             10, 18,//This Represents the Dexterity You Can roll

             14, 18,//This Represents the Constitution You Can roll

             10, 18,//This Represents the Intellegnece You Can roll

             8, 18,//This Represents the Wisdom You Can roll

             8, 18,//This Represents the Charisma You Can roll
        };

        List<string> wizardSubClass = new List<string>
        {
            "(Bladesinger)",
            "(Graviturgy)",
            "(School of Conjuration)",
            "(School of Necromancy )",
            "(War Magic)"

        };

        List<int> wizardStats = new List<int>
        {
             20 , 80,//This Represents the Health you can roll

             8, 18,//This Represents the Strength You Can roll

             10, 18,//This Represents the Dexterity You Can roll

             12, 18,//This Represents the Constitution You Can roll

             14, 18,//This Represents the Intelligence You Can roll

             14, 18,//This Represents the Wisdom You Can roll

             8, 18,//This Represents the Charisma You Can roll
        };

        List<string> rangerSubClass = new List<string>
        {
            "(Drakewarden)",
            "(Fey Wanderer)",
            "(Gloom Stalker)",
            "(Horizon Walker)",
            "(Swarmkeeper)"

        };

        List<int> rangerStats = new List<int>
        {
             20 , 80,//This Represents the Health you can roll

             10, 18,//This Represents the Strength You Can roll

             14, 18,//This Represents the Dexterity You Can roll

             12, 18,//This Represents the Constitution You Can roll

             8, 18,//This Represents the Intelligence You Can roll

             14, 18,//This Represents the Wisdom You Can roll

             8, 18,//This Represents the Charisma You Can roll
        };

        List<string> warlockSubClass = new List<string>
        {
            "(The Celestial)",
            "(The Fiend )",
            "(The Genie)",
            "(The Hexblade)",
            "(The Undead)"

        };

        List<int> warlockStats = new List<int>
        {
            20 , 80,//This Represents the Health you can roll

             8, 18,//This Represents the Strength You Can roll

             14, 18,//This Represents the Dexterity You Can roll

             12, 18,//This Represents the Constitution You Can roll

             8, 18,//This Represents the Intelligence You Can roll

             10, 18,//This Represents the Wisdom You Can roll

             14, 18,//This Represents the Charisma You Can roll
        };

        List<string> druidSubClass = new List<string>
        {
            "(Circle of Dreams )",
            "(Circle of Stars)",
            "(Circle of Wildfire)",
            "(Circle of the Moon)",
            "(Circle of the Shepherd)"

        };

        List<int> druidStats = new List<int>
        {
             20 , 80,//This Represents the Health you can roll

             8, 18,//This Represents the Strength You Can roll

             12, 18,//This Represents the Dexterity You Can roll

             14, 18,//This Represents the Constitution You Can roll

             10, 18,//This Represents the Intelligence You Can roll

             14, 18,//This Represents the Wisdom You Can roll

             8, 18,//This Represents the Charisma You Can roll
        };

        List<string> monkSubClass = new List<string>
        {
            "(Way of Shadow)",
            "(Way of the Astral Self)",
            "(Way of the Kensei)",
            "(Way of the Long Death)",
            "(Way of the Sun Soul)"

        };

        List<int> monkStats = new List<int>
        {
            20 , 80,//This Represents the Health you can roll

             10, 18,//This Represents the Strength You Can roll

             14, 18,//This Represents the Dexterity You Can roll

             12, 18,//This Represents the Constitution You Can roll

             8, 18,//This Represents the Intelligence You Can roll

             14, 18,//This Represents the Wisdom You Can roll

             8, 18,//This Represents the Charisma You Can roll
        };

        List<string> paladinSubClass = new List<string>
        {
            "(Oath of Conquest )",
            "(Oath of Glory)",
            "(Oath of the Ancients )",
            "(Oath of Vengeance)",
            "(Oathbreaker)"

        };

        List<int> paladinStats = new List<int>
        {
             20 , 80,//This Represents the Health you can roll

             14, 18,//This Represents the Strength You Can roll

             8, 18,//This Represents the Dexterity You Can roll

             12, 18,//This Represents the Constitution You Can roll

             8, 18,//This Represents the Intelligence You Can roll

             10, 18,//This Represents The Wisdom You can roll

             14, 18,//This Represents the Charisma You can roll
        };

        List<string> clericSubClass = new List<string>
        {
            "(Death Domain)",
            "(Life Domain)",
            "(Tempest Domain)",
            "(Twilight Domain)",
            "(War Domain)"

        };

        List<int> clericStats = new List<int>
        {
             20 , 80,//This Represents the Health you can roll

             12, 18,//This Represents the Strength You Can roll

             10, 18,//This Represents the Dexterity You Can roll

             14, 18,//This Represents the Constitution You Can roll

             8, 18,//This Represents the Intelligence You Can roll

             14, 18,//This Represents the Wisdom You Can roll

             8, 18,//This Represents the Charisma You Can roll
        };

        List<string> barberianSubClass = new List<string>
        {
            "(Path of the Ancestral Guardian)",
            "(Path of the Beast)",
            "(Path of the Storm Herald)",
            "(Path of the Totem Warrior)",
            "(Path of the Zealot)"
        };

        List<int> barberianStats = new List<int>
        {
             20 , 80,//This Represents the Health you can roll

             14, 18,//This Represents the Strength You Can roll

             10, 18,//This Represents the Dexterity You Can roll

             14, 18,//This Represents the Constitution You Can roll

             8, 18,//This Represents the Intelligence You Can roll

             12, 18,//This Represents the Wisdom You Can roll

             8, 18,//This Represents the Charisma You Can roll
        };

        List<string> bardSubClass = new List<string>
        {
            "(College of Creation)",
            "(College of Eloquence)",
            "(College of Lore)",
            "(College of Swords)",
            "(College of Whispers)"

        };

        List<int> bardStats = new List<int>
        {
             20 , 80,//This Represents the Health you can roll

             8, 18,//This Represents the Strength You Can roll

             14, 18,//This Represents the Dexterity You Can roll

             10, 18,//This Represents the Constitution You Can roll

             12, 18,//This Represents the Intelligence You Can roll

             8, 18,//This Represents the Wisdom You Can roll

             14, 18,//This Represents the Charisma You Can roll
        };

        List<string> rogueSubClass = new List<string>
        {
            "(Assassin)",
            "(Phantom)",
            "(Scout)",
            "(Swashbuckler)",
            "(Thief)"

        };

        List<int> rogueStats = new List<int>
        {
            20 , 80,//This Represents the Health you can roll

             8, 18,//This Represents the Strength You Can roll

             14, 18,//This Represents the Dexterity You Can roll

             10, 18,//This Represents the Constitution You Can roll

             12, 18,//This Represents the Intelligence You Can roll

             8, 18,//This Represents the Wisdom You Can roll

             14, 18,//This Represents the Charisma You Can roll
        };

        List<string> artificerSubClass = new List<string>
        {
            "(Alchemist)",
            "(Armorer)",
            "(Artillerist)",
            "(Battle Smith)"


        };

        List<int> artificerStats = new List<int>
        {
             20 , 80,//This Represents the Health you can roll

             8, 18,//This Represents the Strength You Can roll

             12, 18,//This Represents the Dexterity You Can roll

             14, 18,//This Represents the Constitution You Can roll

             14, 18,//This Represents the Intelligence You Can roll

             10, 18,//This Represents the Wisdom You Can roll

             8, 18,//This Represents the Charisma You Can roll
        };

        List<string> sorcererSubClass = new List<string>
        {
            "(Clockwork Soul)",
            "(Divine Soul)",
            "(Storm Sorcery)",
            "(Wild Magic)",
            "(Draconic Bloodline)"

        };

        List<int> sorcererStats = new List<int>
        {
             20 , 80,//This Represents the Health you can roll

             8, 18,//This Represents the Strength You Can roll

             10, 18,//This Represents the Dexterity You Can roll

             14, 18,//This Represents the Constitution You Can roll

             8, 18,//This Represents the Intelligence You Can roll

             12, 18,//This Represents the Wisdom You Can roll

             14, 18,//This Represents the Charisma You Can roll
        };

        List<string> bloodhunterSubClass = new List<string>
        {
            "(Order of The Ghostslayer)",
            "(Order of The Lycan)",
            "(Order of The Mutant)",
            "(Order of The Profane Soul)"


        };

        List<int> bloodhunterStats = new List<int>
        {
             20 , 80,//This Represents the Health you can roll

             12, 18,//This Represents the Strength You Can roll

             10, 18,//This Represents the Dexterity You Can roll

             14, 18,//This Represents the Constitution You Can roll

             14, 18,//This Represents the Intelligence You Can roll

             8, 18,//This Represents the Wisdom You Can roll

             8, 18,//This Represents the Charisma You Can roll
        };

        string characterName;

        string levelSelect;

        string raceSelect;

        string classSelection;

        string subClassSelect;

        private int selectedCmbIndex;



        //Place the string in the partial class so they can be refrenced throughout the document


        
        public MainWindow()
        {
            InitializeComponent();

            //cmbNames.Items.Add("Fighter");
            //cmbNames.Items.Add("Wizard");
            //cmbNames.Items.Add("Ranger");
            //cmbNames.Items.Add("Warlock");
            //cmbNames.Items.Add("Druid");
            //cmbNames.Items.Add("Monk");
            //cmbNames.Items.Add("Paladin");
            //cmbNames.Items.Add("Cleric");
            //cmbNames.Items.Add("Barberian");
            //cmbNames.Items.Add("Bard");
            //cmbNames.Items.Add("Rouge");
            //cmbNames.Items.Add("Artificer");
            //cmbNames.Items.Add("Sorcerer");
            //cmbNames.Items.Add("Blood hunter");

            //This was the original list of characters,but i used the items source and selected index method in order to associate Each class with their respective subclasses

            classes.Add(new Dnd_Classes("Fighter", fighterSubClass, new Stats("Fighter", fighterStats)));
            classes.Add(new Dnd_Classes("Wizard", wizardSubClass, new Stats("Wizard", wizardStats)));
            classes.Add(new Dnd_Classes("Ranger", rangerSubClass, new Stats("Ranger", rangerStats)));
            classes.Add(new Dnd_Classes("Warlock", warlockSubClass, new Stats("Warlock", warlockStats)));
            classes.Add(new Dnd_Classes("Druid", druidSubClass, new Stats("Druid", druidStats)));
            classes.Add(new Dnd_Classes("Monk", monkSubClass, new Stats("Monk", monkStats)));
            classes.Add(new Dnd_Classes("Paladin", paladinSubClass, new Stats("Paladin", paladinStats)));
            classes.Add(new Dnd_Classes("Cleric", clericSubClass, new Stats("Cleric", clericStats)));
            classes.Add(new Dnd_Classes("Barberian", barberianSubClass, new Stats("Barberian", barberianStats)));
            classes.Add(new Dnd_Classes("Bard", bardSubClass, new Stats("Bard", bardStats)));
            classes.Add(new Dnd_Classes("Rogue", rogueSubClass, new Stats("Rogue", rogueStats)));
            classes.Add(new Dnd_Classes("Artificer", artificerSubClass, new Stats("Artificer", artificerStats)));
            classes.Add(new Dnd_Classes("Sorcerer", sorcererSubClass, new Stats("Sorcerer", sorcererStats)));
            classes.Add(new Dnd_Classes("Blood hunter", bloodhunterSubClass, new Stats("Blood hunter", bloodhunterStats)));


            //.Items creates the items to be placed in the list,whereas .Add will add the items to the respective list

            //Level List
             cmbNames_LvL.Items.Add("1");
             cmbNames_LvL.Items.Add("2");
             cmbNames_LvL.Items.Add("3");
             cmbNames_LvL.Items.Add("4");
             cmbNames_LvL.Items.Add("5");
             cmbNames_LvL.Items.Add("6");
             cmbNames_LvL.Items.Add("7");
             cmbNames_LvL.Items.Add("8");
             cmbNames_LvL.Items.Add("9");
             cmbNames_LvL.Items.Add("10");
             cmbNames_LvL.Items.Add("11");
             cmbNames_LvL.Items.Add("12");
             cmbNames_LvL.Items.Add("13");
             cmbNames_LvL.Items.Add("14");
             cmbNames_LvL.Items.Add("15");
             cmbNames_LvL.Items.Add("16");
             cmbNames_LvL.Items.Add("17");
             cmbNames_LvL.Items.Add("18");
             cmbNames_LvL.Items.Add("19");
             cmbNames_LvL.Items.Add("20");

            //Race List
            cmbNames_Race.Items.Add("Aarakocra");
            cmbNames_Race.Items.Add("Aasimar");
            cmbNames_Race.Items.Add("Bugbear");
            cmbNames_Race.Items.Add("Centaur");
            cmbNames_Race.Items.Add("Changeling");
            cmbNames_Race.Items.Add("Dragonborn");
            cmbNames_Race.Items.Add("Dwarf");
            cmbNames_Race.Items.Add("Elf");
            cmbNames_Race.Items.Add("Human");
            cmbNames_Race.Items.Add("Lizardfolk");
            cmbNames_Race.Items.Add("Tiefling");
            cmbNames_Race.Items.Add("Tortle");
            cmbNames_Race.Items.Add("Warforged");
            cmbNames_Race.Items.Add("Yuan-ti");

           
            //.ItemsSource
            cmbNames.ItemsSource = classes;
            cmbNames.SelectedIndex = 0;
        }

        private void ItsHeroTime_Click(object sender, RoutedEventArgs e)
        {
            //These are refrencing the names that i have set insode of the main Window
            characterName = playerName.Text;

            levelSelect = cmbNames_LvL.Text;

            raceSelect = cmbNames_Race.Text;

            classSelection = cmbNames.Text;

            subClassSelect = cmbNames_Subclass.Text;

            classes[selectedCmbIndex].Stats.RerollStats();

            //These are the random stat values that will generate whenever a character has been created.
            //The stats are being randomized in another class called stats,which are then stored in the stat lists for each of the classes i have created
            int health = classes[selectedCmbIndex].Stats.Health;

            int Str = classes[selectedCmbIndex].Stats.Str;

            int Dex = classes[selectedCmbIndex].Stats.Dex;

            int Con = classes[selectedCmbIndex].Stats.Con;

            int Int = classes[selectedCmbIndex].Stats.Int;

            int Wis = classes[selectedCmbIndex].Stats.Wis;

            int Cha = classes[selectedCmbIndex].Stats.Cha;

            string infoComplete = $"Name: {characterName}  Level: {levelSelect} Race: {raceSelect} Class: {classSelection} SubClass: {subClassSelect} Stats:(Health:{health} Strength:{Str} Dexterity: {Dex} Constitution: {Con} Intelligence: {Int} Wisdom: {Wis} Charisma: {Cha}) \n";
            //if the userName box is empty,it will display the following message
            if (string.IsNullOrEmpty(subClassSelect) || string.IsNullOrEmpty(levelSelect) || string.IsNullOrEmpty(raceSelect) || string.IsNullOrEmpty(classSelection)||string.IsNullOrEmpty(characterName))
            {
                MessageBox.Show("I'm sorry this isn't enough info,please try again");
            }
            else if(characterName.Length < 10)
            {
                //if the userNsme is less then 10 characters this message will display
                MessageBox.Show("This Username is not long enough please try again");
                playerName.Clear();
            }
            else
            {
                partyDisplayBox.Text += infoComplete;
                playerName.Clear();
            }


        }

        
        private void cmbNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //this allows the subClass box to change depending on what Main class is currently selected.
            this.selectedCmbIndex = cmbNames.SelectedIndex;

            cmbNames_Subclass.ItemsSource = classes[this.selectedCmbIndex].PersonalList;
        }

        private void BeginOurJourney_Click(object sender, RoutedEventArgs e)
        {
            string boxCheck = partyDisplayBox.Text;
            if (string.IsNullOrEmpty(boxCheck)){
                MessageBox.Show("Please Create Your Character Before You Start On Your Journey");
            }
            else
            {
                MessageBox.Show("Thank You For Your Selection,Let our journey Begin");
            }
            

          
        }
    }
}