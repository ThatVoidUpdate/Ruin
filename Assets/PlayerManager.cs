using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public List<Dude> Dudes = new List<Dude>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateTargetPosition(GameObject Target)
    {
        Debug.Log("Attempting tp update positions");
        foreach (Dude dude in Dudes)
        {
            if (dude.IsSelected)
            {
                dude.SetTarget(Target);
            }
            
        }
    }
}
