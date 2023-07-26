using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour {

    public int playerCoins = 0;
    public bool hasKey = false;
    public int activeBoxes = 0;
    int boxesToActivate = 5;

    Transform playerRef;
    GameObject playerObject;
    TMP_Text coinText;
    TMP_Text boxesActivated;


    // Start is called before the first frame update
    void Start() {

        playerObject = GameObject.FindGameObjectWithTag("Player");
        coinText = GameObject.FindWithTag("Coin").GetComponent<TMP_Text>();
        boxesActivated = GameObject.FindWithTag("Actives").GetComponent<TMP_Text>();
        GameObject.FindWithTag("Key").GetComponent<Image>().enabled = false;
    }

    // Update is called once per frame
    void Update() {

        playerRef = playerObject.transform;
        coinText.text = playerCoins.ToString();
        boxesActivated.text = activeBoxes.ToString() + "/" + boxesToActivate.ToString();

        if (playerRef.position.y < -10.0f)
            LoadGameOver();

        if (hasKey)
            GameObject.FindWithTag("Key").GetComponent<Image>().enabled = true;

        if (activeBoxes == boxesToActivate && hasKey)
            GameObject.FindObjectOfType<Portal>().isOpen = true;
    }

    void LoadGameOver() {

        SceneManager.LoadScene("GameOver");
    }
}
