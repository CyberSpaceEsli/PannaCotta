using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        // if (Input.GetKeyDown(KeyCode.R))
        // {
        //     SceneManager.LoadSceneAsync(
        //         SceneManager.GetActiveScene().buildIndex);
        // }
         if (Input.GetButton("Fire2")) //B
        {
            SceneManager.LoadSceneAsync(
                SceneManager.GetActiveScene().buildIndex);
        }
    }
}
