using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptsSceneOld : MonoBehaviour {
    public Sprite[] main, answer1, answer2, answer3, question;
    public int[] answer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void loadGame(int num)
    {
        int numer;
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
        }
    }
    public void loadGame2(int numer)
    {
        ScriptGame1.numGame = numer;
        ScriptGame1.answer = answer[numer];
        ScriptGame1.spriteQuestion = question[numer];
        ScriptGame1.spriteMain = main[numer];
        ScriptGame1.spriteAnswer1 = answer1[numer];
        ScriptGame1.spriteAnswer2 = answer2[numer];
        ScriptGame1.spriteAnswer3 = answer3[numer];
        Application.LoadLevel(2);
    }
    public void loadGame1(int num)
    {
        ScriptGame2.strIn = answer[num].ToString();
        ScriptGame2.spriteQuestion = question[num];
        ScriptGame2.numGame = num;
        Application.LoadLevel(3);
    }
    public void openWin(int num)
    {
        Application.LoadLevel(num);
    }
}
