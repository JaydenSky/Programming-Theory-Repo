using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    protected Color color;

    // Start is called before the first frame update
    void Start()
    {
        shapeColor = MainManager.Instance.favoriteColor;
        SetColor();
    }

    public override void Move()
    {
        
    }
}
