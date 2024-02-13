using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    PlayerController playerController;

    public GameObject keyPicture;

    public GameObject axePicture;

    // Start is called before the first frame update
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();

        keyPicture.SetActive(false);
        axePicture.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.isHoldingKey == true)
        {
            keyPicture.SetActive(true);
        }

        if (playerController.isHoldingAxe == true)
        {
            axePicture.SetActive(true);
        }
    }
}
