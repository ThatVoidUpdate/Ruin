using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManager : MonoBehaviour
{
    List<GameObject> Trees = new List<GameObject>();
    public void AddTree(GameObject tree)
    {
        Trees.Add(tree);
    }

    public void ClearTrees()
    {
        foreach (GameObject tree in Trees)
        {
            Destroy(tree);
        }
        Trees.Clear();
    }
}
