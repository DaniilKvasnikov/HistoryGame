using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptGame2Old : MonoBehaviour
{
    public double time;
    private bool over;
    public Image ramkaImg;
    public static int numGame;
    public int radius;
    public static string strIn;
    public string outI;
    public GameObject newBlock;
    private GameObject[] answerObj;
    private bool[] answer;
    public GameObject[] blocks;
    public GameObject active;
    public List<GameObject> objects = new List<GameObject>();
    public int razmer = 188;
    public GameObject outBlocks;
    public GameObject question;
    public static Sprite spriteQuestion;
    private bool anwerColision;
    public float timer;
    public Text outTimer;
    public Sprite[] spriteFone;
    public Image imageFone;
    public ScriptBlock[] blockScripts;

    void OnApplicationPause()
    {
        Application.LoadLevel(11);
    }
    // Use this for initialization
    void Start()
    {
        over = false;
        if (time < 1) time = 1;
        ramkaImg.enabled = (ScriptsScene.loadNumGame - 1 == 0);
        //Debug.Log(spriteFone.Length);
        //Debug.Log(ScriptsScene.loadNumGame - 1);
        imageFone.sprite = spriteFone[ScriptsScene.loadNumGame - 1];
        question.transform.GetComponent<Image>().sprite = ScriptGame2Old.spriteQuestion;
        outBlocks.transform.localScale = new Vector3((float)(ScriptGame2Old.strIn.Length * razmer *1.12), 1, 1);
        if (ScriptGame2Old.strIn != null)
            outI = ScriptGame2Old.strIn;
        else
            ScriptGame2Old.strIn = outI;
        //Debug.Log(ScriptGame2Old.strIn.Length);
        answerObj = new GameObject[ScriptGame2Old.strIn.Length];
        answer = new bool[ScriptGame2Old.strIn.Length];
        for (int i = 0; i < ScriptGame2Old.strIn.Length; i++)
        {
            answer[i] = false;
            objects.Add(Instantiate(newBlock,
                new Vector2(this.gameObject.transform.position.x - razmer * ScriptGame2Old.strIn.Length / 2 + i * razmer + razmer / 2, this.gameObject.transform.position.y),
                Quaternion.identity) as GameObject);
            objects[objects.Count - 1].name = (objects.Count - 1) + "";
            objects[objects.Count - 1].transform.parent = transform.Find("Objects");
            answerObj[objects.Count - 1] = objects[objects.Count - 1];
            answerObj[objects.Count - 1].name = ScriptGame2Old.strIn[i] + "";
        }
        //string buttons = "";
        int[] ibut = new int[10];
        for(int i = 0; i < 10; i++)
        {
            ibut[i] = UnityEngine.Random.Range(0, 9);
        }
        for(int i=0;i< ScriptGame2Old.strIn.Length; i++)
        {
            //Debug.Log(i + ":" + (Convert.ToInt32(ScriptGame2Old.strIn[i])-48));
            ibut[i] = (Convert.ToInt32(ScriptGame2Old.strIn[i]) - 48);
        }
        for (int i = 0; i < 10; i++)
        {
            //Debug.Log(i+":"+ibut[i].ToString());
        }
        for(int i = 0; i < 20; i++)
        {
            int j = UnityEngine.Random.Range(0, 9);
            int k = UnityEngine.Random.Range(0, 9);
            int a = ibut[j];
            ibut[j] = ibut[k];
            ibut[k] = a;
        }
        for (int i = 0; i < 10; i++)
        {
            //buttons += ibut[i].ToString();
            blockScripts[i].znach = ibut[i];
        }
        //Debug.Log("buttons=" + buttons);
    }

    // Update is called once per frame
    void Update()
    {
        if (over)
        {
            if (time < 0)
            {
                Debug.Log("Out" + numGame);
                ScriptLvl.buttonState[ScriptsScene.loadNumGame - 1, numGame] = true;
                ScriptsScene.good[ScriptsScene.loadNumGame - 1]++;
                Application.LoadLevel(12);
            }
            else
            {
                time -= Time.deltaTime;
            }
        }
        else
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                Application.LoadLevel(11);
            }
            outTimer.text = ((int)(timer)).ToString();

            if (Input.GetMouseButtonDown(0) && Input.touchCount < 1)
            {
                foreach (GameObject obj2 in blocks)
                {
                    if (obj2.gameObject.GetComponent<BoxCollider2D>() != null)
                        if (obj2.gameObject.GetComponent<BoxCollider2D>().OverlapPoint(Input.mousePosition))
                        {
                            active = obj2;
                            break;
                        }
                }
            }
            if (Input.GetAxis("Fire1") != 0 && Input.touchCount < 1
            && active != null)
            {
                if (active.gameObject.GetComponent<Rigidbody2D>() != null)
                    active.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2((Input.mousePosition.x - active.gameObject.transform.position.x)
                        , (Input.mousePosition.y - active.gameObject.transform.position.y));
            }

            for (int num = 0; num < answerObj.Length; num++)
            {
                foreach (GameObject obj2 in blocks)
                {
                    if (obj2.gameObject.GetComponent<ScriptBlock>().znach.ToString() == answerObj[num].name && !answer[num])
                    {
                        float len =
                            Mathf.Sqrt(
                                Mathf.Pow(answerObj[num].transform.position.x - obj2.transform.position.x, 2)
                                + Mathf.Pow(answerObj[num].transform.position.y - obj2.transform.position.y, 2));

                        if (len < radius)
                        {
                            obj2.transform.position
                                = new Vector3(answerObj[num].transform.position.x, answerObj[num].transform.position.y, answerObj[num].transform.position.z);
                            obj2.transform.eulerAngles = new Vector3(0, 0, 0);
                            obj2.transform.SetAsFirstSibling();
                            Destroy(obj2.gameObject.GetComponent<Rigidbody2D>());
                            Destroy(obj2.gameObject.GetComponent<BoxCollider2D>());
                            answer[num] = true;
                        }
                    }
                }
            }
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            active = null;
        }
        bool newAnswer = true;
        for (int num = 0; num < answer.Length; num++)
        {
            newAnswer = newAnswer && answer[num];
        }
        if (newAnswer)
        {
            over = true;
        }
    }
}
