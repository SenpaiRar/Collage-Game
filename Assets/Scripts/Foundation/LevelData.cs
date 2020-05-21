using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level_Data")]
public class LevelData : ScriptableObject
{

    /// <summary>
    /// Contains list of enemies to spawn.
    /// </summary>
    public List<GameObject> EnemyList;
    /// <summary>
    /// Contains list of non-enemies to spawn (health pick ups, coins, etc.)
    /// </summary>
    public List<GameObject> EntityList;
    /// <summary>
    /// List of level elements (floors, platforms, etc.)
    /// </summary>
    public List<GameObject> LevelElements;
    /// <summary>
    /// The type of the movement the level will be using
    /// </summary>

}
