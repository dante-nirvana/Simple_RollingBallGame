using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public bool isActive = false;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.tag == "Player" && !isActive) {
            audioSource.Play();
            isActive = true;
            GameObject.FindObjectOfType<GameManager>().activeBoxes++;
            GetComponent<MeshRenderer>().material.color = Color.cyan;
        }
    }
}
