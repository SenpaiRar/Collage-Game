using UnityEngine;
using System.Collections;

public class OrthographicWalker : ElementAdjustment
{
    public override void AdjustElements(Camera c)
    {
        c.orthographic = true;
        c.transform.parent = null;
        c.transform.position = new Vector3(-9, 7.5f, -8.94f);
        c.transform.rotation = Quaternion.Euler(47, 44, 0);
    }
}
