using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TreePlacer : ObjectPlacer
{
    public TreeType type;
    public Tree TreePrefab;

    public GameObjectEvent AddTree;

    List<Vector2> placeLocations;
    public override void PlaceObjects() 
    {
        placeLocations = new List<Vector2>();
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

        StartCoroutine(PlaceTrees());
        
    }

    public IEnumerator PlaceTrees()
    {
        foreach (Vector2 position in placeLocations)
        {
            Tree CreatedTree = Instantiate(TreePrefab, new Vector3(position.x, transform.position.y, position.y), Quaternion.Euler(-90, 0, 0));
            CreatedTree.type = type;
            AddTree.Invoke(CreatedTree.gameObject);
        }
        yield return new WaitForSeconds(0);
    }

    public void Changetype(TreeType _type)
    {
        type = _type;
    }
}
