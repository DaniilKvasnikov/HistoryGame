using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptGame1 : MonoBehaviour {
    public static int numGame;//номер игры
    public static int answer;//верный ответ
    public GameObject mainImage, answer1, answer2, answer3, question;//объекты на экране
    public static Sprite spriteMain, spriteAnswer1, spriteAnswer2, spriteAnswer3, spriteQuestion;//спрайты для вывода

    void OnApplicationPause()
    {
        Application.LoadLevel(11);
    }
    // Use this for initialization
    void Start ()
    {//Загрузка игры
        mainImage.transform.GetComponent<Image>().sprite = ScriptGame1.spriteMain;
        answer1.transform.GetComponent<Image>().sprite = ScriptGame1.spriteAnswer1;
        answer2.transform.GetComponent<Image>().sprite = ScriptGame1.spriteAnswer2;
        answer3.transform.GetComponent<Image>().sprite = ScriptGame1.spriteAnswer3;
        question.transform.GetComponent<Image>().sprite = ScriptGame1.spriteQuestion;
    }

    public void getAnswer(int an)
    {
        if (Script15.flagWin)
        {
            if (an == ScriptGame1.answer)
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
        else
        {
            
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
