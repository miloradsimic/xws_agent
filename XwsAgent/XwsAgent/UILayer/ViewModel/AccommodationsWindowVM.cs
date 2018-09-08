using System.Collections.ObjectModel;

namespace XwsAgent.UILayer.ViewModel
{
    public class AccommodationsWindowVM: ViewModelBase
    {
        public ObservableCollection<AccommodationVM> Accommodations
        {
            get;
            set;
        }
    }
}
