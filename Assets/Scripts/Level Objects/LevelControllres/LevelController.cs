using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelController : MonoBehaviour
{
    public Camera Maincamera;
    public GameObject PlayerObject;
    public GameObject FirstLevel;
    
    private GameObject currentLevel;
    public GameObject CurrentLevel
    {
        get
        {
            return currentLevel;
        }
        set
        {
            Debug.Log("Level has Changed!");
            currentLevel = value;
            SetUpNewElements(value.GetComponent<ElementAdjustment>(), value.GetComponent<Movement_Func>(), value.GetComponent<LevelElementAdjustor>());
        }
    }

    Movement PlayerMoveController;

    public List<GameObject> ListOfLevelObjects = new List<GameObject>();

    private void Start()
    {
        PlayerMoveController = PlayerObject.GetComponent<Movement>();
        CurrentLevel = FirstLevel;
        
    }

    /// <summary>
    /// Takes in changes to level elements and control schemas and applies them.
    /// </summary>
    public void SetUpNewElements(ElementAdjustment e, Movement_Func m, LevelElementAdjustor l)
    {
        l.SetupLevel();
        e.AdjustElements(Maincamera);
        PlayerMoveController.changeMovementType(m);
    }
    public void SetUpNewElements(ElementAdjustment e, Movement_Func m)
    {
        e.AdjustElements(Maincamera);
        PlayerMoveController.changeMovementType(m);
    }
    public void SetUpNewElements(ElementAdjustment e)
    {
        e.AdjustElements(Maincamera);
    }
    public void SetUpNewElements(Movement_Func m)
    {
        PlayerMoveController.changeMovementType(m);
    }
    /// <summary>
    /// Picks and assigns a random Element and movement pair.
    /// </summary>
    public void PickRandomLevel()
    {
        int rand = Random.Range(0, ListOfLevelObjects.Count);
        CurrentLevel = ListOfLevelObjects[rand];
    }
    

}
