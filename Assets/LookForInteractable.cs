using UnityEngine;
using UnityEngine.UI;

public class LookForInteractable : MonoBehaviour
{
    public Text interactableHint;
    public float interactionRange = 5.0f;

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
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

                if (Input.GetKeyDown(KeyCode.F))
                {
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
