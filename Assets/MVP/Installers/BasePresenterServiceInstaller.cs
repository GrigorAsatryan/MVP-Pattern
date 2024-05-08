using UnityEngine;
using Zenject;

public class BasePresenterServiceInstaller : MonoInstaller
{
    [SerializeField] private PresenterService _preseneterService;

    public override void InstallBindings()
    {
        Container.
            Bind<PresenterService>()
            .FromInstance(_preseneterService)
            .AsSingle();
    }
}