using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using FirstCollection;

public class Tile : MonoBehaviour, IBeginDragHandler, IDragHandler, IPointerClickHandler
{
    GameManager gm;

    [SerializeField] bool canBeDraged = true;
    [SerializeField] Image _img;
    public AllowedDirection allowedDirection;

    public int Vrijednost
    {
        get => _vrijednost;
        set
        {
            _vrijednost = value;
            _img.color = gm.postavke.boje[value];
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
            gameObject.name = $"Tile {_pozicija.x} {_pozicija.y}";

        }
    }
    Vector2Int _pozicija;

    Vector2 _dragDelta;
    Vector2Int _moveDir;
    bool _firstClick;
    float _timerFistClick;


    private void Awake()
    {
        gm = GameManager.gm;
    }

    void Update()
    {
        if (!canBeDraged) return;
        if (_firstClick)
        {
            _timerFistClick += Time.deltaTime;
            if(_timerFistClick > 0.3f)
            {
                _firstClick = false;
                _timerFistClick = 0f;
            }
        }
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!canBeDraged) return;

        _dragDelta = eventData.delta;
       // print($"Float -- {_dragDelta}");
        if (allowedDirection == AllowedDirection.MiddlePoint)
        {
            if (Mathf.Abs(_dragDelta.x) > Mathf.Abs(_dragDelta.y))
            {
                _moveDir = new Vector2Int(_dragDelta.x > 0 ? 1 : -1, 0);
            }
            else if (Mathf.Abs(_dragDelta.x) < Mathf.Abs(_dragDelta.y))
            {
                _moveDir = new Vector2Int(0, _dragDelta.y > 0 ? 1 : -1);
            }
            else return;

            //  print($"INT -- {_moveDir}");
            gm.MoveWholeBoard(_moveDir);


            return;
        }

        if (Mathf.Abs(_dragDelta.x) > Mathf.Abs(_dragDelta.y))
        {
            if (allowedDirection == AllowedDirection.Vertical) return;

            _moveDir = new Vector2Int(_dragDelta.x > 0 ? 1 : -1, 0);
        }
        else if (Mathf.Abs(_dragDelta.x) < Mathf.Abs(_dragDelta.y))
        {
            if (allowedDirection == AllowedDirection.Horizontal) return;

            _moveDir = new Vector2Int(0, _dragDelta.y > 0 ? 1 : -1);
        }
        else return;

        gm.MoveTokenByPosition(_moveDir, Pozicija);

        Vector2Int oppositePosition = gm.OppositePos(_moveDir, Pozicija);
        gm.MoveTokenByPosition(-_moveDir, oppositePosition);

    }

    public void OnDrag(PointerEventData eventData)
    {
       
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (allowedDirection != AllowedDirection.MiddlePoint) return;

        if (_firstClick)
        {
            _timerFistClick = 0f;
            gm.MiddlePointActivation(Pozicija);
        }
        _firstClick = true;
    }
}
