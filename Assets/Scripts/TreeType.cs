using UnityEngine;

[CreateAssetMenu(fileName = "New Tree Type", menuName = "RuinObjects/TreeType")]
[System.Serializable]
public class TreeType : ScriptableObject
{
    public BuildingMaterial Material;
    public GameObject[] TreeModels;

}
