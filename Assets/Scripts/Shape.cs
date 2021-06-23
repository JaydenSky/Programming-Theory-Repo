using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public string shapeColor;

    public MeshRenderer Renderer;

    private void Start()
    {
        
    }

    public virtual void Move()
    {

    }

    public void SetColor()
    {
        if (shapeColor == "Red")
        {
            Renderer.material.color = new Color(202, 0, 0);
        }
        else if (shapeColor == "Blue")
        {
            Renderer.material.color = new Color(0, 0, 202);
        }
        else if (shapeColor == "Green")
        {
            Renderer.material.color = new Color(0, 202, 0);
        }
    }
}
