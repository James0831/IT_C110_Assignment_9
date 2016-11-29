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

namespace Assignment9_Notepad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*James Carroll 11/29/16
         * This program creates a form that runs like a notepad
         */
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxPath.Text != null)
            {
                try
                {
                    WriteFile note = new WriteFile(textBoxPath.Text);
                    note.AddText(textBox1.Text);
                    note.CloseFile();
                    MessageBox.Show("Your file was saved.");//This is a message box that pops up to show it was saved
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } //end of if
        }//end of btnSave

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textBoxPath.Text != null)
                {
                    ReadFile doc = new ReadFile(textBoxPath.Text);
                    textBox1.Text = doc.GetFile();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            textBoxPath.Clear();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }//end of Class
}//end of namespace
