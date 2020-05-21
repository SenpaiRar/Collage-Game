using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Contains the code behind a player's movement
/// </summary>
public abstract class Movement_Func : MonoBehaviour
{
    public abstract void MoveFunction(float s, CharacterController c);
}
