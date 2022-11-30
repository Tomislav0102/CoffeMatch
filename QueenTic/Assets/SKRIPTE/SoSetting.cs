using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SoSetting : ScriptableObject
{
    public int level = 1;
    public int score;
    public bool showHints;
    [Header("-=SKINS=-")]
    public int skinOrdinal;
    public List<Sprite> tileSprites, tokenSprites;
}
