using UnityEngine;
using System.Collections;
using Vuforia;

public class MonsterTrigger : MonoBehaviour,
                                            ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;

    AttackTrigger trigger;
    Renderer rend;
    bool foundObject = false;
    [Header("Test for Attack")]    
    public bool testBoolean;

    public GameObject canvas;

    void Start() {
        trigger = GameObject.Find("Attack Target").GetComponent<AttackTrigger>();
        rend = GameObject.Find("Monster 1").GetComponent<Renderer>();
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();

        if (mTrackableBehaviour) {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
        canvas.SetActive(false);
    }

    public void Update()
    {
        if (foundObject) {
            canvas.SetActive(true);
        } else {
            canvas.SetActive(false);
        }

        if (trigger.attackTrigger || testBoolean) {
            //Activate the waiting time for the defense of the Other Monster
            rend.material.color = Color.red;
        } else {
            rend.material.color = Color.white;
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
            // When target is found
            foundObject = true;            
        }  else  {
            // When target is lost
            foundObject = false;            
        }
    }
}