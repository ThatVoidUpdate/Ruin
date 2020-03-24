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
                foreach (MonoBehaviour script in hit.collider.GetComponents<MonoBehaviour>())
                {
                    if (script is IClickable)
                    {
                        IClickable clickable = (IClickable)script;
                        clickable.LeftClick();
                    }
                }
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            ray = camera.ScreenPointToRay(Input.mousePosition); // Create a ray from the mouse position
            if (Physics.Raycast(ray, out hit)) // If something was hit
            {
                foreach (MonoBehaviour script in hit.collider.GetComponents<MonoBehaviour>())
                {
                    if (script is IClickable)
                    {
                        IClickable clickable = (IClickable)script;
                        clickable.RightClick();
                    }
                }
            }
        }
    }
}
