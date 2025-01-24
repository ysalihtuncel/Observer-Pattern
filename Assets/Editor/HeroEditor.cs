using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Hero))]
public class HeroEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Hero hero = (Hero) target;
        
        if (GUILayout.Button("Increase Health"))
        {
            hero.Health.Value += 10;
        }
        if (GUILayout.Button("Decrease Health"))
        {
            hero.Health.Value -= 10;
        }
    }
}
