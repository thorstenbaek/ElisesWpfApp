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
using System.Windows.Shapes;
using System.IO;

namespace ElisesWpfApp.Views
{
    /// <summary>
    /// Interaction logic for NewPatient.xaml
    /// </summary>
    public partial class NewPatient : Window
    {
        public NewPatient()
        {
            InitializeComponent();



        }

        private void SavePatientBtn_Click(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\Users\eec\Documents\oveWPF\patients2.txt";
            // string[] lines = File.ReadAllLines(filePath);
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();


            lines.Add("Vibeke, Easter, 53");
            File.WriteAllLines(filePath, lines);

        }
    }
}
