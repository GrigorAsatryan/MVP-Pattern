using System;

public class SignInModel : ModelBase
{
    public class LoginResponse
    {
        public string message;
        public bool success;
    }
    public void SignIn(string mail, string password,Action onCompleted,Action<string> onFailed){
        //Do Login call to server
        //get response
        LoginResponse response = new()
        {
            success = true
        };
        //if response is false

 
        if (!response.success) {
            onFailed?.Invoke(response.message);
            return;
        }

        //succeed
        onCompleted?.Invoke();
    }
}
