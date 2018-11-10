using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Auth;
using UnityEngine.SceneManagement;
using Facebook.Unity;

public class FirebaseLogin : MonoBehaviour {
    public InputField Email, Password; 

    public void LoginButtonPressed()
    {
        FirebaseAuth.DefaultInstance.SignInWithEmailAndPasswordAsync(Email.text, Password.text).
            ContinueWith((task) =>
            {
                if (task.IsFaulted)
                {
                    Debug.LogError("CreateUserWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                    return;
                }
                else
                {
                    StartCoroutine(LoginSuccess());

                }
            });
    }
    public void CreateUser() {

        SceneManager.LoadSceneAsync("Register");
    }
    IEnumerator LoginSuccess()
    {
        float fadeTime = GameObject.Find("FireBase").GetComponent<Fade>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadSceneAsync("MainMenu");
    }

    private void FBinit() {
        if (!FB.IsInitialized)
        {
            FB.Init(() =>
            {
                if (FB.IsInitialized)
                    FB.ActivateApp();
                else
                    Debug.LogError("Couldn't initialize");
            },
        isGameShown =>
        {
            if (!isGameShown)
                Time.timeScale = 0;
            else
                Time.timeScale = 1;
        });
        }
        else
            FB.ActivateApp();
    }

    public void FacebookPressed() {
        FBinit();
        var permissions = new List<string>() { "public_profile", "email" };
        FB.LogInWithReadPermissions(permissions, AuthCallback);
    }
    private void AuthCallback(ILoginResult result)
    {

        Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        if (FB.IsLoggedIn)
        {
            var accessToken = Facebook.Unity.AccessToken.CurrentAccessToken;

            Debug.Log(accessToken.UserId);


            Firebase.Auth.Credential credential =
            Firebase.Auth.FacebookAuthProvider.GetCredential(accessToken.TokenString);
            auth.SignInWithCredentialAsync(credential).ContinueWith(task => {
                if (task.IsCanceled)
                {
                    Debug.LogError("SignInWithCredentialAsync was canceled.");
                    return;
                }
                if (task.IsFaulted)
                {
                    Debug.LogError("SignInWithCredentialAsync encountered an error: " + task.Exception);
                    return;
                }

                Firebase.Auth.FirebaseUser newUser = task.Result;
                Debug.LogFormat("User signed in successfully: {0} ({1})",
                    newUser.DisplayName, newUser.UserId);
                StartCoroutine(LoginSuccess());
            });

            foreach (string permissions in accessToken.Permissions)
            {
                Debug.Log(permissions);
            }
        }
        else
        {
            Debug.Log("User cancelled login");
        }
    }
   
}
