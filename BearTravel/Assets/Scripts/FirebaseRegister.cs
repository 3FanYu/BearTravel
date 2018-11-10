using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Auth;
using UnityEngine.SceneManagement;

public class FirebaseRegister : MonoBehaviour {
    public InputField Name, Email, Password,RePassword;
    public void CreateUser()
    {
        if (Password.text == RePassword.text)
        {
            FirebaseAuth.DefaultInstance.CreateUserWithEmailAndPasswordAsync(Email.text, Password.text).
                ContinueWith((obj) =>
                {
                    SceneManager.LoadSceneAsync("Login");
                });
        }
        else {
            return;
        }
    }
    public void BackToLogin() {
        SceneManager.LoadSceneAsync("Login");
    }
}
