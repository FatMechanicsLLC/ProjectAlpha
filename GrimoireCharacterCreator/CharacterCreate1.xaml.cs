using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GrimoireCharacterCreator
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CharacterCreate1 : Page
    {
        private string ThiefDescription = "Thief";
        private string SlayerDescription = "Slayer";
        private string TechnoDescription = "Techno";
        private string CourtesanDescription = "Courtesan";
        private string AssassinDescription = "Assassin";
        private string AlchemistDescription = "Alchemist";
        private string RuneWeaverDescription = "Rune Weaver";
        private string SaintDescription = "Saint";
        private string OutlawDescription = "Outlaw";
        private string WarriorDescription = "Warrior";
        private string ClericDescription = "Cleric";
        private string MonkDescription = "Monk";
        private string MageDescription = "Mage";
        private string IllusionistDescription = "Illusionist";
        private string BardDescription = "Bard";
        private string DruidDescription = "Druid";
        private string RangerDescription = "Ranger";
        private string BarbarianDescription = "Barbarian";
        private string MedicineManDescription = "Medicine Man";
        private string PsychicDescription = "Pyschic";
        private string HighwayManDescription = "Highway Man";
        private string NinjaDescription = "Ninja";
        private string TraderDescription = "Trader";
        private string SlaverDescription = "Slaver";
        private string SageDescription = "Sage";
        private string WitchHunterDescription = "Witch Hunter";
        private string PaladinDescription = "Paladin";

        private string Sex_Male = "Male";
        private string Sex_Descrip_Male = "Male sex of the species";
        private string Sex_Female = "Female";
        private string Sex_Descrip_Female = "Female sex of the species";
        private string Sex_Both = "Both";
        private string Sex_Descrip_Both = "Asexual species";
        private string Sex_Other = "Other";
        private string Sex_Descrip_Other = "Unknown sexual type of the species";

        private string Race_Elf = "Elf";
        private string Race_Dwarf = "Dwarf";
        private string Race_Human = "Human";

        CCharacter Character;

        public CharacterCreate1()
        {
            this.InitializeComponent();

            PopulateClassList();
            PopulateSexList();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Character = (CCharacter) e.Parameter;
        }

        private async void Button_Continue_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CharacterCreate2), Character);
        }
        private async void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), Character);
        }

        private void SexBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string szSelected = e.AddedItems[0].ToString();
            switch (szSelected)
            {
                case "Male":        HelpBoxText.Text = Sex_Descrip_Male;        break;
                case "Female":      HelpBoxText.Text = Sex_Descrip_Female;      break;
                case "Both":        HelpBoxText.Text = Sex_Descrip_Both;        break;
                case "Other":       HelpBoxText.Text = Sex_Descrip_Other;       break;
            }
        }
        private void ClassBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string szSelected = e.AddedItems[0].ToString();
            switch (szSelected)
            {
                case "Thief":           HelpBoxText.Text = ThiefDescription;         break;             
                case "Slayer":          HelpBoxText.Text = SlayerDescription;        break;
                case "Techo":           HelpBoxText.Text = TechnoDescription;        break;
                case "Courtesan":       HelpBoxText.Text = CourtesanDescription;     break;
                case "Assassin":        HelpBoxText.Text = AssassinDescription;      break;
                case "Alchemist":       HelpBoxText.Text = AlchemistDescription;     break;
                case "Rune Weaver":     HelpBoxText.Text = RuneWeaverDescription;    break;
                case "Saint":           HelpBoxText.Text = SaintDescription;         break;
                case "Outlaw":          HelpBoxText.Text = OutlawDescription;        break;
                case "Warrior":         HelpBoxText.Text = WarriorDescription;       break;
                case "Cleric":          HelpBoxText.Text = ClericDescription;        break;
                case "Monk":            HelpBoxText.Text = MonkDescription;          break;
                case "Mage":            HelpBoxText.Text = MageDescription;          break;
                case "Illusionist":     HelpBoxText.Text = IllusionistDescription;   break;
                case "Bard":            HelpBoxText.Text = BardDescription;          break;
                case "Druid":           HelpBoxText.Text = DruidDescription;         break;
                case "Ranger":          HelpBoxText.Text = RangerDescription;        break;
                case "Barbarian":       HelpBoxText.Text = BarbarianDescription;     break;
                case "Medicine Man":    HelpBoxText.Text = MedicineManDescription;   break;
                case "Psychic":         HelpBoxText.Text = PsychicDescription;       break;
                case "Highway Man":     HelpBoxText.Text = HighwayManDescription;    break;
                case "Ninja":           HelpBoxText.Text = NinjaDescription;         break;
                case "Trader":          HelpBoxText.Text = TraderDescription;        break;
                case "Slaver":          HelpBoxText.Text = SlaverDescription;        break;
                case "Sage":            HelpBoxText.Text = SageDescription;          break;
                case "Witch Hunter":    HelpBoxText.Text = WitchHunterDescription;   break;
                case "Paladin":         HelpBoxText.Text = PaladinDescription;       break;
            }
        }

        private async void PopulateSexList()
        {
            SexBox.Items.Add(Sex_Male);
            SexBox.Items.Add(Sex_Female);
            SexBox.Items.Add(Sex_Both);
            SexBox.Items.Add(Sex_Other);
        }
        private async void PopulateClassList()
        {
            // fill character classes combo box
            ClassBox.Items.Add("Thief");
            ClassBox.Items.Add("Slayer");
            ClassBox.Items.Add("Techno");
            ClassBox.Items.Add("Courtesan");
            ClassBox.Items.Add("Assassin");
            ClassBox.Items.Add("Alchemist");
            ClassBox.Items.Add("Rune Weaver");
            ClassBox.Items.Add("Saint");
            ClassBox.Items.Add("Outlaw");
            ClassBox.Items.Add("Warrior");
            ClassBox.Items.Add("Cleric");
            ClassBox.Items.Add("Monk");
            ClassBox.Items.Add("Mage");
            ClassBox.Items.Add("Illusionist");
            ClassBox.Items.Add("Bard");
            ClassBox.Items.Add("Druid");
            ClassBox.Items.Add("Ranger");
            ClassBox.Items.Add("Barbarian");
            ClassBox.Items.Add("Medicine Man");
            ClassBox.Items.Add("Psychic");
            ClassBox.Items.Add("Highway Man");
            ClassBox.Items.Add("Ninja");
            ClassBox.Items.Add("Trader");
            ClassBox.Items.Add("Slaver");
            ClassBox.Items.Add("Sage");
            ClassBox.Items.Add("Witch Hunter");
            ClassBox.Items.Add("Paladin");

            //ClassBox.SelectedIndex = 0;
        }

    }
}
