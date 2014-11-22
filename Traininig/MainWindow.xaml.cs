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

using Traininig.Models;

namespace Traininig
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Car gol = new Car(4, 4, "gol");
            gol.Name = "juan";
            DataContext = gol;
      
        
 
        
            Computer pc = new Computer(2, "windows");
            pc.SO = "Windows";
            DataContext = pc;
            InitializeComponent();

        }
    }
}
