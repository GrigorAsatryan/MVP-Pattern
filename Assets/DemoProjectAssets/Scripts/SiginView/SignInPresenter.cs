using UnityEngine;

public class SignInPresenter : BaseUIPresenterWithModel<SignInView,SignInModel>
{
    private void Awake(){
        _view.OnSignInClicked += SignIn;
    }

    private void SignIn(string mail,string password){
        _model.SignIn(mail, password,() => {
            Hide();
            _presenterService.Show<LoginSucceedPresenter>();
        },message => {
            Debug.Log("Failed");
        });
    }
}
