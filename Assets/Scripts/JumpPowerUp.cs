using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerUp : MonoBehaviour {
    float rotationSpeed = 8.0f;

    void FixedUpdate() {

        transform.Rotate(Vector3.up * rotationSpeed, Space.World);
    }

    void OnTriggerEnter(Collider collider) {

        if (collider.tag == "Player") {
            
            collider.GetComponent<PlayerControler>().jumpForce += 3;
            Destroy(this.gameObject);
        }
    }
}
