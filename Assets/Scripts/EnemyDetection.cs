using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    // Assuming you have a reference to the player GameObject
    public GameObject playerGameObject;

    private PlayerController playerController;
    private float moveSpeed = 1f;

    private bool gettingPlayer = false;

    private void Start()
    {
        // Ensure playerGameObject is assigned and has a PlayerController component
        if (playerGameObject != null)
        {
            playerController = playerGameObject.GetComponent<PlayerController>();
        }
        else
        {
            Debug.LogError("Player GameObject reference is not assigned in the Unity Editor.");
        }
    }

    private void Update()
    {
        if (gettingPlayer)
        {
            EndGame();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay");

        if (playerController != null && playerController.isUsingAbility)
        {
            MoveTowardsPlayer();
            gettingPlayer = true;
            Debug.Log("Chasing player");
        }
    }


    void MoveTowardsPlayer()
    {
        // Calculate the direction from the enemy to the player
        Vector3 directionToPlayer = playerController.transform.position - transform.position;

        // Normalize the direction vector to maintain constant speed
        directionToPlayer.Normalize();

        // Move the enemy towards the player
        transform.Translate(directionToPlayer * moveSpeed * Time.deltaTime);
    }

    void EndGame()
    {
        Time.timeScale = 0.5f;
    }
}
