using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{
    private float sphereSpeed = 15;

    // Start is called before the first frame update
    void Start()
    {
        shapeColor = MainManager.Instance.favoriteColor;
        SetColor();
    }

    private void Update()
    {
        Move();
    }

    //POLYMORPHISM
    public override void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.z < zRange)
        {
            forwardInput = 1;
            transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * sphereSpeed);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.z > -zRange)
        {
            forwardInput = -1;
            transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * sphereSpeed);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < xRange)
        {
            horizontalInput = 1;
            transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * sphereSpeed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -xRange)
        {
            horizontalInput = -1;
            transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * sphereSpeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FavoriteCapsule"))
        {
            Destroy(other.gameObject);
        }
    }
}
