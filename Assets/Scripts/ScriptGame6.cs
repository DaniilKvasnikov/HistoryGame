using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

<<<<<<< HEAD
public class ScriptGame6 : MonoBehaviour
{
    //Основной скрипт игры 6(сцены игра 6) соотнеси(muve) и выбери
=======
public class ScriptGame6 : MonoBehaviour {
>>>>>>> 652fda33282a75c8a7fc7ee4650855eb2395e8f3
    public static bool muve;
    public static int numGame;
    public static int answer;
    public static Sprite[] FlagsS;

    public static Sprite spriteQuestion;
    public GameObject question;
    public static Sprite spriteDuwn;
    public GameObject down;
    public static Sprite spriteAnswer1;
    public GameObject answer1;
    public static Sprite spriteAnswer2;
    public GameObject answer2;
    public static Sprite spriteAnswer3;
    public GameObject answer3;

    private bool anwerColision;
    public GameObject[] blocks;
    public GameObject active;
    public Sprite nullImg;
    public GameObject a, b;
    public int ai, bi, ci;
    public bool Win;
    public int[] num = new int[3];

    private Sprite[] Flags = new Sprite[3];
    public Image[] blockFlag;

    void OnApplicationPause()
    {
        Application.LoadLevel(11);
    }
    // Use this for initialization
    void Start()
    {
        Win = false;
        active.GetComponent<Image>().sprite = nullImg;
        Debug.Log("Game 6 start");
        question.GetComponent<Image>().sprite = ScriptGame6.spriteQuestion;
        down.GetComponent<Image>().sprite = ScriptGame6.spriteDuwn;
        answer1.GetComponent<Image>().sprite = ScriptGame6.spriteAnswer1;
        answer2.GetComponent<Image>().sprite = ScriptGame6.spriteAnswer2;
        answer3.GetComponent<Image>().sprite = ScriptGame6.spriteAnswer3;
        for (int i = 0; i < Flags.Length; i++)
        {
            Flags[i] = FlagsS[i];
            num[i] = i;
        }
        if (muve)
        {
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
        }
        for (int i = 0; i < Flags.Length; i++)
        {
            blockFlag[i].sprite = Flags[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (muve)
        {
            if (Input.GetMouseButtonDown(0) && Input.touchCount < 1)
            {
                for (int i = 0; i < blocks.Length; i++)
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
                    ScriptLvl.buttonState[ScriptsScene.loadNumGame - 1, numGame] = true;
                    ScriptsScene.good[ScriptsScene.loadNumGame - 1]++;
                    Application.LoadLevel(12);
                }
                else
                {
                    Win = false;
                }
            }
        }
    }

    public void getAnswer(int num)
    {
        Debug.Log("win 6" + Win + " " + num + " " + ScriptGame6.answer);
        if ((Win && muve) || !muve)
        {
            if (ScriptGame6.answer == num)
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
