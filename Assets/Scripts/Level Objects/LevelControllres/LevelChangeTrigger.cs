using UnityEngine;
using System.Collections;

public class LevelChangeTrigger : MonoBehaviour
{
    public LevelController MasterController;
    [HideInInspector]
    public GameObject LevelObject;

    [HideInInspector]
    public bool LeadstoRandomLevel;
    //These two should come from the same level object.
   
    private ElementAdjustment e;
    private Movement_Func m;

    private void Start()
    {
        e = LevelObject.GetComponent<ElementAdjustment>();
        m = LevelObject.GetComponent<Movement_Func>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (LeadstoRandomLevel)
                MasterController.PickRandomLevel();
            else
            {
                MasterController.CurrentLevel = LevelObject;
            }
                
        }
    }
}
