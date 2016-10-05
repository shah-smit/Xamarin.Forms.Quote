using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace QuoteForms
{
    public class QuoteViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public QuoteViewModel()
        {
            QuoteName = "First Name";
        }

        string quoteName;
        public string QuoteName
        {
            get { return quoteName;}
            set
            {
                quoteName = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("QuoteName"));
                }
            }
        }

        public Command ResetQuoteName
        {
            get 
            {
                return new Command (() =>
                {
                  QuoteName = "First Value";  
                }
                                    );
            }
        }
    }
}
