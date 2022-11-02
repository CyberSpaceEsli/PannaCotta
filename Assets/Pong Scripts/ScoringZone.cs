using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;

    private void OnCollisionEnter(Collision collision)
        {
            IntelligentBall ball = collision.gameObject.GetComponent<IntelligentBall>();

            if (ball != null)
            {
                BaseEventData eventData = new BaseEventData(EventSystem.current);
                this.scoreTrigger.Invoke(eventData);
            }
        }
}
