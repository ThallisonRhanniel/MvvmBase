using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmBase.Core.ViewModels.Base;
using MvvmBase.Core.ViewModels.Home;
using MvvmBase.Fragments.Base;
using MvvmCross.Droid.Shared.Attributes;

namespace MvvmBase.Fragments.Home
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame)]
    [Register("mvvmbase.fragments.home.HomeFragment")]
    public class HomeFragment : BaseFragment<HomeViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

            ShowHamburgerMenu = true; // só alterar para Tru para mostrar nas telas que eu quiser
            return base.OnCreateView(inflater, container, savedInstanceState);
        }

        protected override int FragmentId => Resource.Layout.fragment_home;
    }
}