using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerZone : MonoBehaviour
{
    PlayerController playerController;

    public GameObject door;

    public GameObject plank;

    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        // Attempt to find the PlayerController script in the scene
        playerController = FindObjectOfType<PlayerController>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (playerController.isHoldingHammer)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                playerController.isHoldingHammer = false;

                Destroy(door);

                Destroy(plank);

                Destroy(wall);

                Destroy(gameObject);
            }
        }
    }
}
