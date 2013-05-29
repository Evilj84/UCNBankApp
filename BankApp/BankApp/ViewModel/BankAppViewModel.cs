using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BankApp.Model;
using System.Xml.Serialization;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;


namespace BankApp.ViewModel
{
    public class BankAppViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Account> Accounts { get; set; }

        private Account _selectedAccount;
        public Account SelectedAccount
        {
            get
            {
                return _selectedAccount;
            }
            set
            {
                if (_selectedAccount != value)
	            {
                    _selectedAccount = value;
                    RaisePropertyChanged("SelectedAccount");
	            }
                
            }
        }

        private double _selectedBalance;
        public double SelectedBalance
        {
            get
            {
                return _selectedBalance;
            }
            set
            {
                if (_selectedBalance != value)
                {
                    _selectedBalance = value;
                    RaisePropertyChanged("SelectedBalance");
                }
            }
        }

        private ICommand _clickWithdrawCommand;
        public ICommand ClickWithdrawCommand
        {
            get
            {
                return _clickWithdrawCommand;
            }
            set
            {
                _clickWithdrawCommand = value;
            }
        }

        private ICommand _clickDepositCommand;
        public ICommand ClickDepositCommand
        {
            get
            {
                return _clickDepositCommand;
            }
            set
            {
                _clickDepositCommand = value;
            }
        }

        private ICommand _clickInterestCommand;
        public ICommand ClickInterestCommand
        {
            get
            {
                return _clickInterestCommand;
            }
            set
            {
                _clickInterestCommand = value;
            }
        }

        public BankAppViewModel()
        {
            Accounts = new ObservableCollection<Account>();
            Initialize();
            ClickWithdrawCommand = new RelayCommand(new Action<object>(WithdrawAmount));
            ClickDepositCommand = new RelayCommand(new Action<object>(DepositAmount));
            ClickInterestCommand = new RelayCommand(new Action<object>(AddInterest));
        }

        public void WithdrawAmount(object amount)
        {
            SelectedAccount._amount = SelectedAccount._amount - Convert.ToDouble(amount);
        }

        public void DepositAmount(object amount)
        {
            SelectedAccount._amount = SelectedAccount._amount + Convert.ToDouble(amount);
        }

        public void AddInterest(object interest)
        {
            SelectedAccount._amount = SelectedAccount._amount + (SelectedAccount._amount * SelectedAccount._interest);
        }

        public void Initialize()
        {
            XElement xelement = XElement.Load(@".\Accounts.xml");
            IEnumerable<XElement> accounts = xelement.Elements();

            foreach (var account in accounts)
            {
                var serializer = new XmlSerializer(typeof(Account));
                Account ac = (Account)serializer.Deserialize(account.CreateReader());
                Accounts.Add(ac);
            }
        }

        #region INPC

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}

class RelayCommand : ICommand
{
    private Action<object> _action;
    
    public RelayCommand(Action<object> action)
    {
        _action = action;
    }
    
    #region ICommand Members

    public bool CanExecute(object parameter)
    {
        return true;
    }

    public event EventHandler CanExecuteChanged;
    
    public void Execute(object parameter)
    {
        if (parameter != null)
        {
            _action(parameter);
        }
        else
        {
            _action("Hello World");
        }
    }

    #endregion

}


