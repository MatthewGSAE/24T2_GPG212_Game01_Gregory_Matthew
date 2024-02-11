using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float movementSpeed = 1;

    public bool isHoldingHammer = false;

    public bool isUsingAbility = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from the player
        float verticalInput = Input.GetAxis("Horizontal");
        float horizontalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Move the player
        transform.Translate(moveDirection * movementSpeed * Time.deltaTime);

        Debug.Log("are yopu holding a hammer" + isHoldingHammer);

        Debug.Log("are you using your ability " + isUsingAbility);
    }
}
