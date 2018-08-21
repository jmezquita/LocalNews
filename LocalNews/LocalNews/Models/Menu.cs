using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalNews.Models
{
    [XamlCompilation(XamlCompilationOptions.Compile) ]
    public class Menu
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String ViewA { get; set; }
        public ImageSource Icon { get; set; }
        public String Descripcion { get; set; }

    }
}
