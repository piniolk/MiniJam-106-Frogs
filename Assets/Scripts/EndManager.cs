using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour {
    public GameObject uiObj;
    public GameObject endObj;


    public void ActivateEnd() {
        endObj.SetActive(true);
        StartCoroutine(StartEnd());

    }

    IEnumerator StartEnd() {

        Time.timeScale = 0;

        yield return new WaitForSeconds(1);
    }

    public void TitleScreen() {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
