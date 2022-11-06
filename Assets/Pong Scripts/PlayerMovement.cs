using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody player;
    public float speed;

    void Start() {

    }

    // Update is called once per frame
    void Update()
    {        
        var JoyStickAxis = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick, OVRInput.Controller.RTouch);
        float fixedY = player.position.y;

        player.position += (transform.right * JoyStickAxis.x + transform.forward * JoyStickAxis.y) * Time.deltaTime * speed;
        player.position = new Vector3(player.position.x, fixedY ,player.position.z);
    }
}
