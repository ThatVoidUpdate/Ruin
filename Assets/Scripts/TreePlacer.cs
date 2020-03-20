using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreePlacer : ObjectPlacer
{
    public TreeType type;
    public Tree TreePrefab;

    List<Vector2> placeLocations = new List<Vector2>();
    public override void PlaceObjects() 
    {
        int fails = 0;
        while (fails < MaxFailIterations)
        {
            Vector2 TestPosition = new Vector2(Random.Range(0f, Area.x), Random.Range(0f, Area.y));
            bool canPlace = true;
            foreach (Vector2 position in placeLocations)
            {
                if ((position - TestPosition).magnitude < type.MinPlaceRadius * 2)
                {
                    canPlace = false;
                    break;
                }
            }

            if (canPlace)
            {
                fails = 0;
                placeLocations.Add(TestPosition);
            }
            else
            {
                fails++;
            }
        }

        foreach (Vector2 position in placeLocations)
        {
            Tree CreatedTree = Instantiate(TreePrefab, new Vector3(position.x, transform.position.y, position.y), Quaternion.Euler(-90, 0, 0));
            CreatedTree.type = type;
        }
    }
}
