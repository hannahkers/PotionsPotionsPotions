using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static PotionsPotionsPotions.DisplayContent;
using System.IO;
using static PotionsPotionsPotions.LoadData;
using static PotionsPotionsPotions.Utility;

namespace PotionsPotionsPotions
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Game game = new Game();

        public MainWindow()
        {
            InitializeComponent();
        }

        #region "clear input"
        private void ClearInputBoxOfText()
        {
            Input.Text = "";
        }
        
        #endregion

        #region "button event handlers"
        private void ShowAllDataButton_Click(object sender, RoutedEventArgs e)
        {
            Print(game.GetAllData());
        }
        private void ShowTermsButton_Click(object sender, RoutedEventArgs e)
        {
            Print(game.GetAllTerms());
        }

        private void ShowDefinitionsButton_Click(object sender, RoutedEventArgs e)
        {
            Print(game.GetAllDefinitions());
        }

        private void ShowTermsByLengthButton_Click(object sender, RoutedEventArgs e)
        {
            Print(game.GetAllTermsOrderedByLength());
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            Print(game.Find(Input.Text));
            ClearInputBoxOfText();
        }
        #endregion

        private void VendorInventoryButton_Click(object sender, RoutedEventArgs e)
        {
            //Print(game.GetVendorData);
        }
    }
}
