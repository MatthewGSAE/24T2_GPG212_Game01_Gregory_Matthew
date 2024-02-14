using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveTutorialText : MonoBehaviour
{
    public GameObject tutorial;

    private void OnTriggerEnter(Collider other)
    {
        tutorial.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(tutorial);

        Destroy(gameObject);
    }
}
