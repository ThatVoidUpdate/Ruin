using UnityEngine;

[RequireComponent(typeof(Camera))]
public class MouseSelect : MonoBehaviour
{

    public GameObjectEvent ItemSelect; // An event to call when a gameobject was successfully clicked on

    private Ray ray; // The ray emitted from the camera
    private RaycastHit hit; // The last hit that was made
    private new Camera camera; // The camera that this script is attached to

    void Start()
    {
        camera = GetComponent<Camera>(); // Get the camera on this gameobject
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // If clicking
        {
            ray = camera.ScreenPointToRay(Input.mousePosition); // Create a ray from the mouse position
            if (Physics.Raycast(ray, out hit)) // If something was hit
            {
                print("Clicked on " + hit.collider.name); // Print a debug
                ItemSelect.Invoke(hit.collider.gameObject); // Invoke the event
            }
        }
    }
}
