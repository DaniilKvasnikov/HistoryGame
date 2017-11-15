using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoodBed : MonoBehaviour {
    //Загрузка окна завешения задания с фоном соответствующего открытой главе
    public static int numGame;
    public Sprite[] sprites = new Sprite[5];
    public Image image;
	// Use this for initialization
	void Start () {
        Debug.Log(numGame);
        //image.sprite = sprites[numGame];
    }


    public void loadGame()
    {
        Debug.Log(ScriptsScene.loadNumGame);
        Application.LoadLevel(ScriptsScene.loadNumGame);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
