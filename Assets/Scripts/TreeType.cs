using UnityEngine;

[CreateAssetMenu(fileName = "New Tree Type", menuName = "RuinObjects/Tree Type")]
[System.Serializable]
public class TreeType : ScriptableObject
{
    public BuildingMaterial Material;
    public GameObject[] TreeModels;
    public float MinPlaceRadius;

}
