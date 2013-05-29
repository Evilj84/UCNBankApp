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
        private string _accountID;
        private double _amount;
        private double _interest;

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
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

        public Account()
        {

        }

        public Account(string id, double amount, double interest)
        {
            AccountID = id;
            Amount = amount;
            Interest = interest;
        }

        
    }
}
