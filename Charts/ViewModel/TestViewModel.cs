using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charts.ViewModel
{
    public class TestViewModel
    {
        public ObservableCollection<TestClass> Errors { get; private set; }

        public TestViewModel()
        {
            Errors = new ObservableCollection<TestClass>();
            Errors.Add(new TestClass() { Category = "Auto", Number = 70 });
            Errors.Add(new TestClass() { Category = "VrachtWagen", Number = 10 });
            Errors.Add(new TestClass() { Category = "Gehandicapten", Number = 12 });
            Errors.Add(new TestClass() { Category = "Elektrisch", Number = 83});
            Errors.Add(new TestClass() { Category = "Gereserveerd", Number = 29 });
        }

        private object selectedItem = null;
        public object SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                // selected item has changed
                selectedItem = value;                
            }
        }
    }
}
