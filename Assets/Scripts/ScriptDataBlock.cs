using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptDataBlock : MonoBehaviour {
    int []num = new int[8];
    public Text[] text;
    public Image question;
    public static Sprite questionSprite;
    public static int answer;
    public static int numGame;
    // Use this for initialization
    void Start ()
    {
        question.sprite = ScriptDataBlock.questionSprite;
    }

    public void add(int n)
    {
        num[n]++;
        if (num[n] > 9)
            num[n] = 0;
        proverka();
    }

    public void minus(int n)
    {
        num[n]--;
        if (num[n] < 0)
            num[n] = 9;
        proverka();
    }

    public void proverka()
    {
        string now = "";
        string need = ScriptDataBlock.answer.ToString();
        for (int i = 0; i < 8; i++)
        {
            now += num[i];
        }
        bool an = true;

        for (int i = 0; i < 8; i++)
        {
            an = an && (now[i] == need[i]);
        }
        //Debug.Log(now + " " + need + " " + an);
        if (an)
        {
            ScriptLvl.buttonState[ScriptsScene.loadNumGame - 1, numGame] = true;
            ScriptsScene.good[ScriptsScene.loadNumGame - 1]++;
            Application.LoadLevel(12);
        }
    }
    // Update is called once per frame
    void Update () {
        for(int i = 0; i < 8; i++)
        {
            text[i].text = num[i].ToString();
        }
    }
    void OnApplicationPause()
    {
        Application.LoadLevel(11);
    }
}
