using Zenject;

public class BasePresenterInstaller<TModel> : MonoInstaller where TModel : ModelBase{
    public override void InstallBindings(){
        Container
            .Bind<TModel>()
            .AsSingle();
    }
}

public abstract class BaseUIViewPresenterInstaller<TModel> : BasePresenterInstaller<TModel> where TModel : ModelBase{
    public override void InstallBindings(){
        Container
         .Bind<TModel>()
         .AsCached()
         .WhenInjectedInto<BasePresenter>();
    }
}