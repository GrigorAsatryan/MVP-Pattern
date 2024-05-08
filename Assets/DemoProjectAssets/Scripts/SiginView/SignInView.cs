using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SignInView : ViewBase
{
    [SerializeField] private TMP_InputField _mailInput;
    [SerializeField] private TMP_InputField _passwordInput;
    [SerializeField] private Button _signInButton;

    public event Action<string, string> OnSignInClicked;

    private void Awake()
    {
        _signInButton
            .onClick
            .AddListener(() => OnSignInClicked?.Invoke(_mailInput.text, _passwordInput.text));
    }
}
