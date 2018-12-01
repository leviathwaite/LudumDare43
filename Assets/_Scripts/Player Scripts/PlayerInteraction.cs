using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField]
    private KeyCode useItem;
    [SerializeField]
    private float triggerOnTime = 10;
    private float triggerOnTimer = 0;

    private SphereCollider sphereCollider;

    // Start is called before the first frame update
    void Start()
    {
        sphereCollider = GetComponent<SphereCollider>();
    }

    private void ResetTimer()
    {
        triggerOnTimer = triggerOnTime + Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(useItem))
        {
            TriggerInteraction();
        }

        if(triggerOnTimer < Time.time)
        {
            sphereCollider.enabled = false;
        }
    }

    private void TriggerInteraction()
    {
        // turn of trigger
        sphereCollider.enabled = true;
        ResetTimer();
    }
}
