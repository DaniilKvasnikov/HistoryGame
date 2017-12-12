using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour {
    private Image img;
    public Sprite[] sprites;
    private static Sprite[] prSprites;
	// Use this for initialization
	void Start () {
        img = gameObject.GetComponent<Image>();
        if (prSprites == null)
        {
            prSprites = new Sprite[sprites.Length];
        }
        for(int i=0;i< sprites.Length; i++)
        {
            if (sprites[i] != null)
            {
                prSprites[i] = prSprites[i];
            }
        }
	}

	// Update is called once per frame
	void Update ()
    {
        if (Music.music.audioSourceMain.mute)
        {
            img.sprite = sprites[0];
        }
        else
        {
            img.sprite = sprites[1];
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Debug.Log(Application.loadedLevel);
            switch (Application.loadedLevel)
            {
                case 0:
                    Application.Quit();
                    break;
                case 1:
                    Application.LoadLevel(0);
                    break;
                case 2:
                    Application.LoadLevel(0);
                    break;
                case 3:
                    Application.LoadLevel(0);
                    break;
                case 4:
                    Application.LoadLevel(0);
                    break;
                case 5:
                    Application.LoadLevel(0);
                    break;
                case 6:
                    Application.LoadLevel(1);
                    break;
                case 7:
                    Application.LoadLevel(2);
                    break;
                case 8:
                    Application.LoadLevel(3);
                    break;
                case 9:
                    Application.LoadLevel(4);
                    break;
                case 10:
                    Application.LoadLevel(5);
                    break;
                case 25:
                    Application.LoadLevel(ScriptsScene.loadNumGame);
                    break;
            }
        }
    }
    public void musicClick()
    {
        Music.music.audioSourceMain.mute = !Music.music.audioSourceMain.mute;
        //Music.music.audioSourceDop.mute = !Music.music.audioSourceDop.mute;
        if (Music.music.audioSourceMain.mute)
        {
            img.sprite = sprites[0];
        }
        else
        {
            img.sprite = sprites[1];
        }
    }
}
