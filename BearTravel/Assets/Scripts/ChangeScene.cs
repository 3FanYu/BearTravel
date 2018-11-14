using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
  

    public void changeToScene(string changeTheScene)
    {
        StartCoroutine(FadeAndChangeScene(changeTheScene));

    }
    IEnumerator FadeAndChangeScene(string Scene)
    {
        float fadeTime = GameObject.Find("SceneChanger").GetComponent<Fade>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadSceneAsync(Scene);
    }

}
