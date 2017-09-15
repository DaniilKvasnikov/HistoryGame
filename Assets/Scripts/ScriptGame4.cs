using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptGame4 : MonoBehaviour
{
    public static int numGame;
    public static int answer;
    public static Sprite[] FlagsS;

    public static Sprite spriteQuestion;
    public GameObject question;
    public static Sprite spriteAnswer1;
    public GameObject answer1;
    public int[] num = new int[4];

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
        question.GetComponent<Image>().sprite = ScriptGame4.spriteQuestion;
        answer1.GetComponent<Image>().sprite = ScriptGame4.spriteAnswer1;
        for (int i = 0; i < Flags.Length; i++)
        {
            blockFlag[i].sprite = ScriptGame4.FlagsS[i];
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void getAnswer(int num)
    {
        if (Script15.flagWin)
        {
            if (ScriptGame4.answer == num)
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
}
