using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.Escape))
            QuitGame();
    
        else if (Input.GetKeyDown(KeyCode.Backspace))
            LoadMenu();
    }

    void LoadMenu() {

        Debug.Log("LoadMenu() called...");
        SceneManager.LoadScene("Menu");
    }

    void QuitGame() {

        Debug.Log("QuitGame() called...");
        Application.Quit();
    }
}
