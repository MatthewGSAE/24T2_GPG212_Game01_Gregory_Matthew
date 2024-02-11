using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    PlayerController playerController;

    public GameObject hammer;

    // Start is called before the first frame update
    void Start()
    {
        // Attempt to find the PlayerController script in the scene
        playerController = FindObjectOfType<PlayerController>();
    }

    private void OnTriggerStay(Collider other)
    {
        // Check if playerController is not null before using it
        if (playerController != null)
        {
            // Perform the desired action when the trigger is entered by an object with the specified tag
            Debug.Log("Player entered the trigger zone!");

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space was pressed");

                // Set the holding hammer flag in the player controller
                playerController.isHoldingHammer = true;

                // Destroy the hammer GameObject
                Destroy(hammer);

                Destroy(gameObject);
            }
        }
    }
}
