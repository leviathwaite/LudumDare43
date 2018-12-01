using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureCollisions : MonoBehaviour
{
    private FurnitureAnimation furnitureAnimation;
    // Start is called before the first frame update
    void Start()
    {
        furnitureAnimation = GetComponent<FurnitureAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            furnitureAnimation.PlayOpenAndCloseAnimation();
            Debug.Log("player");
        }
    }
    /*
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            furnitureAnimation.PlayOpenAndCloseAnimation();
            Debug.Log("player");
        }
    }
    */
}
