using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int speed = 20;
    private float horizontal;
    private float vertical;

    public int force = 10;

    public Rigidbody rb;
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Translate(Vector3.left * Time.deltaTime * speed * horizontal);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}
