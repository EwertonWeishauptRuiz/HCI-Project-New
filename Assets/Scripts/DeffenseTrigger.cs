using UnityEngine;
using System.Collections;
using Vuforia;


public class DeffenseTrigger : MonoBehaviour,
                                            ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;

    public bool attackTrigger = false;

    public GameObject attack;

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
        attack.SetActive(false);
    }

    public void Update()
    {
        if (attackTrigger)
        {
            attack.SetActive(true);
        }
        else
        {
            attack.SetActive(false);
        }
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // Play audio when target is found
            attackTrigger = true;
            Debug.LogWarning("ATTACK!!!!!!!!!!!!!");
        }
        else
        {
            // Stop audio when target is lost
            attackTrigger = false;
            
        }
    }
}