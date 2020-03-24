using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshCollider))]
public class Tree : MonoBehaviour, IClickable
{
    public TreeType type;
    private Renderer rend;
    private GameObject obj;
    private MeshFilter filter;
    private MeshCollider collider;

    void Start()
    {
        rend = GetComponent<Renderer>();
        filter = GetComponent<MeshFilter>();
        collider = GetComponent<MeshCollider>();
        obj = type.TreeModels[Random.Range(0, type.TreeModels.Length)];
        filter.mesh = obj.GetComponent<MeshFilter>().sharedMesh;
        rend.material = type.Material.Material;
        transform.localScale = obj.transform.localScale;
        transform.rotation = Quaternion.Euler(-90, Random.Range(0, 360), 0);
        collider.sharedMesh = obj.GetComponent<MeshFilter>().sharedMesh;
    }

    public void LeftClick()
    {
        Debug.Log("Left clicked on tree of type " + type.name);
    }

    public void RightClick()
    {
        Debug.Log("Right clicked on tree of type " + type.name);
    }
}
