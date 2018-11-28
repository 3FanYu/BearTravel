using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMenuCategory : MonoBehaviour {
    public Text category;
    int i;
    GameObject Des;
     GameObject[] menu = new GameObject[4];
    string[] CategoryName = new string[] { "本土景點", "歷史古蹟", "現代建築", "神秘禁區" };
    // Use this for initialization
    void Start () {
        
        int i = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void RightArrow() {
        if (i == 3) { return; }
        else
        {
            i += 1;
            //menu[i - 1].SetActive(false);
            Des = GameObject.Find("Menu (" + (i - 1) + ")");
            print("Menu(" + (i - 1) + ")");
            Destroy(Des);
             menu[i] = (GameObject)Instantiate(Resources.Load("Menu ("+i+")"));
            menu[i].name = "Menu (" + i + ")";
            print("Menu (" + i + ")");
            menu[i].SetActive(true);
            category.text = CategoryName[i];
            print("Right");
        }
    }
    public void LeftArrow()
    {
        if (i == 0) { return; }
        else
        {
            i -= 1;
            Des = GameObject.Find("Menu (" + (i + 1) + ")");
            Destroy(Des);
            menu[i] = (GameObject)Instantiate(Resources.Load("Menu (" + i + ")"));
            menu[i].name = "Menu (" + i + ")";
            //menu[i + 1].SetActive(false);
            menu[i].SetActive(true);
            category.text = CategoryName[i];
        }
    }
}
