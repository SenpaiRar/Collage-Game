using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelController : MonoBehaviour
{
    public Camera Maincamera;
    public GameObject PlayerObject;

    Movement PlayerMoveController;

    public List<GameObject> ListOfLevelObjects = new List<GameObject>();

    private void Start()
    {
        PlayerMoveController = PlayerObject.GetComponent<Movement>();
        SetUpNewElements(ListOfLevelObjects[0].GetComponent<ElementAdjustment>(), ListOfLevelObjects[0].GetComponent<Movement_Func>());
        StartCoroutine(Test());
    }
    
    private void SetUpNewElements(ElementAdjustment e, Movement_Func m)
    {
        e.AdjustElements(Maincamera);
        PlayerMoveController.changeMovementType(m);
    }
    private void SetUpNewElements(ElementAdjustment e)
    {
        e.AdjustElements(Maincamera);
    }
    private void SetUpNewElements(Movement_Func m)
    {
        PlayerMoveController.changeMovementType(m);
    }

    

    IEnumerator Test()
    {
        yield return new WaitForSeconds(10.0f);
        SetUpNewElements(ListOfLevelObjects[1].GetComponent<ElementAdjustment>(), ListOfLevelObjects[1].GetComponent<Movement_Func>());
    }

}
