using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Camera))]
public class MouseSelect : MonoBehaviour
{

    public GameObjectEvent ItemSelect;

    private Ray ray;
    private RaycastHit hit;
    private Camera camera;

    void Start()
    {
        camera = GetComponent<Camera>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                print("Clicked on " + hit.collider.name);
                ItemSelect.Invoke(hit.collider.gameObject);
            }
        }
    }
}
