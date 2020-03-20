using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
[RequireComponent(typeof(MeshFilter))]
public class Tree : MonoBehaviour
{
    public TreeType type;
    private Renderer rend;
    private GameObject obj;
    private MeshFilter filter;

    void Start()
    {
        rend = GetComponent<Renderer>();
        filter = GetComponent<MeshFilter>();
        obj = type.TreeModels[Random.Range(0, type.TreeModels.Length)];
        filter.mesh = obj.GetComponent<MeshFilter>().sharedMesh;
        rend.material = type.Material.Material;
        transform.localScale = obj.transform.localScale;
        transform.rotation = Quaternion.Euler(-90, Random.Range(0, 360), 0);
    }
}
