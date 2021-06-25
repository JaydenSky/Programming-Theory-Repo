using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    public MeshRenderer Renderer;

    void Start()
    {
        SetCapsuleColor();
    }

    private void SetCapsuleColor()
    {
        if (tag == "FavoriteCapsule")
        {
            SetColor(MainManager.Instance.favoriteColor);
        }
        else if (tag == "SecondCapsule")
        {
            SetColor(MainManager.Instance.secondColor);
        }
    }

    //ABSTRACTION
    private void SetColor(string color)
    {
        if (color == "Red")
        {
            Renderer.material.color = new Color(202, 0, 0);
        }
        else if (color == "Blue")
        {
            Renderer.material.color = new Color(0, 0, 202);
        }
        else if (color == "Green")
        {
            Renderer.material.color = new Color(0, 202, 0);
        }
    }
}
