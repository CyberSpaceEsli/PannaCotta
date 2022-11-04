using UnityEngine;
using UnityEngine.SceneManagement;
public class Interactable : MonoBehaviour
{

    public GameObject self;
    public int index;
    
    private void Update() {
        self.GetComponent<Outline>().enabled = false;
    }
    public void Interact() {
        SceneManager.LoadScene(index);
    }
}