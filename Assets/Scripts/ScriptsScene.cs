using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptsScene : MonoBehaviour
{
    //Скрипт загрузки заданий в главе 1
    public int num;
    public static int loadNumGame;
    public static int []good = new int[5];//всего решено
    public Sprite[] main, answer1, answer2, answer3, question, winProc;//спрайты с оценками
    public GameObject winProcObj;//объект вывода результатов
    public int[] answer;//решены ли вопросы
	// Use this for initialization
	void Start ()
    {
        if (winProcObj != null)
            winProcObj.GetComponent<Image>().enabled = false;
        if (good == null) 
			good[ScriptsScene.loadNumGame - 1] = 0;//если не запускали
        if (winProcObj != null)//если не создан
            winProcObj.GetComponent<Image>().sprite = winProc[good[ScriptsScene.loadNumGame - 1]];
        //Debug.Log((good[ScriptsScene.loadNumGame - 1]));
        if ((good[ScriptsScene.loadNumGame - 1]) == 10)
        {
            visibleOn();
        }
    }
	
	// Update is called once per frame
	void Update () {
    }

    public void loadGame(int num)
    {
        switch (num)
        {
            case 2:
                loadGame2(0);
                break;
            case 3:
                loadGame1(1);
                break;
            case 4:
                loadGame2(2);
                break;
            case 5:
                loadGame2(3);
                break;
            case 6:
                loadGame1(4);
                break;
            case 7:
                loadGame2(5);
                break;
            case 8:
                loadGame2(6);
                break;
            case 9:
                loadGame2(7);
                break;
            case 10:
                loadGame2(8);
                break;
            case 11:
                loadGame2(9);
                break;
        }
    }
    //загрузка по второй игре
    public void loadGame2(int numer)
    {
        ScriptGame1.numGame = numer;
        ScriptGame1.answer = answer[numer];
        ScriptGame1.spriteQuestion = question[numer];
        ScriptGame1.spriteMain = main[numer];
        ScriptGame1.spriteAnswer1 = answer1[numer];
        ScriptGame1.spriteAnswer2 = answer2[numer];
        ScriptGame1.spriteAnswer3 = answer3[numer];
        Application.LoadLevel(13);
    }
    //загрузка по первой игре
    public void loadGame1(int num)
    {
        //ScriptsScene.loadNumGame = this.num;
        Debug.Log("loadNumGame=" + loadNumGame);
        ScriptGame2Old.strIn = answer[num].ToString();
        ScriptGame2Old.spriteQuestion = question[num];
        ScriptGame2Old.numGame = num;
        Application.LoadLevel(14);
    }
    public void backToMenu()
    {
        //Debug.Log(loadNumGame+5);
        openWin(loadNumGame+5);
    }
    public void backFirstToMenu()
    {
        //Debug.Log(loadNumGame+5);
        openWin(loadNumGame);
    }
    //загрузка экрана игры
    public void openWin(int num)
    {
        Application.LoadLevel(num);
    }

    public void visibleOn()
    {
        if(winProcObj!=null)
            winProcObj.GetComponent<Image>().enabled = true;
    }

    public void historyOpen(int num)
    {
        ScriptHistory.version = num;
        Application.LoadLevel(25);
    }
}
