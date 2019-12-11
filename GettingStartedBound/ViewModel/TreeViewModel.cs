using System.Collections.ObjectModel;

using Prism.Mvvm;

namespace S1000DIETP.Module.ContentViews.ViewModels
{
    public class TreeViewModel : BindableBase
    {
        private string _title = "Test";
        private string _revisionNumber = "test";


        private ObservableCollection<PMTreeNodeViewModel> _pmItems
            = new ObservableCollection<PMTreeNodeViewModel>();

        public TreeViewModel()
        {

            #region Generate source for testing
            for (int i = 0; i < 5; i++)
            {
                var nodei = new PMTreeNodeViewModel();
                nodei.DMC = $"manual Project boards for your issues and pull requests Did you know GitHub has project management tools? Manage and automate your workflow with a project board. {i}]";
                nodei.Title = $"title";
                for (int j = 0; j < 5; j++)
                {
                    var nodej = new PMTreeNodeViewModel();
                    nodej.DMC = $"manual Project boards for your issues and pull requests Did you know GitHub has project management tools? Manage and automate your workflow with a project board. {i}{j} ]";
                    nodej.Title = $"title";
                    for (int k = 0; k < 5; k++)
                    {
                        var nodek = new PMTreeNodeViewModel();
                        nodek.DMC = $"manual Project boards for your issues and pull requests Did you know GitHub has project management tools? Manage and automate your workflow with a project board. {i}{j}{k} ]";
                        nodek.Title = $"title";
                        for (int l = 0; l < 5; l++)
                        {
                            var nodel = new PMTreeNodeViewModel();
                            nodel.DMC = $"manual Project boards for your issues and pull requests Did you know GitHub has project management tools? Manage and automate your workflow with a project board. {i}{j}{k}{l} ]";
                            nodel.Title = $"title";
                            for (int m = 0; m < 5; m++)
                            {
                                var nodem = new PMTreeNodeViewModel();
                                nodem.DMC = $"manual Project boards for your issues and pull requests Did you know GitHub has project management tools? Manage and automate your workflow with a project board. {i}{j}{k}{l}{m} ]";
                                nodem.Title = $"title";
                                nodel.ChildItems.Add(nodem);
                            }
                            nodek.ChildItems.Add(nodel);
                        }
                        nodej.ChildItems.Add(nodek);
                    }
                    nodei.ChildItems.Add(nodej);
                }
                PMitems.Add(nodei);
            }
            #endregion
        }

        public ObservableCollection<PMTreeNodeViewModel> PMitems
        {
            get => _pmItems;
            set
            {
                SetProperty(ref _pmItems, value);
            }
        }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public string RevisionNumber
        {
            get => _revisionNumber;
            set => SetProperty(ref _revisionNumber, value);
        }

    }

}
