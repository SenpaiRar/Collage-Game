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
            
            if (hit.collider.CompareTag("Level"))
            {
                target = hit.point;
            }
            else
            {
                //Do Nothing
            }
        }
        Vector3 x = new Vector3(target.x, target.y + 0.5f, target.z);
        c.transform.position = Vector3.MoveTowards(c.transform.position, x, 0.5f);
    }
}
