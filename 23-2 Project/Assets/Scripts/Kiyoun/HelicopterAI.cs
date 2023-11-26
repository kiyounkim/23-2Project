using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterAI : MonoBehaviour
{
    public Vector3[] positions = new Vector3[8];
    Vector3 position;
    public float rotationSpeed;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        SetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if(transform.position == position){
            SetPosition();
        }
    }

    void SetPosition(){
        position = positions[Random.Range(0, positions.Length)];
    }

    void Move(){
        transform.position = Vector3.MoveTowards(transform.position, position, speed/100);
        Vector3 direction = position - transform.position;
        if (direction != Vector3.zero) {
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
        }
    }
}
