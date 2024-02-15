using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutTree : MonoBehaviour
{
    PlayerController playerController;

    public GameObject tree;
    // Start is called before the first frame update
    void Start()
    {
        // Attempt to find the PlayerController script in the scene
        playerController = FindObjectOfType<PlayerController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (playerController.isHoldingAxe == true)
        {
            Destroy(tree);
        }
    }
}