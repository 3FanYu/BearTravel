using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {
    public static AudioClip Correct, Applaud,Exclamatory;
    static AudioSource audioSrc;
	// Use this for initialization
	void Start () {
        Correct = Resources.Load<AudioClip>("True");
        Applaud = Resources.Load<AudioClip>("Applaud");
        Exclamatory = Resources.Load<AudioClip>("Exclamatory");
        audioSrc = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public static void PlaySound(string clip) {
        switch (clip) {
            case "correct":
                audioSrc.PlayOneShot(Correct);
                    break;
            case "applaud":
                audioSrc.PlayOneShot(Applaud);
                break;
            case "exclamatory":
                audioSrc.PlayOneShot(Exclamatory);
                break;
        }
    }
}
