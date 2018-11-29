using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Menu_ShowSceneName : MonoBehaviour {
    public Text SceneName;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    public void ShowSceneName(string Name){
        SceneName.text = Name;
}
    public void HideSceneName() {
        SceneName.text = "";
    }
}
