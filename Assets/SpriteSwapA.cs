using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteSwapA : MonoBehaviour
{
    public Sprite normalSpriteA;

    public Sprite pressedSpriteA;

    private Image buttonImageA;
    // Start is called before the first frame update
    void Start()
    {
        buttonImageA = GetComponent<Image>();

        buttonImageA.sprite = normalSpriteA;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            buttonImageA.sprite = pressedSpriteA;
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            buttonImageA.sprite = normalSpriteA;
        }
    }
}
