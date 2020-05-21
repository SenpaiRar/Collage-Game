using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LevelChangeTrigger))]

public class NewMonoBehaviour : Editor
{
    public override void OnInspectorGUI()
    {

        base.OnInspectorGUI();

        LevelChangeTrigger l = (LevelChangeTrigger)target;

        l.LeadstoRandomLevel = EditorGUILayout.Toggle("Leads to Random Lev.", l.LeadstoRandomLevel);

        if (!l.LeadstoRandomLevel)
        {
               
         l.LevelObject = (GameObject)EditorGUILayout.ObjectField("Level Object", l.LevelObject, typeof(GameObject), true);
            
        }
    }
}
