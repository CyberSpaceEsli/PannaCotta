using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerDetection : MonoBehaviour
{

    public GameObject player;
    public Text TextField;
    Collider cylinder;

    bool finishedGame = false;

    void OnTriggerEnter(Collider cylinder) {

        cylinder = GetComponent<Collider>();
        cylinder.isTrigger = true;
        cylinder.tag = "Hole";
        
          if (!finishedGame){
                TextField.text = "You have Lost!";
          }

            if (cylinder.tag == "Hole"){
                     player = GameObject.Find("Player");
                    Destroy(gameObject);
                    FindObjectOfType<GameControll>().EndGame();
                 }
                 
        finishedGame = true;
    }
}
