using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject panel;
    public GameObject text;
    public GameObject button;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Change "Player" to the tag of the object you want to trigger the end game
        {
            panel.SetActive(true);
            text.SetActive(true);
            button.SetActive(true);

            Time.timeScale = 0.1f;
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
