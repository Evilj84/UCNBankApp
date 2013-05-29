using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Model
{
    public class Account : INotifyPropertyChanged
    {
        public string _accountID;
        public double _amount;
        public double _interest;

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        public string AccountID
        {
            get
            {
                return _accountID;
            }
            set
            {
                _accountID = value;
                OnPropertyChanged("AccountID");
            }
        }

        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
                OnPropertyChanged("Amount");
            }
        }

        public double Interest
        {
            get
            {
                return _interest;
            }
            set
            {
                _interest = value;
                OnPropertyChanged("Interest");
            }
        }

        //public Account()
        //{

        //}

        //public Account(string id, double amount, double interest)
        //{
        //    AccountID = id;
        //    Amount = amount;
        //    Interest = interest;
        //}

        
    }
}
