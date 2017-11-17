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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Debug.Log(Application.loadedLevel);
            switch (Application.loadedLevel)
            {
                case 0:
                    Application.Quit();
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
