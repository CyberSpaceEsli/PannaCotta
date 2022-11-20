using UnityEngine;
using UnityEngine.UI;

public class LookForInteractable : MonoBehaviour
{
    public Text interactableHint;
    public float interactionRange = 5.0f;

    private void Update()
    {
        Vector3 mid = new Vector3(Screen.width / 2, Screen.height / 2, 1);
        Ray ray = Camera.main.ScreenPointToRay(mid);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactionRange))
        {
            if (hit.transform.gameObject.CompareTag("Interactable"))
            {
                Interactable interactable = hit.transform.gameObject.GetComponent<Interactable>();
                interactable.GetComponent<Outline>().enabled = true;
                interactableHint.enabled = true;
                string name = hit.transform.name;
                string t = "Interact with " + name;
                interactableHint.text = t;

                if (Input.GetButton("Fire1"))
                {
                    // Debug.Log("hey");
                    interactable.Interact();
                }
            }
        }
        else
        {
            interactableHint.enabled = false;
        }
    }
}
