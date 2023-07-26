using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {
    
    public bool isOpen = false;
    
    void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.tag == "Player" && isOpen) {

            SceneManager.LoadScene("Victory");
        }
    }
}
