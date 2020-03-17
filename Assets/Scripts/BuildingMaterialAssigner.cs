using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingMaterialAssigner : MonoBehaviour
{
    public BuildingMaterial material;

    public void Assign(GameObject Assignee)
    {
        AssignBuildingMaterial script = Assignee.GetComponent<AssignBuildingMaterial>();
        if (script != null)
        {
            script.Assign(material);
        }
    }
}
