using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Movement_Func : MonoBehaviour
{
    public abstract void MoveFunction(float s, CharacterController c);
}
