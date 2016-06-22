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

namespace WpfApplication1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void name_changed(object sender, TextChangedEventArgs e)
        {
            name_output.Content = "Name:\t\t " + name_input.Text;
        }

        private void mtnr_changed(object sender, TextChangedEventArgs e)
        {
            mtnr_output.Content = "Matrikelnummer:\t " + mtnr_input.Text;
        }

        private void fach_changed(object sender, EventArgs e)
        {
            fach_output.Content = "Fach:\t\t " + fach_input.Text;
        }

        private void engagement_changed(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            engagement_output.Content = "Engagement:\t " + (int)engagement_input.Value;
        }

        private void Note_Checked(object sender, RoutedEventArgs e)
        {
            // ... Get RadioButton reference.
            var button = sender as RadioButton;

            // ... Display button content as title.
            note_output.Content = "Note:\t\t " + button.Content.ToString();

        }

        private void Belegnote_Checked(object sender, RoutedEventArgs e)
        {
            // ... Get RadioButton reference.
            var button = sender as RadioButton;

            // ... Display button content as title.
            belegnote_output.Content = "Belegnote:\t " + button.Content.ToString();

        }
    }
}
