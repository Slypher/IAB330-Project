using MvvmCross.Platform.IoC;
using PingMe.Core.Classes;

namespace PingMe.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            DataModel.Init();
            RegisterAppStart<ViewModels.HomeViewModel>();
        }
    }
}
