using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

<<<<<<< HEAD
public class ramkaSmoll : MonoBehaviour
{
    //Задание спрайта маленькой рамки для объекта материнского объекта
    public static Sprite[] sprites;
	// Use this for initialization
	void Start () {
=======
public class ramkaSmoll : MonoBehaviour {
    public static Sprite[] sprites;
	// Use this for initialization
	void Start () {
        //Debug.Log(gameObject + " "+(ScriptsScene.loadNumGame - 1));
>>>>>>> 652fda33282a75c8a7fc7ee4650855eb2395e8f3
        this.gameObject.GetComponent<Image>().sprite = ramkaSmoll.sprites[ScriptsScene.loadNumGame - 1];
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
