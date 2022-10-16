using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateHandler
{
    private int state =0;
  
    public void AddToState()
    {
        state++;
        Debug.Log("Es sind " + state + " pins gefallen");
    }
}
