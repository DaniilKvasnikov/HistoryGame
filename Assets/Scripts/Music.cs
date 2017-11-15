using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {
	public static Music music;
	public AudioSource audioSource;
	// Use this for initialization
	void Start ()
    {
        if (music != null)
        {
            Destroy(transform.gameObject);
        }
        else
        {
			music = transform.gameObject.GetComponent<Music> ();
            DontDestroyOnLoad(transform.gameObject);
        }
		audioSource = gameObject.GetComponent<AudioSource> ();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Stop()
    {
		audioSource.Stop ();
    }
}
