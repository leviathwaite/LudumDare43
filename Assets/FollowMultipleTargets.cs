using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMultipleTargets : MonoBehaviour
{
    public Vector3 offset;

    private GameObject player1;
    private GameObject player2;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject gameObject in players)
        {
            if(gameObject.name == "Player1")
            {
                player1 = gameObject;
            }
            else if(gameObject.name == "Player2")
            {
                player2 = gameObject;
            }
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // average positions
        Vector3 targetPosition = (player1.transform.position + player2.transform.position) / 2;
        transform.position = targetPosition + offset;

        transform.LookAt(targetPosition);
    }
}
