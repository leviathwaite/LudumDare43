using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCreator : MonoBehaviour
{
    public GameObject wallPrefab;
    public GameObject oneDoorWallPrefab;
    public GameObject twoDoorWallPrefab;

    [SerializeField]
    private int xSpacing = 32;
    [SerializeField]
    private int ySpacing = 32;

    private int[] roomLayout =
    {
        1, 1, 1, 0, 0, 0, 1, 1, 1,
        1, 1, 1, 1, 1, 1, 1, 1, 1, 
        1, 1, 1, 0, 0, 0, 1, 1, 1
    };

    private int numberOfRooms = 21;
    private int numberOfWallsWide = 9;
    private int numberOfWallsHigh = 3;

    private GameObject[] Walls;

    // Start is called before the first frame update
    void Start()
    {
        BuildWalls();
    }

    private void BuildWalls()
    {
        for(int i = 0; i < roomLayout.Length; i++)
        {
            
        }
    }

    private 

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.B))
        {
            RebuildWalls();
        }
    }

    private void RebuildWalls()
    {

        BuildWalls();
    }
}
