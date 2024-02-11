using UnityEngine;

public class DraggableObject : MonoBehaviour
{
    PlayerController playerController;

    private bool isDragging = false;
    private Vector3 offset;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!isDragging)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("Draggable"))
                {
                    isDragging = true;
                    offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
                    Debug.Log("Clicked on " + gameObject.name);

                    playerController.isUsingAbility = true;
                }
            }
            else
            {
                isDragging = false;
                Debug.Log("Released " + gameObject.name);

                playerController.isUsingAbility = false;
            }
        }

        if (isDragging)
        {
            // Calculate the new position of the object based on the mouse position
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z)) + offset;

            // Update the object's position, allowing movement along both X and Z axes
            transform.position = new Vector3(newPosition.x, transform.position.y, newPosition.z);
        }
    }
}
