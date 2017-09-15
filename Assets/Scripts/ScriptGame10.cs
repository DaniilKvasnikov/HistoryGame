using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptGame10 : MonoBehaviour {

    public static int numGame;
    static public int answer;
    static public Sprite questionSprite;
    static public Sprite question1, question2, question3, question4;
    public Image questionImg;
    public Image questionImg1, questionImg2, questionImg3, questionImg4;

    // Use this for initialization
    void Start()
    {
        questionImg.sprite = ScriptGame10.questionSprite;
        questionImg1.sprite = ScriptGame10.question1;
        questionImg2.sprite = ScriptGame10.question2;
        questionImg3.sprite = ScriptGame10.question3;
        questionImg4.sprite = ScriptGame10.question4;
    }

    public void answerClick(int num)
    {
        if (Script15.flagWin)
        {
            if (num == ScriptGame10.answer)
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
    void Update()
    {

    }
    void OnApplicationPause()
    {
        Application.LoadLevel(11);
    }
}
