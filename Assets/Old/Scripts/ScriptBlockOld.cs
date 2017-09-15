using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptBlockOld : MonoBehaviour {
    public int znach;
    public Text textOut;

    // Use this for initialization
    void Start()
    {
        textOut.text = znach.ToString();
        //textOut.text = this.gameObject.GetComponent<ScriptsBlock>().znach.ToString();
        if (znach == 6 || znach == 9)
        {
            textOut.text += ".";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void doIt()
    {

    }
}
