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
    public sealed partial class Druga_forma : Page
    {
        MainPage mainpage;
        public Druga_forma()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            mainpage = e.Parameter as MainPage;
            Ime.Text = mainpage.ime;
            Prezime.Text = mainpage.prezime;
            Broj_vozacke.Text = mainpage.br_vozacke;
            if(mainpage.vozac == true)
            {
                Vozac.Text = "Zaduži vozača";
            }
            else if(mainpage.vozac == false)
            {
                Vozac.Text = "Vozač nije potreban";
            }
            if(mainpage.vip == true)
            {
                VIP.Text = "Korisnik je VIP član";
            }
            else if(mainpage.vip == false)
            {
                VIP.Text = "Korisnik nije VIP član";
            }

            Odrediste.Text = mainpage.odredista;

            Preuzimanje.Text = mainpage.preuzimanje;
        }

        private void Ime_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Prezime_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Broj_vozacke_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Vozac_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void VIP_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Odrediste_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Preuzimanje_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void zakljuci_narudzbu_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Treca_forma), this);
        }
    }
}
