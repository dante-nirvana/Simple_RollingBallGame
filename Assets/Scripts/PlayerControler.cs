using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    float movementSpeed = 10.0f;
    public float jumpForce = 8.0f;
    bool isFloor = false;
    Rigidbody rigBody;
    AudioSource audioCollectible;

    // Start is called before the first frame update
    void Start() {

        rigBody = GetComponent<Rigidbody>();
        rigBody.mass = 1.2f;
        audioCollectible = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {

        Move();
        if (Input.GetKeyDown(KeyCode.Space) && isFloor)
            Jump();
    }

    // Makes the character move on horizontal and vertical axis (X and Z)
    void Move() {

        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalMove, 0, verticalMove);

        rigBody.AddForce(movement * movementSpeed);
    }

    // Makes the character jump
    void Jump() {

        rigBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    void OnCollisionStay(Collision collision) {
        
        if (collision.gameObject.tag == "Floor")
            isFloor = true;
    }
    
    void OnCollisionExit(Collision collision) {

        isFloor = false;
    }

    void OnTriggerEnter(Collider collider) {

        if (collider.tag == "Collectible")
            audioCollectible.Play();
    }
}
