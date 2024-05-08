using UnityEngine;
using UnityEngine.UI;
using Zenject;

public abstract class UIViewBasePresenter : MonoBehaviour{
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

public abstract class BaseUIViewPresenterWithModel<TView, TModel> : UIViewBasePresenter where TView : ViewBase where TModel : ModelBase
{
    [SerializeField] protected TView _view;
    [InjectLocal] protected readonly TModel _model;
    [Inject] protected readonly PresenterService _presenterService;
}

public abstract class BaseUIViewPresenter<TView> : UIViewBasePresenter where TView : ViewBase
{
    [SerializeField] protected TView _view;
    [Inject] protected readonly PresenterService _presenterService;
}



