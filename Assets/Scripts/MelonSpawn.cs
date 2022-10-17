using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelonSpawn : MonoBehaviour
{
	
	public GameObject WaterMElon;

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));
            Instantiate(WaterMElon, randomSpawnPosition, Quaternion.identity);
        }
    }
}
