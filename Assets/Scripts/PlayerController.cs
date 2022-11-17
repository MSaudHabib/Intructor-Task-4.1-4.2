using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public float forwardMovement;
    public float horizontalMovement;
    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        forwardMovement = Input.GetAxis("Vertical");

        horizontalMovement = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        playerRb.AddForce(Vector3.forward * speed * forwardMovement);
        
        playerRb.AddForce(Vector3.right * speed * horizontalMovement);
    }
}
