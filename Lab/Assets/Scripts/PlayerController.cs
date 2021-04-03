using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerRb;
    private float speed = 10.0f;
    private float zBound = 24f;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }
 
    void Update()
    {
        MovePlayer();
        ConstrainPlayerPosition();

    }

    // Moves the player based on arrow key input 
    void MovePlayer()
    {

        float horizonatalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizonatalInput);
    }

    // Prevent the player from leaving the botom of the screen
    void ConstrainPlayerPosition()
    {
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
    }
}


