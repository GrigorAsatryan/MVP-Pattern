using System;
using UnityEngine;

public class PresenterService : MonoBehaviour{
    [SerializeField] private BasePresenter[] _baseUIViewPresenters;

    public void Show<TViewPresenter>() where TViewPresenter : BasePresenter
    {
        var presenter = Array.Find(_baseUIViewPresenters, presenter =>
         presenter.GetType().IsAssignableFrom(typeof(TViewPresenter)));
        presenter.Show();
    }
}
