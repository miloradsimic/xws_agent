using System;

namespace XwsAgent.UILayer.ViewModel
{
    public class AccommodationVM: ViewModelBase
    {
        private string imageUri;
        private string address;
        private string type;
        private string category;

        public string ImageUri
        {
            get
            {
                return imageUri;
            }
            set
            {
                if(!String.Equals(imageUri, value))
                {
                    imageUri = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                if (!String.Equals(address, value))
                {
                    address = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (!String.Equals(type, value))
                {
                    type = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                if (!String.Equals(category, value))
                {
                    category = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
