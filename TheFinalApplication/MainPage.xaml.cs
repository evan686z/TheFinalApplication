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
using TheFinalApplication;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TheFinalApplication
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Unit> Units;

        public MainPage()
        {
            this.InitializeComponent();
            this.IntializeDataContext();
        }
        private async void IntializeDataContext()
        {
            IntializeData.WriteTestDataToFileXml();

            Units = await UnitDataServiceXml.ReadObjectFromXmlFileAsync<List<Unit>>("Units.xml");
            UnitDataManagerXml unitDataManager = new UnitDataManagerXml(Units);
        }
        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var unit = (Unit)e.ClickedItem;
            UnitName.Text = unit.UnitName;

            BitmapImage bitmapImage = new BitmapImage(new Uri(this.BaseUri, $"/{unit.UnitImage}"));
            UnitImage.Source = bitmapImage;

        }

        //private void FilterButton_Click(object sender, RoutedEventArgs e)
        //{
        //    List<Unit> filteredListUnits = new List<Unit>();

        //    foreach (Unit unit in Units)
        //    {
        //        if (unit.UnitName == Filter_TextBox.Text)
        //        {
        //            filteredListUnits.Add(unit);
        //        }
        //    }
        //    UnitListView_ListView.ItemsSource = filteredListUnits;
        //}

        private void ResetFilter_Click(object sender, RoutedEventArgs e)
        {
            UnitListView_ListView.ItemsSource = Units;
        }

        /// <summary>
        /// Replaced the button with the keyDown event, so you
        /// can press enter to have the same effect as the button did
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Filter_TextBox_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            List<Unit> filteredListUnits = new List<Unit>();

            foreach (Unit unit in Units)
            {
                if (unit.UnitName == Filter_TextBox.Text)
                {
                    filteredListUnits.Add(unit);
                }
            }
            UnitListView_ListView.ItemsSource = filteredListUnits;
        }
    }
}
