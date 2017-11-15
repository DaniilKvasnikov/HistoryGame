using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptGame9 : MonoBehaviour
<<<<<<< HEAD
{
    //Основной скрипт игры 9(сцены игра 9) выбери из вариантов
=======
{    
>>>>>>> 652fda33282a75c8a7fc7ee4650855eb2395e8f3
    public GameObject question;
    public GameObject down;
    public GameObject answer1;
    public GameObject answer2;
    public GameObject answer3;
    public GameObject answer4;

    private bool anwerColision;
    public GameObject[] blocks;
    public GameObject active;
    public Sprite nullImg;
    public GameObject a, b;
    public int ai, bi, ci;
    public bool Win;
    public int[] num = new int[4];

    private Sprite[] Flags = new Sprite[4];
    public Image[] blockFlag;

    void OnApplicationPause()
    {
        Application.LoadLevel(11);
    }
    // Use this for initialization
    void Start ()
    {
        Win = false;
        active.GetComponent<Image>().sprite = nullImg;
        Debug.Log("Game 3 start");
        question.GetComponent<Image>().sprite = ScriptGame3.spriteQuestion;
        down.GetComponent<Image>().sprite = ScriptGame3.spriteDuwn;
        answer1.GetComponent<Image>().sprite = ScriptGame3.spriteAnswer1;
        answer2.GetComponent<Image>().sprite = ScriptGame3.spriteAnswer2;
        answer3.GetComponent<Image>().sprite = ScriptGame3.spriteAnswer3;
        answer4.GetComponent<Image>().sprite = ScriptGame3.spriteAnswer4;
        for (int i = 0; i < Flags.Length; i++)
        {
            Flags[i] = ScriptGame3.FlagsS[i];
            num[i] = i;
        }
        /*
        for (int i = 0; i < 20; i++)
        {
            int j = UnityEngine.Random.Range(0, 3);
            int k = UnityEngine.Random.Range(0, 3);

            Sprite a = Flags[j];
            Flags[j] = Flags[k];
            Flags[k] = a;

            int c = num[j];
            num[j] = num[k];
            num[k] = c;
        }
        */
        for (int i = 0; i < Flags.Length; i++)
        {
            blockFlag[i].sprite = Flags[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetMouseButtonDown(0) && Input.touchCount < 1)
        {
            for (int i=0;i<blocks.Length;i++)
            {
                if (blocks[i].gameObject.GetComponent<BoxCollider2D>() != null)
                    if (blocks[i].gameObject.GetComponent<BoxCollider2D>().OverlapPoint(Input.mousePosition))
                    {
                        a = blocks[i];
                        ai = i;
                        active.GetComponent<Image>().sprite = blocks[i].GetComponent<Image>().sprite;
                        break;
                    }
            }
        }
        if (Input.GetAxis("Fire1") != 0 && Input.touchCount < 1
        && active != null)
        {
            active.transform.position = Input.mousePosition;
        }
        

        if (Input.GetMouseButtonUp(0))
        {
            for (int i = 0; i < blocks.Length; i++)
            {
                if (blocks[i].gameObject.GetComponent<BoxCollider2D>() != null)
                    if (blocks[i].gameObject.GetComponent<BoxCollider2D>().OverlapPoint(Input.mousePosition))
                    {
                        bi = i;
                        b = blocks[i];
                        break;
                    }
            }
            if (a != null)
            {
                active.GetComponent<Image>().sprite = a.GetComponent<Image>().sprite;
                a.GetComponent<Image>().sprite = b.GetComponent<Image>().sprite;
                b.GetComponent<Image>().sprite = active.GetComponent<Image>().sprite;

                ci = num[ai];
                num[ai] = num[bi];
                num[bi] = ci;

                a = null;
            }

            active.GetComponent<Image>().sprite = nullImg;

            bool answer = true;
            for (int i = 0; i < Flags.Length; i++)
            {
                answer = answer && (num[i] == i);
            }
            if (answer)
            {
                Win = true;
            }
            else
            {
                Win = false;
            }
        }
        */
    }

    public void getAnswer(int num)
    {
        Debug.Log("win " + Win+ " numGame=" + ScriptGame3.numGame + " "+ ScriptGame3.answer);
        //if (Win)
        //{
            if(ScriptGame3.answer == num)
            {
                ScriptLvl.buttonState[ScriptsScene.loadNumGame - 1, ScriptGame3.numGame] = true;
                ScriptsScene.good[ScriptsScene.loadNumGame - 1]++;
                Application.LoadLevel(12);
            }
            else
            {
                Application.LoadLevel(11);
            }
        //}
    }
}
