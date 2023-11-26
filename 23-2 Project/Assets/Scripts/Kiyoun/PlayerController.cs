using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rigid;
    private float moveForce = 7.0f;
    private float horizontal;
    private float vertical;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        //rotate the player according to the
        transform.Rotate(0, horizontal, 0);
        //move the player without using rigidbody
        transform.Translate(0, 0, vertical * moveForce * Time.deltaTime);
    }
}