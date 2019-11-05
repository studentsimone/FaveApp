using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FaveApp
{

    public partial class MainPage : ContentPage
    {
        public IList<MakeUp> MakeUp { get; private set; }

        public  MainPage()
        {
            InitializeComponent();


           
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lipstick());

            MakeUp = new List<MakeUp>();
        }
    }
} 

