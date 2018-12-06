using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSwitcher : MonoBehaviour
{
    int mode;
    // Use this for initialization
    void Start()
    {
        
        if (ModeNumber.Mode == 0)
        {
            GameObject.Find("PracticeMode").SetActive(true);
            GameObject.Find("ChallengeMode").SetActive(false);
        }
        else if (ModeNumber.Mode == 1) {
            GameObject.Find("PracticeMode").SetActive(false);
            GameObject.Find("ChallengeMode").SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
   
}
