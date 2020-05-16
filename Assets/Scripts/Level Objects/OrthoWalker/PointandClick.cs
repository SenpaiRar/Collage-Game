using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointandClick : Movement_Func
{

    Vector3 target;
    public override void MoveFunction(float s, CharacterController c)
    {
        RaycastHit hit;
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            Physics.Raycast(ray, out hit);
            target = hit.point;
        }
        
        c.transform.position = Vector3.MoveTowards(c.transform.position, target, 0.5f);
    }
}
