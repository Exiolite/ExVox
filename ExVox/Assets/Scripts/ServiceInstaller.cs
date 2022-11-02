using Service;
using Zenject;

public class ServiceInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<ResourcesService>().FromNew().AsSingle().NonLazy();
    }
}
