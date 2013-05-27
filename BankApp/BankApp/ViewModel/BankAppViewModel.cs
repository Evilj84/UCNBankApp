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


namespace BankApp.ViewModel
{
    public class BankAppViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Account> Accounts { get; set; }

        private int _depositValue;

        public int DepositValue
        {
            get
            {
                return _depositValue;
            }
            set
            {
                _depositValue = value;
                RaisePropertyChanged("DepositValue");
            }
        }

        private int _withdrawValue;

        public int WithdrawValue
        {
            get
            {
                return _withdrawValue;
            }
            set
            {
                _withdrawValue = value;
                RaisePropertyChanged("WithdrawValue");
            }
        }
 
        //constructor + singleton + abservablecollection

        public BankAppViewModel()
        {
            Accounts = new ObservableCollection<Account>();
            Initialize();
        }

        public void Initialize()
        {            
            XElement xelement = XElement.Load(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Accounts.xml"));
            IEnumerable<XElement> accounts = xelement.Elements();

            foreach (var account in accounts)
	        {
                var serializer = new XmlSerializer(typeof(Account));
                Account ac = (Account)serializer.Deserialize(account.CreateReader());
                Accounts.Add(ac);
	        }
        }

        public void AddInterest()
        {

        }

         
        public void Deposit()
        {

        }

        public void Withdraw()
        {

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

//public class ActionCommand : ICommand
//{
//    private readonly Action<string> _codeToExecute;

//    public bool CanExecute(object parameter)
//    {
//        return
//    }

//    public event EventHandler CanExecuteChanged;

//    public void Execute(object parameter)
//    {
//        throw new NotImplementedException();
//    }
//}


