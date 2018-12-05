using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class CountDown : MonoBehaviour {
    public float time;
    public float timeLeft;
    int number;
    int temp;
    public bool activate;
    public Flowchart talkFlowchart;
    System.Random r = new System.Random();
    string[] Questions = { "Q1", "Q2", "Q3", "Q4", "Q5", "Q6", "Q7", "Q8", "Q9", "Q10", "Q11", "Q12" };
    // Use this for initialization
    void Start () {
        time = 20f;
        timeLeft = time;
        activate = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (activate)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                number = Random.Range(0, 2);
                if (number == 1)
                {
                    GameObject.Find("Systems").GetComponent<AttentionC>().activation = true;
                    activate = false;
                }
                else if (number == 0)
                {
                    temp = Random.Range(0, 12);
                    Block targetBlock = talkFlowchart.FindBlock(Questions[(temp)]);
                    talkFlowchart.ExecuteBlock(targetBlock);
                    activate = false;
                }
            }
        }
    }
    public void stopactivation()
    {
        activate = false;
    }
}
