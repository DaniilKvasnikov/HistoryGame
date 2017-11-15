using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptBlock : MonoBehaviour {
    //Скрипт для кубиков
    public int znach;//число на кубе
    public Text textOut;//панель вывода
    public Sprite[] kybs;

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Image>().sprite = kybs[ScriptsScene.loadNumGame - 1];
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
        gameObject.GetComponent<Image>().sprite = kybs[ScriptsScene.loadNumGame - 1];
        textOut.text = znach.ToString();
        //textOut.text = this.gameObject.GetComponent<ScriptsBlock>().znach.ToString();
        if (znach == 6 || znach == 9)
        {
            textOut.text += ".";
        }
    }

    public void doIt()
    {

    }
}
