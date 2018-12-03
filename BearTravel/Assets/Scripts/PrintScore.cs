using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PrintScore : MonoBehaviour {
    float ShowTime;
    public Text Text_KeyWords;
    public Text Text_KeyWords_Result;
    public Text Text_Situation;
    public Text Text_Situation_Result;
    public Text Text_TimeSpent;
    public Text Text_TimeSpent_Result;
    public Text Text_Time_Tips;
    bool click=false;

    // Use this for initialization
    void Start()
    {
        ShowTime = TimeRecorder.TimeSpent;
        //print(ShowTime);
        float minutes = Mathf.Floor(ShowTime / 60);
        float seconds = Mathf.RoundToInt(ShowTime - minutes * 60);
        string niceTime = string.Format("{0:00}:{1:00}", minutes, seconds);
        Text_TimeSpent_Result.text = niceTime;
        if (ShowTime < 600)
        {
            Text_Time_Tips.text = "*過短\n良好的導覽應在10~15分鐘";
        }
        else if (ShowTime > 900) {
            Text_Time_Tips.text = "*過長\n良好的導覽應在10~15分鐘";
        }
        
        StartCoroutine(Fade1(1f, Text_KeyWords));

        
    }
	
	// Update is called once per frame
	void Update () {
        if (click) {
            if (GvrControllerInput.ClickButtonDown) {
                GameObject.Find("SceneChanger").GetComponent<ChangeScene>().changeToScene("ChooseMode");
            }
        }
	}

    public IEnumerator Fade1(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
        yield return StartCoroutine(Fade2(1f,Text_KeyWords_Result));
    }
    public IEnumerator Fade2(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
        yield return StartCoroutine(Fade3(1f, Text_Situation));
    }
    public IEnumerator Fade3(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
        yield return StartCoroutine(Fade4(1f, Text_Situation_Result));
    }
    public IEnumerator Fade4(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
        yield return StartCoroutine(Fade5(1f, Text_TimeSpent));
    }
    public IEnumerator Fade5(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
        yield return StartCoroutine(Fade6(1f, Text_TimeSpent_Result));
    }
    public IEnumerator Fade6(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
        yield return StartCoroutine(Fade7(1f, Text_Time_Tips));
    }
    public IEnumerator Fade7(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
        click = true;
    }
}
