using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {
	public static Music music;
    public AudioSource audioSourceMain;
    public AudioSource audioSourceDop;
    public AudioClip[] clips;
    private int numMusic;
    public enum State { PLAY, MUTE};
    public State state;
    public float deltaTime = 1;
    private float time = 1;

    void Start()
    {
        numMusic = 0;
        time = deltaTime;
        if (music != null)
        {
            Destroy(transform.gameObject);
        }
        else
        {
			music = transform.gameObject.GetComponent<Music> ();
            DontDestroyOnLoad(transform.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case State.MUTE:
                if (time >= 0)
                {
                    audioSourceMain.volume = time / deltaTime;
                    time -= Time.deltaTime;
                }
                if (!audioSourceDop.isPlaying)
                {
                    state = State.PLAY;
                }
                break;
            case State.PLAY:
                if (time <= deltaTime)
                {
                    audioSourceMain.volume = time / deltaTime;
                    time += Time.deltaTime;
                }
                break;
        }
        if (!audioSourceMain.isPlaying)
        {
            PlayNext(3);
        }
    }

    public void Stop()
    {
        audioSourceMain.Stop ();
    }

    public void Play()
    {
        audioSourceMain.Play();
    }

    public void SetMusic(AudioClip clip)
    {
        if (clip != null)
        {
            Stop();
            audioSourceMain.clip = clip;
            Play();
        }
    }
    public void SetMusic(int num)
    {
        if (num >= 0 && num < clips.Length)
        {
            SetMusic(clips[num]);
        }
    }

    public void PlayNext(int max)
    {
        numMusic++;
        if (numMusic >= max)
        {
            numMusic = 0;
        }
        SetMusic(numMusic);
    }

    public void Mute()
    {
        state = State.MUTE;
    }
    public void Unmute()
    {
        state = State.PLAY;
    }

    public void PlayDop(int num)
    {
        if (num >= 0 && num < clips.Length && audioSourceDop != null)
        {
            audioSourceDop.Stop();
            audioSourceDop.clip = clips[num];
            audioSourceDop.Play();
        }
    }

    public void StopDop()
    {
        if (audioSourceDop != null)
        {
            audioSourceDop.Stop();
            audioSourceDop.time = 0;
        }
    }
}
