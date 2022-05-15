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

namespace Cider_Game_Bar
{
    #pragma warning disable CS8305
    public sealed partial class Widget1 : Page
    {
        public Widget1()
        {
            this.InitializeComponent();

            try
            {
                MainView.Source = new Uri("http://localhost:6942");
            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
