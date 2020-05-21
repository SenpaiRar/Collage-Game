using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Contains the code adjusting the various elements in the level.
/// </summary>
[ExecuteInEditMode]
public abstract class ElementAdjustment : MonoBehaviour
{
    public abstract void AdjustElements(Camera c);
}
