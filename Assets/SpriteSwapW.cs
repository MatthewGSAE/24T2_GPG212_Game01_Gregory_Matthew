using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteSwapW : MonoBehaviour
{
    public Sprite normalSpriteW;

    public Sprite pressedSpriteW;

    private Image buttonImageW;
    // Start is called before the first frame update
    void Start()
    {
        buttonImageW = GetComponent<Image>();

        buttonImageW.sprite = normalSpriteW;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            buttonImageW.sprite = pressedSpriteW;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            buttonImageW.sprite = normalSpriteW;
        }
    }
}
