using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisionplayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Saya bersentuhan dengan Trigger");

        if (collision.CompareTag("Player")) {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D collision) {
        Debug.Log("Saya tetap bersentuhan dengan Triggerstay");
    }

    private void OnTriggerExit2D(Collider2D collision) {
        Debug.Log("Saya tidak lagi bersentuhan :(");
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("Saya menabrak dengan Collision");
    }

    private void OnCollisionStay2D(Collision2D collision) {
        Debug.Log("Saya tetap bertabrakan");
    }

    private void OnCollisionExit2D(Collision2D collision) {
        Debug.Log("Saya tidak bertabrakan");
    }
}
