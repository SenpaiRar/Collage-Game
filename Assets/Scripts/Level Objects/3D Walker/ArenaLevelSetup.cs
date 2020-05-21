using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaLevelSetup : LevelElementAdjustor
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
