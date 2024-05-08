using System;
using UnityEngine;

public class PresenterService : MonoBehaviour{
    [SerializeField] private UIViewBasePresenter[] _baseUIViewPresenters;

    public void Show<TViewPresenter>() where TViewPresenter : UIViewBasePresenter
    {
        var presenter = Array.Find(_baseUIViewPresenters, presenter =>
         presenter.GetType().IsAssignableFrom(typeof(TViewPresenter)));
        presenter.Show();
    }
}
