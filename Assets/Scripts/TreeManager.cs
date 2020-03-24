using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManager : MonoBehaviour
{
    public PlayerManager playerManager;
    List<GameObject> Trees = new List<GameObject>();
    public void AddTree(GameObject tree)
    {
        Trees.Add(tree);
        tree.GetComponent<Tree>().RightClickEvent.AddListener(delegate{playerManager.UpdateTargetPosition(tree);});
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
