using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSceneLoad : MonoBehaviour {

	// Скрипт для загрузки глав с главного окна
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void loadGame(int num)
    {
        ScriptsScene.loadNumGame = num;
        Application.LoadLevel(num);
    }
    //завершение игры
    public void closeGame()
    {
        Application.Quit();
    }
}
