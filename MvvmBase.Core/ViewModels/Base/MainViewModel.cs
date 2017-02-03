using MvvmBase.Core.ViewModels.Home;
using MvvmBase.Core.ViewModels.Menu;

namespace MvvmBase.Core.ViewModels.Base
{
    public class MainViewModel : BaseViewModel
    {
        public void ShowMenu() // Chama duas ViewModel porque inicia 2 fragmentos o menu hamburguer e a pagina inicial;
        {
            ShowViewModel<HomeViewModel>();
            ShowViewModel<MenuViewModel>();

        }
        
        public void Init(object hint)
        {
            // Can perform Vm data retrival here based on any
            // data passed in the hint object

            // ShowViewModel<SomeViewModel>(new { derp: "herp", durr: "derrrrrr" });
            // public class SomeViewModel : MvxViewModel
            // {
            //     public void Init(string derp, string durr)
            //     {
            //     }
            // }
        }
        
    }
}
