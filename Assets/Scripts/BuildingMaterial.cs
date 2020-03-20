using UnityEngine;

[CreateAssetMenu(fileName = "New Building Material", menuName = "RuinObjects/Building Material")]
[System.Serializable]
public class BuildingMaterial : ScriptableObject
{
    public Material Material;
    public GameObject Source;
}
