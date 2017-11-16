using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDopMusic : MonoBehaviour {
    public int num;
	// Use this for initialization
	void Start () {
        Music.music.Mute();
        Music.music.PlayDop(num);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDestroy()
    {
        Music.music.StopDop();
        Music.music.Unmute();
    }
}
