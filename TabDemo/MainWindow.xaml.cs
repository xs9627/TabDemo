using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using TabDemo.ViewModel;

namespace TabDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            this.ExistingTabs = new ObservableCollection<TabViewModel> {
                new TabViewModel { Title = "Title 1", Data = new ObservableCollection<Model.TestData> { new Model.TestData { FieldA = "A1", FieldB="B1" } } },
                new TabViewModel { Title = "Title 2", Data = new ObservableCollection<Model.TestData> { new Model.TestData { FieldA = "A2", FieldB="B2" } } }
            };
        }

        public ObservableCollection<TabViewModel> ExistingTabs { get; set; }
    }
}
