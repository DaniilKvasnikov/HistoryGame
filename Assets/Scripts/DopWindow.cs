using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DopWindow : MonoBehaviour {
<<<<<<< HEAD
    //Дополнительное окно, подсказка
=======
>>>>>>> 652fda33282a75c8a7fc7ee4650855eb2395e8f3
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
