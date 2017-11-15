using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBlock1 : MonoBehaviour {

    public Vector2 position;//Позиция прикрепленного объекта
    public GameObject main;//Прозрачный объект
	// Use this for initialization
	void Start () {
		
	}
    public void muveBlock(GameObject obj)
    {
        muve(obj);
        main.GetComponent<Script15>().click();
    }
	public bool muve(GameObject obj)
    {
        if (Mathf.Abs(this.position.x - obj.GetComponent<ScriptBlock1>().position.x) == 1 && Mathf.Abs(this.position.y - obj.GetComponent<ScriptBlock1>().position.y) == 0
            ||
            Mathf.Abs(this.position.x - obj.GetComponent<ScriptBlock1>().position.x) == 0 && Mathf.Abs(this.position.y - obj.GetComponent<ScriptBlock1>().position.y) == 1)
        {//Если соседствует с пустым
            //Debug.Log(obj.name);
            Vector3 pos = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0);
            this.gameObject.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y, 0);
            obj.transform.position = new Vector3(pos.x, pos.y, 0);
            //Меняем местами с пустым
            Vector2 pos2 = new Vector2(this.position.x, this.position.y);
            this.position = new Vector2(obj.GetComponent<ScriptBlock1>().position.x, obj.GetComponent<ScriptBlock1>().position.y);
            obj.GetComponent<ScriptBlock1>().position = new Vector2(pos2.x, pos2.y);
            return true;
        }
        return false;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
