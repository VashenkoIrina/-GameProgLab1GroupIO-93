using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public float jump = 5.0f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRb;
    // Horizontal Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

    }

    // Vertical Update is called once per frame
    void Update()
    {
        //get player
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move the player
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        //Jump the player
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * jump, ForceMode.Impulse);
        }
    }
}
