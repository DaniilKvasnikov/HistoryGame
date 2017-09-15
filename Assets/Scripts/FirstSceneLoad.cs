using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSceneLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void loadGame(int num)
    {
        ScriptsScene.loadNumGame = num;
        //Debug.Log("loadNumGame=" + ScriptsScene.loadNumGame);
        //Debug.Log(ScriptsScene.loadNumGame-1);
        Application.LoadLevel(num);
    }
    //завершение игры
    public void closeGame()
    {
        Application.Quit();
    }
}
