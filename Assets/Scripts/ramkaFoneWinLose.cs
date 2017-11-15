using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

<<<<<<< HEAD
public class ramkaFoneWinLose : MonoBehaviour
{
    //Задание спрайта фона окна победа и поражение для объекта материнского объекта
=======
public class ramkaFoneWinLose : MonoBehaviour {
>>>>>>> 652fda33282a75c8a7fc7ee4650855eb2395e8f3
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
