using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace PingMe.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new PingMe.Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry) {
            MvxAppCompatSetupHelper.FillTargetFactories(registry);
            base.FillTargetFactories(registry);
        }
    }
}
