using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RemoveStoryText : MonoBehaviour
{
    public GameObject text;

    private void OnTriggerExit(Collider other)
    {
        Destroy(text);

        Destroy(gameObject);
    }
}
