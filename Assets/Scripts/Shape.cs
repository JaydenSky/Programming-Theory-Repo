using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    private string m_shapeColor;

    //ENCAPSULATION
    public string shapeColor
    {
        get { return m_shapeColor; }
        set
        {
            if (value == "Red" || value == "Blue" || value == "Green")
            {
                m_shapeColor = value;
            }
            else
            {
                Debug.LogError("An invalid color, " + value + ", was put in");
            }
        }
    }

    public MeshRenderer Renderer;

    protected float xRange = 14;
    protected float zRange = 5;

    protected float horizontalInput;
    protected float forwardInput;
    private float speed = 10;

    public virtual void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.z < zRange)
        {
            forwardInput = 1;
            transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.z > -zRange)
        {
            forwardInput = -1;
            transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * speed);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < xRange)
        {
            horizontalInput = 1;
            transform.Translate(Vector3.forward * Time.deltaTime * horizontalInput * speed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -xRange)
        {
            horizontalInput = -1;
            transform.Translate(Vector3.forward * Time.deltaTime * horizontalInput * speed);
        }
    }

    public void SetColor()
    {
        if (m_shapeColor == "Red")
        {
            Renderer.material.color = new Color(202, 0, 0);
        }
        else if (m_shapeColor == "Blue")
        {
            Renderer.material.color = new Color(0, 0, 202);
        }
        else if (m_shapeColor == "Green")
        {
            Renderer.material.color = new Color(0, 202, 0);
        }
    }
}
