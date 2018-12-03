using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PrintScore : MonoBehaviour {
    float ShowTime;
    public Text Text_KeyWords;
    public Text Text_Situation;
    public Text Text_TimeSpent;

    // Use this for initialization
    void Start () {
        ShowTime = TimeRecorder.TimeSpent;
        //print(ShowTime);
        StartCoroutine(Fade1(2f,Text_KeyWords));
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator Fade1(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
        yield return StartCoroutine(Fade2(1f,Text_Situation));
    }
    public IEnumerator Fade2(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
        yield return StartCoroutine(Fade3(1f, Text_TimeSpent));
    }
    public IEnumerator Fade3(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
    }
}
