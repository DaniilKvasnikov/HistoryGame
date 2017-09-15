using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script15 : MonoBehaviour {
    public static bool flagWin;
    public Vector2 nullPos;//позиция пустого
    public GameObject nullObj;//пустой
    private Sprite mySprite;//спрайт изображения
    public Sprite nullImg;//часть исходного изображения
    public GameObject activeImg;//целое изображение для вывода
    public GameObject[] obj;//объекты части пятнашки
    public Vector2[] objV;//векторы частей пятнашек
    private Vector2 pos;//позиция текущей части
	// Use this for initialization
	void Start ()
    {
        gameObject.GetComponent<Image>().sprite = ScriptGame1.spriteMain;
        Script15.flagWin = false;
        resetImg();
        int i = 0;
        pos = obj[5].GetComponent<ScriptBlock1>().position;
        while (i  < 25)
        {
            int num = Convert.ToInt32(UnityEngine.Random.Range(0, 5));
                //перемешиваем части
            if (obj[5].GetComponent<ScriptBlock1>().muve(obj[num])/* && pos!= obj[5].GetComponent<ScriptBlock1>().position*/)
            {
                i++;
                if (win() && i==24)
                {
                    i -= 10;
                }
            }
            pos = obj[5].GetComponent<ScriptBlock1>().position;
        }
        //Debug.Log(win());
    }

    public void resetImg()
    {//расположить к старту
        Texture2D tex = ScriptGame1.spriteMain.texture;
        int width = tex.width / 3;
        int height = tex.height / 2;
        for (int i = 0; i < 6; i++)
        {
            obj[i].transform.GetComponent<Image>().sprite  
                = Sprite.Create(
                    tex
                    , new Rect(objV[i].x * width, objV[i].y * height, width, height)
                    , new Vector2(0.5f, 0.5f)
                    , 100.0f
                    );
            if (objV[i].x == 2 && objV[i].y == 0)
            {
                nullObj = obj[i];
                nullPos = new Vector2(2, 0);
                obj[i].transform.GetComponent<Image>().sprite = nullImg;
            }
        }
    }
    public void click()
    {
        if (win())
        {
            Script15.flagWin = true;
            for (int i = 0; i < 6; i++)
            {//если игра завершилась
                Destroy(obj[i]);
                activeImg.GetComponent<Image>().enabled = true;
            }
        }
    }
    public bool win()
    {//проверка на окончание
        bool answer = true;
        for(int i = 0; i < 6; i++)
        {
            bool x = (obj[i].GetComponent<ScriptBlock1>().position.x == objV[i].x);
            bool y= obj[i].GetComponent<ScriptBlock1>().position.y == objV[i].y;
            //Debug.Log(i + " " + x + " " + y);
            answer = answer && (obj[i].GetComponent<ScriptBlock1>().position.x == objV[i].x && obj[i].GetComponent<ScriptBlock1>().position.y == objV[i].y);
        }
        return answer;
    }
    // Update is called once per frame
    void Update () {
	}
}
