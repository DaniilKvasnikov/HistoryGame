using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSetNativeSize : MonoBehaviour {

	// Use this for initialization
	void Start () {
    }

    // Update is called once per frame
    void Update () {
        Debug.Log("SetNativeSize");
        if (gameObject != null)
            if (gameObject.GetComponent<Image>() != null)
                gameObject.GetComponent<Image>().SetNativeSize();
    }
}
