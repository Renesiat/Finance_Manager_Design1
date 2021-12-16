using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Finance_Manager_Design.Models
{
    class Parce : INotifyPropertyChanged
    {
        private string _name;
        private double _balance = 0;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public Parce(string name) : this(name, 0) { }
        public Parce(string name, double balance)
        {
            _name = name;
            _balance = balance;
           
        }

        public Parce()
        {
            Task.Factory.StartNew(() =>
            {
                Name.ToString();
                Balance.ToString();
            });
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {

                _balance = value;
                OnPropertyChanged();
            }
        }
   
    }

}
