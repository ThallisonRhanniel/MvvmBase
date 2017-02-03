using MvvmBase.Core.ViewModels.Base;
using MvvmBase.Core.ViewModels.Home;
using MvvmCross.Core.ViewModels;

namespace MvvmBase.Core.ViewModels.Menu
{
    public class MenuViewModel : BaseViewModel
    {
        #region Cross Platform Commands & Handlers

        public IMvxCommand ShowHomeCommand
        {
            get { return new MvxCommand(ShowHomeExecuted); }
        }

        private void ShowHomeExecuted()
        {
            ShowViewModel<HomeViewModel>();
        }

        #endregion

        
    }
}
