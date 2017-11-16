using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ramka : MonoBehaviour
{
    //Записывает спрайты в статичные скрипты для дальнейшего использования
    public Sprite[] spritesBigN;
    public Sprite[] spritesFoneN;
    public Sprite[] spritesButtonN;
    public Sprite[] ramkaSmollN;
    public Sprite[] ramkaFoneWinLoseN;
    public Sprite[] ramkaPodzsazkaN;
    // Use this for initialization
    void Start () {
        int razmer = 5;
        if (ramkaBig.sprites == null)
        {
            ramkaBig.sprites = new Sprite[razmer];
            ramkaFone.sprites = new Sprite[razmer];
            ramkaButton.sprites = new Sprite[razmer];
            ramkaSmoll.sprites = new Sprite[razmer];
            ramkaFoneWinLose.sprites = new Sprite[razmer];
            ramkaPodskazka.sprites = new Sprite[razmer];
            for (int i = 0; i < razmer; i++)
            {
                ramkaBig.sprites[i] = spritesBigN[i];
                ramkaFone.sprites[i] = spritesFoneN[i];
                ramkaButton.sprites[i] = spritesButtonN[i];
                ramkaSmoll.sprites[i] = ramkaSmollN[i];
                ramkaFoneWinLose.sprites[i] = ramkaFoneWinLoseN[i];
                ramkaPodskazka.sprites[i] = ramkaPodzsazkaN[i];
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
