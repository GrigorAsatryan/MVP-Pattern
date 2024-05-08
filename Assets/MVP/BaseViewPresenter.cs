using UnityEngine;
using UnityEngine.UI;
using Zenject;

public abstract class BasePresenter : MonoBehaviour{
    [SerializeField] protected Canvas _canvas;
    [SerializeField] protected GraphicRaycaster _graphicRaycaster;

    public void Show()
    {
        _canvas.enabled = true;
        _graphicRaycaster.enabled = true;
    }

    public void Hide()
    {
        _canvas.enabled = false;
        _graphicRaycaster.enabled = false;
    }
}

public abstract class BaseUIPresenterWithModel<TView, TModel> : BasePresenter where TView : ViewBase where TModel : ModelBase
{
    [SerializeField] protected TView _view;
    [InjectLocal] protected readonly TModel _model;
    [Inject] protected readonly PresenterService _presenterService;
}

public abstract class BaseUIPresenterTView<TView> : BasePresenter where TView : ViewBase
{
    [SerializeField] protected TView _view;
    [Inject] protected readonly PresenterService _presenterService;
}



