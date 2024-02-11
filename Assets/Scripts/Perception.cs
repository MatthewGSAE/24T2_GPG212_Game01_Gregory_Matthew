using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perception : MonoBehaviour
{
    // Public variable for the flash material (assigned in the Unity Editor)
    public Material flashMaterial;

    // Variables for the original material and renderer
    private Material originalMaterial;
    private Renderer rend;

    // Duration of the fade effect
    public float fadeDuration = 0.5f;

    // Flag to prevent overlapping flashes
    private bool isFlashing = false;

    void Start()
    {
        // Get the renderer component and store the original material
        rend = GetComponent<Renderer>();
        originalMaterial = new Material(rend.material); // Create a copy of the original material
    }

    void Update()
    {
        // Check for input to trigger the flash (you can change the condition based on your trigger)
        if (Input.GetKeyDown(KeyCode.Tab) && !isFlashing)
        {
            // Start the flash coroutine
            StartCoroutine(FlashAndRevert());
        }
    }

    IEnumerator FlashAndRevert()
    {
        // Set the flag to prevent overlapping flashes
        isFlashing = true;

        // Variables for lerping colors during the fade
        float elapsedTime = 0f;
        Color originalColor = originalMaterial.color;
        Color flashColor = flashMaterial.color;

        // Fade in (original to flash)
        while (elapsedTime < fadeDuration)
        {
            rend.material.color = Color.Lerp(originalColor, flashColor, elapsedTime / fadeDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Set the material to the flash material
        rend.material = flashMaterial;

        // Wait for a specified time (adjust as needed for the flash duration)
        yield return new WaitForSeconds(0.5f);

        // Reset elapsed time for the fade out
        elapsedTime = 0f;

        // Fade out (flash to original)
        while (elapsedTime < fadeDuration)
        {
            rend.material.color = Color.Lerp(flashColor, originalColor, elapsedTime / fadeDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Restore the original material
        rend.material = originalMaterial;

        // Reset the flag to allow for the next flash
        isFlashing = false;
    }
}