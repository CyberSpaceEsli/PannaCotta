using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetection : MonoBehaviour
{

    public GameObject player;
    Collider cylinder;

    void OnTriggerEnter(Collider cylinder) {

        cylinder = GetComponent<Collider>();
        cylinder.isTrigger = true;
        cylinder.tag = "Hole";
        
        if (cylinder.tag == "Hole"){
            player = GameObject.Find("Player");
            Destroy(gameObject);
            FindObjectOfType<GameControll>().EndGame();
        }
    }
}
