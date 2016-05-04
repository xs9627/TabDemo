using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabDemo.Model;

namespace TabDemo.ViewModel
{
    public class TabViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Title { get; set; }

        public ObservableCollection<TestData> Data { get; set; }

        public Type Type { get { return this.GetType(); } }
    }
}
