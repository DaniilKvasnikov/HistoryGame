using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptGame5 : MonoBehaviour
{
    public static int numGame;
    public static int answer;
    public static Sprite[] FlagsS;

    public static Sprite spriteQuestion;
    public GameObject question;
    public static Sprite spriteAnswer1;
    public GameObject answer1;

    private bool anwerColision;
    public GameObject[] blocks;

    private Sprite[] Flags = new Sprite[4];
    public Image[] blockFlag;

    void OnApplicationPause()
    {
        Application.LoadLevel(11);
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void getAnswer(int num)
    {
        if (ScriptGame5.answer == num)
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
