using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class OpenGate : MonoBehaviour
{
    PlayerController playerController;

    public GameObject gate;
    // Start is called before the first frame update
    void Start()
    {
        // Attempt to find the PlayerController script in the scene
        playerController = FindObjectOfType<PlayerController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (playerController.isHoldingKey == true)
        {
            Destroy(gate);
        }
    }
}
