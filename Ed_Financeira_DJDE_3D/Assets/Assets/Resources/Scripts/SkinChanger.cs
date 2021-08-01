using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Linq;

public class SkinChanger : MonoBehaviour
{
    public Image iconRender;

    public Text texto;

    public Sprite[] sprites;

    public string spriteSheetName;

    public string loadedSpriteSheet;

    public Dictionary<string, Sprite> spriteSheet;

    // Start is called before the first frame update
    void Start()
    {
        iconRender.GetComponent<Image>();
        texto.GetComponent<Text>();
        loadSpriteSheet();
    }

    void LateUpdate()
    {
        if (loadedSpriteSheet != spriteSheetName)
        {
            loadSpriteSheet();
        }
        iconRender.sprite = spriteSheet[iconRender.sprite.name];
    }

    public void loadSpriteSheet()
    {
        sprites = Resources.LoadAll<Sprite>(spriteSheetName);
        spriteSheet = sprites.ToDictionary(x => x.name, x => x);
        loadedSpriteSheet = spriteSheetName;

        if (spriteSheetName == "Roberto")
        {
            texto.GetComponent<Text>().color = Color.green;
        }
        if (spriteSheetName == "Ana Maria")
        {
            texto.GetComponent<Text>().color = Color.blue;
        }
        if (spriteSheetName == "Matheus")
        {
            texto.GetComponent<Text>().color = Color.red;
        }
        if (spriteSheetName == "Carol")
        {
            texto.GetComponent<Text>().color = new Color32(249, 2, 249, 255);
        }
        if (spriteSheetName == "Jenifer")
        {
            texto.GetComponent<Text>().color = new Color32(232, 130, 26, 255);
        }

    }
}
