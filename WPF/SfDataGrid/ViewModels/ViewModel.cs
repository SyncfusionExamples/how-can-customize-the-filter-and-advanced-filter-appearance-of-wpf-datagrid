using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Syncfusion.Windows.Shared;
using System.ComponentModel;
using Syncfusion.Data.Extensions;

namespace SfDataGridDemo
{
    public class ViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel()
        {
            _orderCollection = new ObservableCollection<ColumnModel>();
            OrderCollection = GetOrders();
        }

        private ObservableCollection<ColumnModel> _orderCollection;

        /// <summary>
        /// Gets or sets the order collection.
        /// </summary>
        /// <value>The order collection.</value>
        public ObservableCollection<ColumnModel> OrderCollection
        {
            get { return _orderCollection; }
            set
            {
                _orderCollection = value;
                RaisePropertyChanged("GDCSource");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propname));
        }

        /// <summary>
        /// Gets the orders.
        /// </summary>
        private ObservableCollection<ColumnModel> GetOrders()
        {
            var details = new ObservableCollection<ColumnModel>();
            Random r = new Random();
            for (int i = 0; i <= 25000; i++)
            {
                details.Add(new ColumnModel
                {
                    MyProperty0 = "" + i,
                    MyProperty1 = i + (i * (r.NextDouble())),
                    MyProperty2 = i + (0.098 * (r.NextDouble())),
                    MyProperty3 = i + (i * (r.NextDouble())),
                    MyProperty4 = i + (1.23 * (r.NextDouble())),
                    MyProperty5 = i + (0.632 * (r.NextDouble())),
                    MyProperty6 = i + (i * (r.NextDouble())),
                    MyProperty7 = i + (0.42 * (r.NextDouble())),
                    MyProperty8 = i + (i * (r.NextDouble())),
                    MyProperty9 = i + (0.91 * (r.NextDouble())),
                    MyProperty10 = i + (0.001 * (r.NextDouble())),
                    MyProperty11 = i + (i * (r.NextDouble())),
                    MyProperty12 = i + (0.098 * (r.NextDouble())),
                    MyProperty13 = i + (i * (r.NextDouble())),
                    MyProperty14 = i + (1.23 * (r.NextDouble())),
                    MyProperty15 = i + (0.632 * (r.NextDouble())),
                    MyProperty16 = i + (i * (r.NextDouble())),
                    MyProperty17 = i + (0.42 * (r.NextDouble())),
                    MyProperty18 = i + (i * (r.NextDouble())),
                    MyProperty19 = i + (0.91 * (r.NextDouble())),
                    MyProperty20 = i + (0.001 * (r.NextDouble())),
                    MyProperty21 = i + (i * (r.NextDouble())),
                    MyProperty22 = i + (0.098 * (r.NextDouble())),
                    MyProperty23 = i + (i * (r.NextDouble())),
                    MyProperty24 = i + (1.23 * (r.NextDouble())),
                    MyProperty25 = i + (0.632 * (r.NextDouble())),
                    MyProperty26 = i + (i * (r.NextDouble())),
                    MyProperty27 = i + (0.42 * (r.NextDouble())),
                    MyProperty28 = i + (i * (r.NextDouble())),
                    MyProperty29 = i + (0.91 * (r.NextDouble())),
                    MyProperty30 = i + (0.001 * (r.NextDouble())),

                });
            }
            return details;
        }
    }
}
