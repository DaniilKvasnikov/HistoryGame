﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ramkaFone : MonoBehaviour {
    public static Sprite[] sprites;
	// Use this for initialization
	void Start () {
        //Debug.Log(gameObject + " "+(ScriptsScene.loadNumGame - 1));
        this.gameObject.GetComponent<Image>().sprite = ramkaFone.sprites[ScriptsScene.loadNumGame - 1];
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
