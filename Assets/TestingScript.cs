using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingScript : MonoBehaviour
{
    public TreePlacer trees;
    // Start is called before the first frame update
    void Start()
    {
        trees.PlaceObjects();
    }
}
