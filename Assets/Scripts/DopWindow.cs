using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DopWindow : MonoBehaviour {
    public bool active;

    public Image img, button;
	// Use this for initialization
	void Start () {
        active = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
        img.enabled = active;
        button.enabled = active;
    }

    public void setActive(bool active)
    {
        this.active = active;
    }
}
