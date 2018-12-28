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
        Random Rand = new Random();

        TextBlock[] AttribVals = new TextBlock[10];

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
            Frame.Navigate(typeof(CharacterCreate1));
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


        private int RollD20()
        {
            return Rand.Next(1, 20);
        }
        private int RollD12()
        {
            return Rand.Next(1, 12);
        }
        private int RollD10()
        {
            return Rand.Next(1, 10);
        }
        private int RollD8()
        {
            return Rand.Next(1, 8);
        }
        private int RollD6()
        {
            return Rand.Next(1, 6);
        }
        private int RollD4()
        {
            return Rand.Next(1, 4);
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

        private async void CreateAttributesTable()
        {
            int x = 0;
            //TextBlock[] Attributes = new TextBlock[10];   
            foreach(string s in AttributeStrings)
            {
                //Attributes[x] = new TextBlock();
                //Attributes[x].Text = s;
                //Attributes[x].Foreground = new SolidColorBrush(Windows.UI.Colors.White);
                //Grid.SetColumn(Attributes[x], 0);
                //Grid.SetRow(Attributes[x], x); TextBlock AttrText = new TextBlock();
                RowDefinition RowDef = new RowDefinition();
                RowDef.Height = new GridLength(32);
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
                
                // set text
                TextBlock AttrText = new TextBlock();
                AttrText.Text = s;
                AttrText.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
                Grid.SetColumn(AttrText, 1);
                Grid.SetRow(AttrText, x);
                AttrText.VerticalAlignment = VerticalAlignment.Center;
                //AttributesGrid.Children.Add(Attributes[x++]);
                AttributesGrid.Children.Add(AttrText);

                // set text boxes
                TextBlock AttrVal = new TextBlock();
                AttrVal.Text = "0";
                AttrVal.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
                AttrVal.TextAlignment = TextAlignment.Right;
                Grid.SetColumn(AttrVal, 2);
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
