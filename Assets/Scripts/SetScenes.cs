using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScenes : MonoBehaviour {
	public string Good;
	public string Bed;
	// Use this for initialization
	void Start () {
		Scenes.Good = Good;
		Scenes.Bed = Bed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
