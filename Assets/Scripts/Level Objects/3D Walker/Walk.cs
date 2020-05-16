using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : Movement_Func
{
    public override void MoveFunction(float s, CharacterController c)
    {
        Vector3 x = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        x *= s * Time.deltaTime;
        c.Move(x);
    }
}
