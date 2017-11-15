using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptGame2 : MonoBehaviour
{
    //Основной скрипт игры 2(сцены игра 2) кубики
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

    // Use this for initialization
    void Start()
    {
        question.transform.GetComponent<Image>().sprite = ScriptGame2.spriteQuestion;
        outBlocks.transform.localScale = new Vector3((float)(ScriptGame2.strIn.Length * razmer * 1.12), 1, 1);
        if (ScriptGame2.strIn != null)
            outI = ScriptGame2.strIn;
        else
            ScriptGame2.strIn = outI;
        answerObj = new GameObject[ScriptGame2.strIn.Length];
        answer = new bool[ScriptGame2.strIn.Length];
        for (int i = 0; i < ScriptGame2.strIn.Length; i++)
        {
            answer[i] = false;
            objects.Add(Instantiate(newBlock,
                new Vector2(this.gameObject.transform.position.x - razmer * ScriptGame2.strIn.Length / 2 + i * razmer + razmer / 2, this.gameObject.transform.position.y),
                Quaternion.identity) as GameObject);
            objects[objects.Count - 1].name = (objects.Count - 1) + "";
            objects[objects.Count - 1].transform.parent = transform.Find("Objects");
            answerObj[objects.Count - 1] = objects[objects.Count - 1];
            answerObj[objects.Count - 1].name = ScriptGame2.strIn[i] + "";
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 click;
        if (Input.GetMouseButtonDown(0) && Input.touchCount < 1)
        {
            click = new Vector3((Input.mousePosition.x - (Screen.width - 1280 * Screen.height / 800) / 2) * 1280 * Screen.height / 800 / Screen.width, Input.mousePosition.y * 800 / Screen.height, 0);
        Debug.Log(click + " "+ blocks[0].gameObject.transform.position);
            //Debug.Log(Screen.width + "x" + Screen.height);


            foreach (GameObject obj2 in blocks)
            {
                if (obj2.gameObject.GetComponent<BoxCollider2D>() != null)
                {
                    anwerColision = obj2.gameObject.GetComponent<BoxCollider2D>().OverlapPoint(click);
                    if (anwerColision)
                    {
                        Debug.Log("collision");
                        active = obj2;
                        break;
                    }
                }
            }
        }
        if (Input.GetAxis("Fire1") != 0 && Input.touchCount < 1
        && active != null)
        {
            click = new Vector3((Input.mousePosition.x - (Screen.width - 1280 * Screen.height / 800) / 2) * 1280 * Screen.height / 800 / Screen.width, Input.mousePosition.y * 800 / Screen.height, 0);
            if (active.gameObject.GetComponent<Rigidbody2D>() != null)
                active.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2((click.x - active.gameObject.transform.position.x)
                    , (click.y - active.gameObject.transform.position.y));
        }
        /*if (Input.touchCount == 1)
        {
            Touch touch0 = Input.GetTouch(0);
            if (touch0.phase == TouchPhase.Began)
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
            if (touch0.phase == TouchPhase.Moved && active != null)
            {
                if (active.gameObject.GetComponent<Rigidbody2D>() != null)
                    active.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2((Input.mousePosition.x - active.gameObject.transform.position.x)
                        , (Input.mousePosition.y - active.gameObject.transform.position.y));
            }
        }*/


        for (int num = 0; num < answerObj.Length; num++)
        {
            foreach (GameObject obj2 in blocks)
            {
                if (obj2.gameObject.GetComponent<ScriptBlock>().znach.ToString() == answerObj[num].name)
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
        /*if (Input.touchCount == 1)
        {
            Touch touch0 = Input.GetTouch(0);
            if (touch0.phase == TouchPhase.Ended)
            {
                active = null;
            }
        }*/

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
            ScriptLvl.buttonState[ScriptsScene.loadNumGame - 1, numGame] = true;
            Application.LoadLevel(1);
        }
    }
}
