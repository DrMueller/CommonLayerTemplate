using Microsoft.Practices.Unity;

namespace $safeprojectname$.Interfaces
{
    public interface IUnityInitializer
    {
        void InitializeContainer(IUnityContainer unityContainer);
    }
}
