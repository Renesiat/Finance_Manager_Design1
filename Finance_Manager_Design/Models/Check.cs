using Finance_Manager_Design.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _Check
{
    class Check : INotifyPropertyChanged
    {
        private bool is_visible_balance = false;
        private List<Parce> parces;
        public Check() { 
            Task.Factory.StartNew(() =>
            {

            }); }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }


         

        public void Refill(Parce parce, double sum)
        {
            foreach (Parce el in parces)
            {
                if (el == parce)
                {
                    el.Balance += sum;
                }
            }
        }

        public void AddParce(Parce parce)
        {
            parces.Append(parce);
        }

        public void RemoveParce(Parce parce)
        {
            parces.Remove(parce);
        }
    }
}

