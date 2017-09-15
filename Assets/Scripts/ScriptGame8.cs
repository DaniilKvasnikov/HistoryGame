using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptGame8 : MonoBehaviour
{
    public static int numGame;
    static public int answer;
    static public Sprite questionSprite;
    public Image questionImg;

    // Use this for initialization
    void Start ()
    {
        Debug.Log(ScriptGame8.answer);
        questionImg.sprite = questionSprite;
    }

    public void answerClick(int num)
    {
        if (Script15.flagWin)
        {
            if (num == ScriptGame8.answer)
            {
                ScriptLvl.buttonState[ScriptsScene.loadNumGame - 1, numGame] = true;
                ScriptsScene.good[ScriptsScene.loadNumGame - 1]++;
                Application.LoadLevel(12);
            }
            else
            {
                Application.LoadLevel(11);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {

    }
    void OnApplicationPause()
    {
        Application.LoadLevel(11);
    }
}
