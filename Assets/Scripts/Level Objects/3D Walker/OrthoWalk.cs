using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrthoWalk : Movement_Func
{


    public override void MoveFunction(float s, CharacterController c)
    {
        Vector3 x = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        x *= s * Time.deltaTime;
        c.Move(x);
    }
}
