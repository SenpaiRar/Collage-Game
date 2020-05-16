using UnityEngine;
using System.Collections;

public class OrthographicWalker : ElementAdjustment
{
    public override void AdjustElements(Camera c)
    {
        c.orthographic = true;
    }
}
