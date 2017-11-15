using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptScene3 : MonoBehaviour
{
    //Скрипт загрузки заданий в главе 3
    public int num;
    public static int loadNumGame;
    public Sprite[] main, flag1, flag2, flag3, flag4, question, winProc, answer1, answer2, answer3, answer4;//спрайты с оценками
    public GameObject winProcObj;//объект вывода результатов
    public int[] answer;//решены ли вопросы
                        // Use this for initialization
    void Start()
    {
        if (winProcObj != null)
            winProcObj.GetComponent<Image>().enabled = false;
        if (ScriptsScene.good == null) 
			ScriptsScene.good[ScriptsScene.loadNumGame - 1] = 0;//если не запускали
        if (winProcObj != null)//если не создан
            winProcObj.GetComponent<Image>().sprite = winProc[ScriptsScene.good[ScriptsScene.loadNumGame - 1]];
        if ((ScriptsScene.good[ScriptsScene.loadNumGame - 1]) == 10)
        {
            visibleOn();
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void loadGame(int num)
    {
        switch (num)
        {
            case 2:
                loadGame1(0);//
                break;
            case 3:
                loadGame1(1);//
                break;
            case 4:
                loadGame9(2);//
                break;
            case 5:
                loadGame6(3, false);/**/
                break;
            case 6:
                loadGame4(4);
                break;
            case 7:
                loadGame8(5);
                break;
            case 8:
                loadGame4(6);/**/
                break;
            case 9:
                loadGame4(7);
                break;
            case 10:
                loadGame7(8);
                break;
            case 11:
                loadGame6(9, true);
                break;
        }
    }

    public void loadGame9(int numer)
    {
        ScriptGame3.spriteAnswer1 = answer1[numer];
        ScriptGame3.spriteAnswer2 = answer2[numer];
        ScriptGame3.spriteAnswer3 = answer3[numer];
        ScriptGame3.spriteAnswer4 = answer4[numer];
        ScriptGame3.spriteDuwn = main[numer];
        ScriptGame3.spriteQuestion = question[numer];
        ScriptGame3.FlagsS = new Sprite[4];
        ScriptGame3.FlagsS[0] = flag1[numer];
        ScriptGame3.FlagsS[1] = flag2[numer];
        ScriptGame3.FlagsS[2] = flag3[numer];
        ScriptGame3.FlagsS[3] = flag4[numer];
        ScriptGame3.answer = answer[numer];
        ScriptGame3.numGame = numer;
        Application.LoadLevel(26);
    }
    //загрузка по второй игре
    public void loadGame8(int numer)
    {
        ScriptGame1.numGame = numer;
        ScriptGame1.answer = answer[numer];
        ScriptGame1.spriteQuestion = question[numer];
        ScriptGame1.spriteMain = main[numer];
        ScriptGame1.spriteAnswer1 = answer1[numer];
        ScriptGame1.spriteAnswer2 = answer2[numer];
        ScriptGame1.spriteAnswer3 = answer3[numer];
        Application.LoadLevel(27);
    }
    public void loadGame7(int numer)
    {
        ScriptGame1.numGame = numer;
        ScriptGame1.answer = answer[numer];
        ScriptGame1.spriteQuestion = question[numer];
        ScriptGame1.spriteMain = main[numer];
        ScriptGame1.spriteAnswer1 = answer1[numer];
        ScriptGame1.spriteAnswer2 = answer2[numer];
        ScriptGame1.spriteAnswer3 = answer3[numer];
        Application.LoadLevel(24);
    }
    public void loadGame6(int numer, bool muve)
    {
        ScriptGame6.muve = muve;
        ScriptGame6.spriteAnswer1 = answer1[numer];
        ScriptGame6.spriteAnswer2 = answer2[numer];
        ScriptGame6.spriteAnswer3 = answer3[numer];
        ScriptGame6.spriteDuwn = main[numer];
        ScriptGame6.spriteQuestion = question[numer];
        ScriptGame6.FlagsS = new Sprite[3];
        ScriptGame6.FlagsS[0] = flag1[numer];
        ScriptGame6.FlagsS[1] = flag2[numer];
        ScriptGame6.FlagsS[2] = flag3[numer];
        ScriptGame6.answer = answer[numer];
        ScriptGame6.numGame = numer;
        Application.LoadLevel(18);
    }
    public void loadGame5(int numer)
    {
        ScriptGame5.answer = answer[numer];
        ScriptGame5.numGame = numer;
        Application.LoadLevel(17);
    }
    public void loadGame4(int numer)
    {
        ScriptGame1.spriteMain = main[numer];
        ScriptGame4.spriteAnswer1 = main[numer];
        ScriptGame4.spriteQuestion = question[numer];
        ScriptGame4.FlagsS = new Sprite[4];
        ScriptGame4.FlagsS[0] = flag1[numer];
        ScriptGame4.FlagsS[1] = flag2[numer];
        ScriptGame4.FlagsS[2] = flag3[numer];
        ScriptGame4.FlagsS[3] = flag4[numer];
        ScriptGame4.answer = answer[numer];
        ScriptGame4.numGame = numer;
        Application.LoadLevel(16);
    }
    public void loadGame3(int numer)
    {
        ScriptGame3.spriteAnswer1 = answer1[numer];
        ScriptGame3.spriteAnswer2 = answer2[numer];
        ScriptGame3.spriteAnswer3 = answer3[numer];
        ScriptGame3.spriteAnswer4 = answer4[numer];
        ScriptGame3.spriteDuwn = main[numer];
        ScriptGame3.spriteQuestion = question[numer];
        ScriptGame3.FlagsS = new Sprite[4];
        ScriptGame3.FlagsS[0] = flag1[numer];
        ScriptGame3.FlagsS[1] = flag2[numer];
        ScriptGame3.FlagsS[2] = flag3[numer];
        ScriptGame3.FlagsS[3] = flag4[numer];
        ScriptGame3.answer = answer[numer];
        ScriptGame3.numGame = numer;
        Application.LoadLevel(15);
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
        ScriptGame2Old.strIn = answer[num].ToString();
        ScriptGame2Old.spriteQuestion = question[num];
        ScriptGame2Old.numGame = num;
        Application.LoadLevel(14);
    }
    public void backToMenu()
    {
        //Debug.Log(loadNumGame+5);
        openWin(loadNumGame + 5);
    }
    //загрузка экрана игры
    public void openWin(int num)
    {
        Application.LoadLevel(num);
    }
    public void visibleOn()
    {
        winProcObj.GetComponent<Image>().enabled = true;
    }
}
