using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FaveApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page : ContentPage
    {
        public Page()
        {
            InitializeComponent();

            MakeUp = new List<MakeUp>();
            MakeUp.Add(new MakeUp
            {
                Name = "Raining Men Shade",
                Price = "ZAR 200",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0635/0797/products/s1926807-main-zoom_grande_2x.jpg?v=1516416796"
            });

            BindingContext = this;

        }
    }
}