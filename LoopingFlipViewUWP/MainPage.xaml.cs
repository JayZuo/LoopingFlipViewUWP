using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LoopingFlipViewUWP
{
    public class Item
    {
        public string Name { get; set; }
    }

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            var items = new Item[]
            {
            new Item { Name="1"},
            new Item { Name="2"},
            new Item { Name="3"},
            new Item { Name="4"},
            new Item { Name="5"},
            new Item { Name="6"},
            new Item { Name="7"},
            new Item { Name="8"},
            new Item { Name="9"},
            new Item { Name="10"},
            };

            var collection = new ObservableCollection<Item>();

            this.FlipView.ItemsSource = collection;

            foreach (var item in items)
            {
                collection.Add(item);
            }

            Synergist.FlipViewExtensions.SetIsLooping(this.FlipView, true);
        }
    }
}