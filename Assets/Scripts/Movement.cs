using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    public CharacterController controller;
    Movement_Func move;
    public float Speed;

    void Update()
    {
        move.MoveFunction(Speed, controller);
    }

    public void changeMovementType(Movement_Func m)
    {
        move = m;
    }
}
