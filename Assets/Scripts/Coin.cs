using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    float rotationSpeed = 8.0f;
    // AudioSource audioSource;?

    void Start() {
        // audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        
        transform.Rotate(Vector3.up * rotationSpeed, Space.World);
    }

    void OnTriggerEnter(Collider collider) {
        
            // audioSource.Play();
        if (collider.tag == "Player") {
            GameObject.FindObjectOfType<GameManager>().playerCoins++;
            this.gameObject.GetComponent<AudioSource>();
            Destroy(this.gameObject);
        }

    }
}
