using UnityEngine;
using System.Collections;

public class ThreeDElementAdjust : ElementAdjustment
{
    public override void AdjustElements(Camera c)
    {
        c.transform.parent = GameObject.FindGameObjectWithTag("Player").transform;
        c.transform.localPosition = new Vector3(0, 2.5f, -2.59f);
        c.transform.rotation = Quaternion.Euler(29, 0, 0);
        c.orthographic = false;
    }
}
