using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteSwapS : MonoBehaviour
{
    public Sprite normalSpriteS;

    public Sprite pressedSpriteS;

    private Image buttonImageS;
    // Start is called before the first frame update
    void Start()
    {
        buttonImageS = GetComponent<Image>();

        buttonImageS.sprite = normalSpriteS;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            buttonImageS.sprite = pressedSpriteS;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            buttonImageS.sprite = normalSpriteS;
        }
    }
}
