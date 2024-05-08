using UnityEngine;
using Zenject;

public abstract class BasePresenter<TView, TModel> : MonoBehaviour where TView : ViewBase where TModel : ModelBase
{
    [SerializeField] protected TView _view;
    [InjectLocal] protected readonly TModel _model;
}



