using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using FirstCollection;
using UnityEngine.UI;

public class Token : MonoBehaviour
{
    GameManager gm;
    [SerializeField] Image[] images;
    public int Vrijednost
    {
        get => _vrijednost;
        set
        {
            _vrijednost = value;
            GetImage(_vrijednost);
        }
    }
    int _vrijednost;

    //public int Ordinal
    //{
    //    get => _ordinal;
    //    set
    //    {
    //        _ordinal = value;
    //    }
    //}
    //int _ordinal;

    public Vector2Int Pozicija
    {
        get => _pozicija;
        set
        {
            _pozicija = value;
            gameObject.name = $"Token {_pozicija.x} {_pozicija.y}";
        }
    }
    Vector2Int _pozicija;


    private void Awake()
    {
        gm = GameManager.gm;
    }

    void GetImage(int vr)
    {
        for (int i = 0; i < images.Length; i++)
        {
            images[i].enabled = false;
        }
        images[vr].enabled = true; 
    }

}
