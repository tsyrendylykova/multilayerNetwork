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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MultilayerNetworkVisialization
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isHide = false;

        public MainWindow()
        {
            InitializeComponent();

            Network network = new Network()
            {
                FirstLayer = "Barabashi",
                SecondLayer = "Albert"
            };

            this.DataContext = network;
        }

        private void butonMenu_Click(object sender, RoutedEventArgs e)
        {
            if (isHide)
            {
                butonMenu.Content = ">";
                isHide = !isHide;
                StoryboardLibrary.MenuAnim(gridMenu, StoryboardLibrary.MenuAnimOption.Show, gridMenu.RenderSize.Width - 40, StoryboardLibrary.MoveDirection.RightLeft).Begin();
            }
            else
            {
                butonMenu.Content = "<";
                isHide = !isHide;
                StoryboardLibrary.MenuAnim(gridMenu, StoryboardLibrary.MenuAnimOption.Hide, gridMenu.RenderSize.Width - 40, StoryboardLibrary.MoveDirection.RightLeft).Begin();
            }
        }

        private void butonExit_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void butonHideUnhide_Click(object sender, RoutedEventArgs e)
        {
            if (isHide)
            {
                butonHideUnhide.Content = "Hide";
                isHide = !isHide;
                StoryboardLibrary.MenuAnim(gridMenu, StoryboardLibrary.MenuAnimOption.Show, gridMenu.RenderSize.Height - 28, StoryboardLibrary.MoveDirection.UpDown).Begin();
            }
            else
            {
                butonHideUnhide.Content = "UnHide";
                isHide = !isHide;
                StoryboardLibrary.MenuAnim(gridMenu, StoryboardLibrary.MenuAnimOption.Hide, gridMenu.RenderSize.Height - 28, StoryboardLibrary.MoveDirection.UpDown).Begin();
            }


        }

        //        private void button_Click(object sender, RoutedEventArgs e)
        //        {
        //            if (!string.IsNullOrWhiteSpace(textBox_layer1.Text))
        //            {
        //                TextBlock.Text = string.Format("Network {0} is created!", textBox_layer1.Text);
        //            }
        //        }
    }
}
