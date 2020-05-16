using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour
{
    public Camera Maincamera;
    public GameObject PlayerObject;

    ElementAdjustment Adjustments;
    Movement PlayerMoveSchema;

    private void Start()
    {
        PlayerMoveSchema = PlayerObject.GetComponent<Movement>();
    }

    private void GetNewElements(ElementAdjustment e, Movement_Func m)
    {
        e.AdjustElements(Maincamera);
        PlayerMoveSchema.changeMovementType(m);
    }

}
