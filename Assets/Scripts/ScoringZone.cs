using UnityEngine;
// The event trigger system is used to trigger an especific function
// on a game object script, set in a list in UI 
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
    // Score event trigger variable 
    public EventTrigger.TriggerEvent scoreTrigger;

    // This is called every collision event
    private void OnCollisionEnter2D(Collision2D other) 
    {
        // Try to find Ball.cs component in other
        Ball ball = other.gameObject.GetComponent<Ball>();
        // Check if it was found
        if(ball != null)
        {
            // Create a event data variable
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            // Trigger the event set in UI
            this.scoreTrigger.Invoke(eventData);
        }
    }
}
