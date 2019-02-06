using Ch1.DialogBoxDemo;
using Microsoft.Win32;
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

namespace CH01.DialogBoxDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OnShowMessageButtonClicked(object sender, RoutedEventArgs e)
        {
            var messageDialog = new MessageDialog();
            var dialogResult = messageDialog.ShowDialog();

            if (dialogResult == true)
            {
                result.Items.Add("You clicked 'OK' button.");
            }
            else if (dialogResult == false)
            {
                result.Items.Add("You clicked 'Cancel' button.");
            }
        }

        private void OnOpenFileButtonClick(object sender, RoutedEventArgs e)
        {
            var openfileDialog = new OpenFileDialog
            {
                Filter = "Text documents (.txt) | *.txt | Log files (.log) | *.log" 
            };

            var dialogResult = openfileDialog.ShowDialog();
            if (dialogResult == true)
            {
                var fileName = openfileDialog.FileName;
            }
        }

        private void OnPrintButtonClick(object sender, RoutedEventArgs e)
        {
            var printDialog = new PrintDialog();
            var dialogResult = printDialog.ShowDialog();

            if (dialogResult == true)
            {
                // perform the print operation 
            }
        }

        private void OnSaveButtonClick(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Text documents (.txt) | *.txt | Log files (.log) | *.log" 
            };

            var dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == true)
            {
                var fileName = saveFileDialog.FileName;
            }
        }
    }
}
