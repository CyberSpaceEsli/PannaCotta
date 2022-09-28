using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerDetection : MonoBehaviour
{

    public GameObject player;
    public Text TextField;
    Collider cylinder;
    Collider endBox;

    bool finishedGame = false;

    void OnTriggerEnter(Collider other) {
        
          if (other.tag == "Hole"){
            if (!finishedGame){
                TextField.text = "You have Lost!";
            }
          } 
          
          if(other.tag == "Finish"){
            if (!finishedGame){
                TextField.text = "You have Won!";
            }
          }
          
          player = GameObject.Find("Player");
          Destroy(gameObject);
          FindObjectOfType<GameControll>().EndGame();
        finishedGame = true;
    }
}
