using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    

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
