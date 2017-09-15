using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptGame1Old : MonoBehaviour {
    private int pop;
    public static int numGame;
    public static int answer;
    public GameObject mainImage, answer1, answer2, answer3, question;
    public static Sprite spriteMain, spriteAnswer1, spriteAnswer2, spriteAnswer3, spriteQuestion;
    // Use this for initialization
    void Start ()
    {
        pop = 0;
        mainImage.transform.GetComponent<Image>().sprite = ScriptGame1.spriteMain;
        answer1.transform.GetComponent<Image>().sprite = ScriptGame1.spriteAnswer1;
        answer2.transform.GetComponent<Image>().sprite = ScriptGame1.spriteAnswer2;
        answer3.transform.GetComponent<Image>().sprite = ScriptGame1.spriteAnswer3;
        question.transform.GetComponent<Image>().sprite = ScriptGame1.spriteQuestion;
    }

    public void getAnswer(int an)
    {
        if(an == ScriptGame1.answer)
        {
            ScriptLvl.buttonState[ScriptsScene.loadNumGame-1, numGame] = true;
            Application.LoadLevel(5);
        }
        else
        {
            pop++;
            if(pop==2)
                Application.LoadLevel(4);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
