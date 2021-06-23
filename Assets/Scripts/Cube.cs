using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    protected Color color;

    // Start is called before the first frame update
    void Start()
    {
        shapeColor = MainManager.Instance.secondColor;
        SetColor();
    }

    public override void Move()
    {

    }
}
