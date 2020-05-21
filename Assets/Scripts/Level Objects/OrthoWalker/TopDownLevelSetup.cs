using UnityEngine;
using System.Collections;

public class TopDownLevelSetup : LevelElementAdjustor
{
    public LevelData Data;

    private void Start()
    {
        Data = this.GetComponent<LevelDataComponent>().LD;
    }

    public override void SetupLevel()
    {
       
    }
}
