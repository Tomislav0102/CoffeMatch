using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstCollection
{
    public class HelperScript 
    {
        public static System.Action<int> LevelFinished;
        public Vector3 MousePoz(Camera cam, LayerMask lay)
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100f, lay))
            {
                return hit.point;
            }
            else return Vector3.zero;
        }

        public static T[] GetAllChildernByType<T>(Transform par)
        {
            T[] tip = new T[par.childCount];
            for (int i = 0; i < par.childCount; i++)
            {
                tip[i] = par.GetChild(i).GetComponent<T>();
            }
            return tip;
        }


    }
    public enum MainType
    {
        Tile,
        Token
    }
    public enum AllowedDirection
    {
        All,
        Horizontal,
        Vertical,
        MiddlePoint
    }
    public enum HintDirection
    {
        UpSwipe,
        RightSwipe,
        DownSwipe,
        LeftSwipe,
        YYdoubleTap,
        None
    }

}
