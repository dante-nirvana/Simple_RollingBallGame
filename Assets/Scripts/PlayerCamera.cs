using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    // GameObject playerChar;
    public Transform playerRef;
    Vector3 camOffset;

    // Start is called before the first frame update
    void Start()
    {
        // First get player's GameObject
        // playerChar = GameObject.FindGameObjectWithTag("Player");
        // With that get the player's component 'Transform'
        // playerRef = playerChar.GetComponent<Transform>();
        // Then use it to find the difference between the cam pos. and player's pos.
        camOffset = playerRef.position - this.transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        // And finally update cam pos. once per frame
        this.transform.position = playerRef.transform.position - camOffset;
    }
}
