using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignBuildingMaterial : MonoBehaviour
{
    public BuildingMaterial buildingMaterial;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    public void Assign(BuildingMaterial _buildingMaterial)
    {
        buildingMaterial = _buildingMaterial;
        rend.material = buildingMaterial.Material;
    }
}
