using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableFloor : MonoBehaviour
{
    int healthPoints = 3;
    
    // Update is called once per frame
    void Update()
    {
        ChangeColor();
        if (healthPoints <= 0)
            BreakFloor();
    }

    void BreakFloor() {
        Destroy(this.gameObject);
    }

    void TakeDamage() {
        healthPoints--;
    }

    void OnCollisionExit(Collision collision) {
        if (collision.gameObject.tag == "Player")
            TakeDamage();
    }

    void ChangeColor() {
        if (this.healthPoints == 2)
            GetComponent<MeshRenderer>().material.color = new Color(0.5f, 0f, 0f);
        else if (this.healthPoints < 2)
            GetComponent<MeshRenderer>().material.color = new Color(0.95f, 0f, 0f);
    }
}
