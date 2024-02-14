using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteSwapD : MonoBehaviour
{
    public Sprite normalSpriteD;

    public Sprite pressedSpriteD;

    private Image buttonImageD;
    // Start is called before the first frame update
    void Start()
    {
        buttonImageD = GetComponent<Image>();

        buttonImageD.sprite = normalSpriteD;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            buttonImageD.sprite = pressedSpriteD;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            buttonImageD.sprite = normalSpriteD;
        }
    }
}
