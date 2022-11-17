using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LevelManager))]
public class CustomEditorManager : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        LevelManager lm = (LevelManager)target;
        EditorUtility.SetDirty(lm); 
        GUILayout.Space(20);
        GUILayout.Label("Start Positions");
        GUILayout.Space(10);

        GUILayout.Label("Tiles");
        GUILayout.BeginHorizontal();
        GUILayout.Space(10);
        lm.tiles02 = EditorGUILayout.IntField(lm.tiles02, GUILayout.MaxWidth(30f));
        lm.tiles12 = EditorGUILayout.IntField(lm.tiles12, GUILayout.MaxWidth(30f));
        lm.tiles22 = EditorGUILayout.IntField(lm.tiles22, GUILayout.MaxWidth(30f));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Space(10);
        lm.tiles01 = EditorGUILayout.IntField(lm.tiles01, GUILayout.MaxWidth(30f));
        lm.tiles11 = EditorGUILayout.IntField(lm.tiles11, GUILayout.MaxWidth(30f));
        lm.tiles21 = EditorGUILayout.IntField(lm.tiles21, GUILayout.MaxWidth(30f));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Space(10);
        lm.tiles00 = EditorGUILayout.IntField(lm.tiles00, GUILayout.MaxWidth(30f));
        lm.tiles10 = EditorGUILayout.IntField(lm.tiles10, GUILayout.MaxWidth(30f));
        lm.tiles20 = EditorGUILayout.IntField(lm.tiles20, GUILayout.MaxWidth(30f));
        GUILayout.EndHorizontal();
        GUILayout.Space(10);

        GUILayout.Label("Tokens");
        GUILayout.BeginHorizontal();
        GUILayout.Space(10);
        lm.tokens02 = EditorGUILayout.IntField(lm.tokens02, GUILayout.MaxWidth(30f));
        lm.tokens12 = EditorGUILayout.IntField(lm.tokens12, GUILayout.MaxWidth(30f));
        lm.tokens22 = EditorGUILayout.IntField(lm.tokens22, GUILayout.MaxWidth(30f));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Space(10);
        lm.tokens01 = EditorGUILayout.IntField(lm.tokens01, GUILayout.MaxWidth(30f));
        lm.tokens11 = EditorGUILayout.IntField(lm.tokens11, GUILayout.MaxWidth(30f));
        lm.tokens21 = EditorGUILayout.IntField(lm.tokens21, GUILayout.MaxWidth(30f));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Space(10);
        lm.tokens00 = EditorGUILayout.IntField(lm.tokens00, GUILayout.MaxWidth(30f));
        lm.tokens10 = EditorGUILayout.IntField(lm.tokens10, GUILayout.MaxWidth(30f));
        lm.tokens20 = EditorGUILayout.IntField(lm.tokens20, GUILayout.MaxWidth(30f));
        GUILayout.EndHorizontal();


        //for (int j = 0; j < 3; j++)
        //{
        //    GUILayout.Space(30);
        //    GUILayout.BeginHorizontal();
        //    for (int i = 0; i < 3; i++)
        //    {
        //        EditorGUILayout.IntField(lm.brojevi[i, j]);
        //    }
        //    GUILayout.EndHorizontal();
        //}
    }
}
