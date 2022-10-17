using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject player;
    public float timeValue = 90;
    public Text TextField;
    public Text TimerField;

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0){
            timeValue -= Time.deltaTime;
        }
        else {
            TextField.text = "You have Lost!";
            player = GameObject.Find("Player");
            Destroy(gameObject);
            FindObjectOfType<GameControll>().EndGame();
            timeValue = 0;
        }

        DisplayTime(timeValue);

    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Hole" & other.tag =="Finished"){
            Time.timeScale = 0;
        }
    }

    public void DisplayTime(float timeDisplay) {
        float minutes = Mathf.FloorToInt(timeDisplay / 60);
        float seconds = Mathf.FloorToInt(timeDisplay % 60);

        TimerField.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
