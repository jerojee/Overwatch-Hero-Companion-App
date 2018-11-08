using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace OWHeroApp2
{
    public partial class MainPage : ContentPage
    {
        public class Hero
        {
            //public ImageSource Picture;
            public string Picture
            {
                get; set;
            }

            public string Name
            {
                get; set;
            }

            public string Role
            {
                get; set;
            }

            public string Url;
        }


        public MainPage()
        {
            InitializeComponent();
            PopulateHeroListView();
        }

        private void PopulateHeroListView()
        {
            var HeroList = new ObservableCollection<Hero>()
            {
                new Hero()
                {
                    Picture = "DVa.png",
                    Name = "D.Va" ,
                    Role = "Tank",
                    Url = "http://overwatch.wikia.com/wiki/D.Va",
                },

                new Hero()
                {
                    Picture = "Genji.png",
                    Name ="Genji" ,
                    Role = "Damage",
                    Url = "http://overwatch.wikia.com/wiki/Genji",
                },

                new Hero()
                {
                    Picture = "Lucio.png",
                    Name ="Lucio" ,
                    Role = "Healer",
                    Url = "http://overwatch.wikia.com/wiki/L%C3%BAcio",
                },

                new Hero()
                {
                    Picture = "Mei.png",
                    Name = "Mei" ,
                    Role = "Support",
                    Url = "http://overwatch.wikia.com/wiki/Mei",
                },

                new Hero()
                {
                    Picture = "Winston.png",
                    Name ="Winston" ,
                    Role = "Tank",
                    Url = "http://overwatch.wikia.com/wiki/Winston",
                }


            };

            ListOfHeroes.ItemsSource = HeroList;
        }
    
    private void ListOfHeroes_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var HeroList = (ListView)sender;
            var GetHero = (Hero)HeroList.SelectedItem;

            var Url = new Uri(GetHero.Url);

            Device.OpenUri(Url);
        }
    }
}
