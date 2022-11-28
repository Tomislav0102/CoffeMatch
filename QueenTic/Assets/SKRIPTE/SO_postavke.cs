using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class So_Postavke : ScriptableObject
{
    public int level = 1;
    public int score;
    public bool showHints;
    public Color[] boje;
    [Header("-=SKINS=-")]
    [Range(0, 1)] public int skinOrdinal;
    public List<Sprite> tileSprites, tokenSprites;

}
