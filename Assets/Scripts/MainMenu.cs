using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {
    public GameObject titleThings;
    public GameObject controlsThings;

    public void StartGame() {
        Debug.Log("Play");
        SceneManager.LoadScene(1);
    }

    public void Controls() {
        controlsThings.SetActive(true);
        titleThings.SetActive(false);
    }

    public void ControlsClose() {
        controlsThings.SetActive(false);
        titleThings.SetActive(true);
    }

    public void QuitGame() {
        Debug.Log("Quit");
        Application.Quit();
    }
}
