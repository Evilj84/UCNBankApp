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

namespace BankApp.ViewModel
{
    public class BankAppViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Account> Accounts { get; set; }
 
        //constructor + singleton + abservablecollection

        public BankAppViewModel()
        {
            Accounts = new ObservableCollection<Account>();
            Initialize();
        }

        public void Initialize()
        {
            XElement xelement = XElement.Load("Accounts.xml");
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
