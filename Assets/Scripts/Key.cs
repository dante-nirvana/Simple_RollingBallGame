using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    float rotationSpeed = 8.0f;


    void FixedUpdate() {
        
        transform.Rotate(Vector3.up * rotationSpeed, Space.World);
    }

    void OnTriggerEnter(Collider collider) {
        
        if (collider.tag == "Player") {

            GameObject.FindObjectOfType<GameManager>().hasKey = true;
            Destroy(this.gameObject);
        }
    }
}
