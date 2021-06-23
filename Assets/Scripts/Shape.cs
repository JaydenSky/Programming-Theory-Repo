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

    public virtual void Move()
    {

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
