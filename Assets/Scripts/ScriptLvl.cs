using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptLvl : MonoBehaviour {
    public int numer;
    private const int kol = 5;
    public const int razmer = 10;//всего вопросов
    public GameObject []buttons = new GameObject[razmer];//кнопки
    public static bool [,]buttonState = new bool[kol,razmer];//решены ли
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0; i < razmer; i ++)
        {
            if (buttonState[numer,i])
            {
                if (buttons[i] != null)
                {
                    //Debug.Log("Destroy");
                    Destroy(buttons[i]);//если решено
                }
            }
        }
	}
}
