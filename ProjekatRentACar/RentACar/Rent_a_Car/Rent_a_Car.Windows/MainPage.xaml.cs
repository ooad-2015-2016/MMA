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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Rent_a_car
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public string ime { get; set; }
        public string prezime {get; set; }
        public string br_vozacke {get; set; }
        public bool vozac { get; set; }
        public bool vip { get; set; }
        public string odredista { get; set; }
        public string preuzimanje { get; set; }
        
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Prezime_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void Broj_vozacke_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void Ime_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ime = Ime.Text;
            prezime = Prezime.Text;
            br_vozacke = Broj_vozacke.Text;
            if(da_vozac.IsChecked == true && ne_vozac.IsChecked == false)
            {
                vozac = true;
            }
            else if (da_vozac.IsChecked == false && ne_vozac.IsChecked == true)
            {
                vozac = false;
            }

            if(da_vip.IsChecked == true && ne_vip.IsChecked == false)
            {
                vip = true;
            }
            else if(da_vip.IsChecked == false && ne_vip.IsChecked == true)
            {
                vip = false;
            }

            odredista = Lista_povratka.SelectedValue.ToString();
            preuzimanje = mjesto_preuzimanja.SelectedValue.ToString();

            Frame.Navigate(typeof(Druga_forma), this);
        }

        private void da_vozac_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ne_vozac_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void Lista_povratka_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void mjesto_preuzimanja_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
