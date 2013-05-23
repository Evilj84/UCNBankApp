using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BankApp.Model;
using System.Xml.Serialization;

namespace BankApp.ViewModel
{
    public class BankAppViewModel : INotifyPropertyChanged
    {
        public List<Account> acc = new List<Account>();
 
        public void Initialize()
        {
            XElement xelement = XElement.Load("Model\\Accounts.xml");
            IEnumerable<XElement> accounts = xelement.Elements();

            foreach (var account in accounts)
	        {
                var serializer = new XmlSerializer(typeof(Account));
                Account ac = (Account)serializer.Deserialize(account.CreateReader());
                acc.Add(ac);
	        }
        }

        public Account input()
        {
            return acc[0];
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
