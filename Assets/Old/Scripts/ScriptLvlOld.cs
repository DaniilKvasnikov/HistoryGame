using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptLvlOld : MonoBehaviour {
    public const int razmer = 10;
    public GameObject []buttons = new GameObject[razmer];
    public static bool []buttonState = new bool[razmer];
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0; i < razmer; i ++)
        {
            if (buttonState[i])
            {
                if (buttons[i] != null)
                    Destroy(buttons[i]);
            }
        }
	}
}
