using System.Collections.ObjectModel;

using Prism.Mvvm;

namespace S1000DIETP.Module.ContentViews.ViewModels
{
    public class PMTreeNodeViewModel : BindableBase
    {
        private ObservableCollection<PMTreeNodeViewModel> _childItems
         = new ObservableCollection<PMTreeNodeViewModel>();

        private string _dmc;
        private string _title;

        public string DMC
        {
            get => _dmc;
            set
            {
                _dmc = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<PMTreeNodeViewModel> ChildItems
        {
            get => _childItems;
            set
            {
                _childItems = value;
                OnPropertyChanged();
            }
        }
    }

}
