using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
    private float cubeSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        shapeColor = MainManager.Instance.secondColor;
        SetColor();
    }

    private void Update()
    {
        Move();
    }

    //POLYMORPHISM
    public override void Move()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.z < zRange)
        {
            forwardInput = 1;
            transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * cubeSpeed);
        }
        else if (Input.GetKey(KeyCode.S) && transform.position.z > -zRange)
        {
            forwardInput = -1;
            transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * cubeSpeed);
        }
        else if (Input.GetKey(KeyCode.D) && transform.position.x < xRange)
        {
            horizontalInput = 1;
            transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * cubeSpeed);
        }
        else if (Input.GetKey(KeyCode.A) && transform.position.x > -xRange)
        {
            horizontalInput = -1;
            transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * cubeSpeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SecondCapsule"))
        {
            Destroy(other.gameObject);
        }
    }
}
