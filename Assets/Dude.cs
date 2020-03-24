using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dude : MonoBehaviour, IClickable, IHarvestable
{
    public GameObject TargetObject;
    public float Reach;
    public bool IsSelected;
    public float MovementSpeed;
    private bool AttemptedHarvest = true;

    void Start()
    {
        TargetObject = this.gameObject;
    }
    void FixedUpdate()
    {
        if (TargetObject == null)
        {
            TargetObject = this.gameObject;
            AttemptedHarvest = true;
        }

        if ((transform.position - TargetObject.transform.position).magnitude > Reach)
        {
            transform.position += (TargetObject.transform.position - transform.position).normalized * MovementSpeed;
        }
        else if (AttemptedHarvest == false)
        {
            Harvest();
        }
    }

    public void Harvest()
    {
        Destroy(TargetObject);
        AttemptedHarvest = true;
        TargetObject = this.gameObject;
    }

    public void LeftClick()
    {
        if (!IsSelected)
        {
            IsSelected = true;
        }
    }

    public void RightClick()
    {
        IsSelected = false;
    }

    public void SetTarget(GameObject _TargetObject)
    {
        TargetObject = _TargetObject;
        AttemptedHarvest = false;
    }
}
