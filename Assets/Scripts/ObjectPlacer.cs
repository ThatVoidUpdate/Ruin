using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacer : MonoBehaviour
{
    public Vector2 Area;
    public int MaxFailIterations = 30;
    public virtual void PlaceObjects() { }

    public void Start()
    {
        PlaceObjects();
    }
}
