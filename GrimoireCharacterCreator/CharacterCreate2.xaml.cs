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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GrimoireCharacterCreator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CharacterCreate2 : Page
    {
        // moved to global instance
        //Random Rand = new Random();

        CCharacter Character;

        TextBlock[] AttribVals = new TextBlock[10];
        Button[] ReRollButtons = new Button[10];

        string[] AttributeStrings = 
        {
                "Strength",
                "Intelligence",
                "Wisdom",
                "Charisma",
                "Ego",
                "Agility",
                "Constitution",
                "Dexterity",
                "Stamina",
                "Swimming"
        };

        public CharacterCreate2()
        {
            this.InitializeComponent();
            CreateAttributesTable();
        }
        private async void Button_Continue_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
        private async void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            Character.CharStr = Convert.ToInt32(AttribVals[0].Text);
            Character.CharInt = Convert.ToInt32(AttribVals[1].Text);
            Character.CharWis = Convert.ToInt32(AttribVals[2].Text);
            Character.CharCha = Convert.ToInt32(AttribVals[3].Text);
            Character.CharEgo = Convert.ToInt32(AttribVals[4].Text);
            Character.CharAgi = Convert.ToInt32(AttribVals[5].Text);
            Character.CharCon = Convert.ToInt32(AttribVals[6].Text);
            Character.CharDex = Convert.ToInt32(AttribVals[7].Text);
            Character.CharSta = Convert.ToInt32(AttribVals[8].Text);
            Character.CharSwm = Convert.ToInt32(AttribVals[9].Text);

            Frame.Navigate(typeof(CharacterCreate1), Character);
        }
        private async void Button_ReRoll_Clock(Object sender, RoutedEventArgs e)
        {
            CalculateAllAttributes();
        }
        private async void InFocus(Object sender, RoutedEventArgs e)
        {
            //ReRoll.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
        }
        private async void OutFocus(Object sender, RoutedEventArgs e)
        {

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Character = (CCharacter)e.Parameter;

            if ( Character.CharName != "Default")
            {
                if (Character.CharStr != 0)
                {
                    AttribVals[0].Text = Character.CharStr.ToString();
                    AttribVals[1].Text = Character.CharInt.ToString();
                    AttribVals[2].Text = Character.CharWis.ToString();
                    AttribVals[3].Text = Character.CharCha.ToString();
                    AttribVals[4].Text = Character.CharEgo.ToString();
                    AttribVals[5].Text = Character.CharAgi.ToString();
                    AttribVals[6].Text = Character.CharCon.ToString();
                    AttribVals[7].Text = Character.CharDex.ToString();
                    AttribVals[8].Text = Character.CharSta.ToString();
                    AttribVals[9].Text = Character.CharSwm.ToString();
                }
            }
        }

        private int RollD20()
        {
            //return Rand.Next(1, 21);
            return CDiceRoller.RollD20();
        }
        private int RollD12()
        {
            //return Rand.Next(1, 13);
            return CDiceRoller.RollD12();
        }
        private int RollD10()
        {
            //return Rand.Next(1, 11);
            return CDiceRoller.RollD10();
        }
        private int RollD8()
        {
            //return Rand.Next(1, 9);
            return CDiceRoller.RollD8();
        }
        private int RollD6()
        {
            return CDiceRoller.RollD6();
            //return Rand.Next(1, 7);
        }
        private int RollD4()
        {
            //return Rand.Next(1, 5);
            return CDiceRoller.RollD4();
        }

        /// ////////////////////////////////////////////////////////////////////////////////////
        /// Constitution Stamina
        /// ////////////////////////////////////////////////////////////////////////////////////
        private int GetRaceStaminaModifier()
        {
            return 0;
        }
        private int Calculate_Stamina()
        {
            return (RollD6() + RollD6() + RollD6() + GetRaceStaminaModifier());
        }


        /// ////////////////////////////////////////////////////////////////////////////////////
        /// Constitution Calculations
        /// ////////////////////////////////////////////////////////////////////////////////////
        private int GetRaceSwimmingModifier()
        {
            return 0;
        }
        private int Calculate_Swimming()
        {
            return (RollD6() + RollD6() + RollD6() + GetRaceSwimmingModifier());
        }

        /// ////////////////////////////////////////////////////////////////////////////////////
        /// Constitution Calculations
        /// ////////////////////////////////////////////////////////////////////////////////////
        private int GetRaceConstitutionModifier()
        {
            return 0;
        }
        private int Calculate_Constitution()
        {
            return (RollD6() + RollD6() + RollD6() + GetRaceConstitutionModifier());
        }

        /// ////////////////////////////////////////////////////////////////////////////////////
        /// Wisdom Calculations
        /// ////////////////////////////////////////////////////////////////////////////////////
        private int GetRaceWisdomModifier()
        {
            return 0;
        }
        private int Calculate_Wisdom()
        {
            return (RollD6() + RollD6() + RollD6() + GetRaceWisdomModifier());
        }


        /// ////////////////////////////////////////////////////////////////////////////////////
        /// Intelligence Calculations
        /// ////////////////////////////////////////////////////////////////////////////////////
        private int GetRaceCharismaModifier()
        {
            return 0;
        }
        private int Calculate_Charisma()
        {
            return (RollD6() + RollD6() + RollD6() + GetRaceCharismaModifier());
        }

        /// ////////////////////////////////////////////////////////////////////////////////////
        /// Intelligence Calculations
        /// ////////////////////////////////////////////////////////////////////////////////////
        private int GetRaceEgoModifier()
        {
            return 0;
        }
        private int Calculate_Ego()
        {
            return (RollD6() + RollD6() + RollD6() + GetRaceEgoModifier());
        }

        /// ////////////////////////////////////////////////////////////////////////////////////
        /// Intelligence Calculations
        /// ////////////////////////////////////////////////////////////////////////////////////
        private int GetRaceAgilityModifier()
        {
            return 0;
        }
        private int Calculate_Agility()
        {
            return (RollD6() + RollD6() + RollD6() + GetRaceAgilityModifier());
        }

        /// ////////////////////////////////////////////////////////////////////////////////////
        /// Dexterity Calculations
        /// ////////////////////////////////////////////////////////////////////////////////////
        private int GetRaceDexterityModifier()
        {
            return 0;
        }
        private int Calculate_Dexterity()
        {
            return (RollD6() + RollD6() + RollD6() + GetRaceDexterityModifier());
        }

        /// ////////////////////////////////////////////////////////////////////////////////////
        /// Intelligence Calculations
        /// ////////////////////////////////////////////////////////////////////////////////////
        private int GetRaceIntelligenceModifier()
        {
            return 0;
        }
        private int Calculate_Intelligence()
        {
            return (RollD6() + RollD6() + RollD6() + GetRaceIntelligenceModifier());
        }
         
         
         
        /// ////////////////////////////////////////////////////////////////////////////////////
        /// Strength Calculations
        /// ////////////////////////////////////////////////////////////////////////////////////
        private int GetRaceStrengthModifier()
        {
            return 0;
        }

        private int Calculate_Strength()
        {
            return (RollD6() + RollD6() + RollD6() + GetRaceStrengthModifier());
        }


        private async void CalculateAllAttributes()
        {
            int Str = Calculate_Strength();
            AttribVals[0].Text = Str.ToString();

            int Int = Calculate_Intelligence();
            AttribVals[1].Text = Int.ToString();

            int Wis = Calculate_Wisdom();
            AttribVals[2].Text = Wis.ToString();

            int Cha = Calculate_Charisma();
            AttribVals[3].Text = Cha.ToString();

            int Ego = Calculate_Ego();
            AttribVals[4].Text = Ego.ToString();

            int Agi = Calculate_Agility();
            AttribVals[5].Text = Agi.ToString();

            int Con = Calculate_Constitution();
            AttribVals[6].Text = Con.ToString();

            int Dex = Calculate_Dexterity();
            AttribVals[7].Text = Dex.ToString();

            int Sta = Calculate_Stamina();
            AttribVals[8].Text = Sta.ToString();

            int Swi = Calculate_Swimming();
            AttribVals[9].Text = Swi.ToString();
        }

        private async void Calculate_IndividualAttribute(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "Strength" :
                    int Str = Calculate_Strength();
                    AttribVals[0].Text = Str.ToString();
                    break;
                case "Intelligence" :
                    int Int = Calculate_Intelligence();
                    AttribVals[1].Text = Int.ToString();
                    break;
                case "Wisdom" :
                    int Wis = Calculate_Wisdom();
                    AttribVals[2].Text = Wis.ToString();
                    break;
                case "Ego" :
                    int Ego = Calculate_Ego();
                    AttribVals[4].Text = Ego.ToString();
                    break;
                case "Charisma" :
                    int Cha = Calculate_Charisma();
                    AttribVals[3].Text = Cha.ToString();
                    break;
                case "Dexterity" :
                    int Dex = Calculate_Dexterity();
                    AttribVals[7].Text = Dex.ToString();
                    break;
                case "Agility" :
                    int Agi = Calculate_Agility();
                    AttribVals[5].Text = Agi.ToString();
                    break;
                case "Stamina" :
                    int Sta = Calculate_Stamina();
                    AttribVals[8].Text = Sta.ToString();
                    break;
                case "Constitution" :
                    int Con = Calculate_Constitution();
                    AttribVals[6].Text = Con.ToString();
                    break;
                case "Swimming" :
                    int Swi = Calculate_Swimming();
                    AttribVals[9].Text = Swi.ToString();
                    break;
                default:
                    CalculateAllAttributes();
                    break;
            }
        }

        private async void CreateAttributesTable()
        {
            int x = 0;
            //TextBlock[] Attributes = new TextBlock[10];   
            foreach(string s in AttributeStrings)
            {

                RowDefinition RowDef = new RowDefinition();
                RowDef.Height = new GridLength(48);
                AttributesGrid.RowDefinitions.Add(RowDef);

                // set icon
                Image Pic = new Image();
                BitmapImage tempBMP = new BitmapImage();
                tempBMP.UriSource = new Uri("ms-appx:///Assets/Icons/Icon4_64.png");
                Pic.Source = tempBMP;
                Grid.SetColumn(Pic, 0);
                Grid.SetRow(Pic, x);
                Pic.HorizontalAlignment = HorizontalAlignment.Left;
                AttributesGrid.Children.Add(Pic);

                Button RRBut = new Button
                {
                    BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red),
                    BorderThickness = new Thickness(2),
                    Width = 48,
                    Height = 48,
                    Name = s,
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Content = new Image
                    {
                        Source = new BitmapImage(new Uri("ms-appx:///Assets/Icons/Dice-Black-64.png")),
                        VerticalAlignment = VerticalAlignment.Center,
                        HorizontalAlignment = HorizontalAlignment.Left,
                        Height=32,
                        Width=32
                    }
                };
                RRBut.Click += Calculate_IndividualAttribute;
                Grid.SetColumn(RRBut, 1);
                Grid.SetRow(RRBut, x);
                AttributesGrid.Children.Add(RRBut);
                ReRollButtons[x] = RRBut;

                // set text
                TextBlock AttrText = new TextBlock();
                AttrText.Text = s;
                AttrText.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
                Grid.SetColumn(AttrText, 2);
                Grid.SetRow(AttrText, x);
                AttrText.VerticalAlignment = VerticalAlignment.Center;
                AttributesGrid.Children.Add(AttrText);

                // set text boxes
                TextBlock AttrVal = new TextBlock();
                AttrVal.Text = "0";
                AttrVal.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
                AttrVal.TextAlignment = TextAlignment.Right;
                Grid.SetColumn(AttrVal, 3);
                Grid.SetRow(AttrVal, x);
                AttrVal.VerticalAlignment = VerticalAlignment.Center;
                AttributesGrid.Children.Add(AttrVal);
                AttribVals[x] = AttrVal;
                x++;
            }

            CalculateAllAttributes();
        }
    }
}
