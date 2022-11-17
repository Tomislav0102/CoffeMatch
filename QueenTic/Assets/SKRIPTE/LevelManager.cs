using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FirstCollection;

public class LevelManager : MonoBehaviour
{
    GameManager gm;
    [SerializeField] SO_postavke postavke;
    [SerializeField] HintDirection[] hintOrder;
    int[,] _tilesVrijednosti = new int[3, 3];
    int[,] _tokensVrijednosti = new int[3, 3];
    [HideInInspector] public int tiles02, tiles12, tiles22, tiles01, tiles11, tiles21, tiles00, tiles10, tiles20;
    [HideInInspector] public int tokens02, tokens12, tokens22, tokens01, tokens11, tokens21, tokens00, tokens10, tokens20;
    private void Awake()
    {
        gm = GameManager.gm;
        gm.levelManager = this;
    }
    private void Start()
    {
        _tilesVrijednosti[0, 0] = tiles00;
        _tilesVrijednosti[1, 0] = tiles10;
        _tilesVrijednosti[2, 0] = tiles20;
        _tilesVrijednosti[0, 1] = tiles01;
        _tilesVrijednosti[1, 1] = tiles11;
        _tilesVrijednosti[2, 1] = tiles21;
        _tilesVrijednosti[0, 2] = tiles02;
        _tilesVrijednosti[1, 2] = tiles12;
        _tilesVrijednosti[2, 2] = tiles22;

        _tokensVrijednosti[0, 0] = tokens00;
        _tokensVrijednosti[1, 0] = tokens10;
        _tokensVrijednosti[2, 0] = tokens20;
        _tokensVrijednosti[0, 1] = tokens01;
        _tokensVrijednosti[1, 1] = tokens11;
        _tokensVrijednosti[2, 1] = tokens21;
        _tokensVrijednosti[0, 2] = tokens02;
        _tokensVrijednosti[1, 2] = tokens12;
        _tokensVrijednosti[2, 2] = tokens22;

        gm.NewGameBoard(_tilesVrijednosti, _tokensVrijednosti, hintOrder);
    }
}
