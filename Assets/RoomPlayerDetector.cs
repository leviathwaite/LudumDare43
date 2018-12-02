using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomPlayerDetector : MonoBehaviour
{
    [SerializeField]
    private float minDistanceForMainCam = 7;
    [SerializeField]
    private float maxDIstanceForMainCam = 12;

    // [SerializeField]
    private LayerMask camera1StartingMask;
    // SerializeField]
    private LayerMask camera2StartingMask;

    private Camera mainCam;
    private Camera player1Camera;
    private Camera player2Camera;
    private LayerMask startingMask;

    private int playersInRoom = 0;

    private GameObject player1;
    private GameObject player2;

    // Start is called before the first frame update
    void Start()
    {
        SetupCameras();
        camera1StartingMask = player1Camera.cullingMask;
        camera2StartingMask = player2Camera.cullingMask;

        startingMask = Camera.main.cullingMask;

        FindPlayers();
    }

    private void SetupCameras()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        player1Camera = GameObject.FindGameObjectWithTag("Camera1").GetComponent<Camera>();
        player2Camera = GameObject.FindGameObjectWithTag("Camera2").GetComponent<Camera>();
    }

    private void FindPlayers()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject gameObject in players)
        {
            if (gameObject.name == "Player1")
            {
                player1 = gameObject;
            }
            else if (gameObject.name == "Player2")
            {
                player2 = gameObject;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player1.transform.position, player2.transform.position);

        if(playersInRoom == 2 || distance < minDistanceForMainCam)
        {
            EnableMainCamera();
        }
        else if(playersInRoom < 2 || distance > maxDIstanceForMainCam)
        {
            DisableMainCamera();
        }
    }

    private void EnableMainCamera()
    {
        // TODO center in room
        mainCam.depth = 5;
    }

    private void DisableMainCamera()
    {
        mainCam.depth = -1;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playersInRoom++;
            if (other.name == "Player1")
            {
                gameObject.layer = LayerMask.NameToLayer("Player1");
            }
            else if (other.name == "Player2")
            {
                gameObject.layer = LayerMask.NameToLayer("Player2");
            }

            // Debug.Log("Player Entered: " + playersInRoom);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playersInRoom--;
            if(playersInRoom <= 0)
            {
                gameObject.layer = LayerMask.NameToLayer("Default");
            }
            
            // Debug.Log("Player Left: " + playersInRoom);
        }
    }
    
}
