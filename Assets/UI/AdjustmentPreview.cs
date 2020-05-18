using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ElementAdjustment), true)]

public class AdjustmentPreview : Editor
{
    public override void OnInspectorGUI()
    {
        
        ElementAdjustment a = (ElementAdjustment)target;
        if (GUILayout.Button("AdjustElements"))
        {
            a.AdjustElements(Camera.main);
        }
    }
}
