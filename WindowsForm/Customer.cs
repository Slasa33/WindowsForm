using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm
{
    public class Customer : INotifyPropertyChanged
    {
        public int id { get; set; }


        private string firstName;

        public string jmeno
        {
            get { return firstName; }
            set
            {
                firstName = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(jmeno)));
            }
        }

        private string lastName;

        public string prijmeni
        {
            get { return lastName; }
            set
            {
                lastName = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(prijmeni)));
            }
        }

        public int vek { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
