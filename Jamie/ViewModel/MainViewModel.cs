using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Jamie.Model;
using System;

namespace Jamie.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        /// <summary>
        /// The <see cref="WelcomeTitle" /> property's name.
        /// </summary>
        public const string WelcomeTitlePropertyName = "WelcomeTitle";

        private string _welcomeTitle = string.Empty;

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }

            set
            {
                if (_welcomeTitle == value)
                {
                    return;
                }

                _welcomeTitle = value;
                RaisePropertyChanged(WelcomeTitlePropertyName);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;
            _dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }

                    TestMessage = item.Title;
                });

            _dataService.GetData2(
                (set, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }

                    AllRecipes = set;
                    SelectedRecipe = set.Count > 0 ? set[0] : null;

                    _ActualShoppingList = new ShoppingList();
                });


            _SaveXml = new RelayCommand(ExecSaveXml, CanSaveXml);

        }

        RecipeSet _AllRecipes;
        public RecipeSet AllRecipes
        {
            get { return _AllRecipes; }
            set
            {
                _AllRecipes = value;
                RaisePropertyChanged(() => AllRecipes);
            }
        }



        private ShoppingList _ActualShoppingList;

        public ShoppingList ActualShoppingList
        {
            get { return _ActualShoppingList; }
            set { _ActualShoppingList = value; }
        }




        string _TestMessage;
        public string TestMessage
        {
            get
            {
                return _TestMessage;
            }

            set
            {
                if (_TestMessage == value)
                    return;

                _TestMessage = value;
                RaisePropertyChanged(() => TestMessage);
            }
        }

        Recipe _SelectedRecipe;
        public Recipe SelectedRecipe
        {
            get
            {
                return _SelectedRecipe;
            }

            set
            {
                if (_SelectedRecipe == value)
                    return;

                _SelectedRecipe = value;
                RaisePropertyChanged(() => SelectedRecipe);
            }
        }







        private RelayCommand _SaveXml;
        public RelayCommand SaveXml
        {
            get
            {
                return _SaveXml;
            }
        }



        /// <summary>
        /// Checks whether the SaveXml command is executable
        /// </summary>
        private bool CanSaveXml()
        {
            return true;
        }



        /// <summary>
        /// Executes the SaveXml command 
        /// </summary>
        private void ExecSaveXml()
        {
            DataSourceSimpleXml<RecipeSet>.Serialize(_AllRecipes, @"\Recipe\Data\Recipes.txt");
        }




        #region Define Relay Command AddRecipe2ShoppingList
        private RelayCommand _addRecipe2ShoppingList;
        public RelayCommand AddRecipe2ShoppingList
        {
            get
            {
                return _addRecipe2ShoppingList ?? (_addRecipe2ShoppingList = new RelayCommand(ExecAddRecipe2ShoppingList, CanAddRecipe2ShoppingList));
            }
        }

        /// <summary>
        /// Checks whether the AddRecipe2ShoppingList command is executable
        /// </summary>
        private bool CanAddRecipe2ShoppingList()
        {
            return true;
        }

        /// <summary>
        /// Executes the AddRecipe2ShoppingList command 
        /// </summary>
        private void ExecAddRecipe2ShoppingList()
        {
            _ActualShoppingList.addRecipe(SelectedRecipe);
        }
        #endregion





        #region SwitchToShoppingListPage
        private RelayCommand _switchToShoppingListPage;
        public RelayCommand SwitchToShoppingListPage
        {
            get
            {
                return _switchToShoppingListPage ?? (_switchToShoppingListPage = new RelayCommand(ExecSwitchToShoppingListPage, CanSwitchToShoppingListPage));
            }
        }

        /// <summary>
        /// Checks whether the SwitchToShoppingListPage command is executable
        /// </summary>
        private bool CanSwitchToShoppingListPage()
        {
            return true;
        }

        /// <summary>
        /// Executes the SwitchToShoppingListPage command 
        /// </summary>
        private void ExecSwitchToShoppingListPage()
        {
            throw new NotImplementedException();
        }
        #endregion











    }


}