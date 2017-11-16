using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptHistory : MonoBehaviour {
    //Скрипт окна историческая справка
    public static int version;
    public int valueMax;
    private const int valueMin = 0;
    public int numNow;
    public Image outImage;
    public Sprite[] v1, v2, v3, v4, v5;

    // Use this for initialization
    void Start()
    {
        //Debug.Log(Music.music.name);
        numNow = 0;
        reloadImage();
        switch (version)
        {
            case 0:
                valueMax = v1.Length;
                break;
            case 1:
                valueMax = v2.Length;
                break;
            case 2:
                valueMax = v3.Length;
                break;
            case 3:
                valueMax = v4.Length;
                break;
            case 4:
                valueMax = v5.Length;
                break;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void add()
    {
        if (numNow < valueMax - 1) numNow++;
        reloadImage();
    }

    public void minus()
    {
        if (numNow > valueMin) numNow--;
        reloadImage();
    }

    public void reloadImage()
    {
        //Debug.Log(numNow);
        if(v1.Length>1)
            switch (version)
            {
                case 0:
                    outImage.sprite = v1[numNow];
                    break;
                case 1:
                    outImage.sprite = v2[numNow];
                    break;
                case 2:
                    outImage.sprite = v3[numNow];
                    break;
                case 3:
                    outImage.sprite = v4[numNow];
                    break;
                case 4:
                    outImage.sprite = v5[numNow];
                    break;
            }
    }
}
