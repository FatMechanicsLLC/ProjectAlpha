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

        private async void CreateAttributesTable()
        {
            int x = 0;
            TextBlock[] Attributes = new TextBlock[10];   
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
                x++;
            }
        }
    }
}
