using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.
    LevelManager levelManager;


    // Start is called before the first frame update
    void Start()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);

        GetCurrentLevelManager();
        // TODO check if level manager is loaded

        //Call the InitGame function to initialize the first level 
        // InitGame();
    }

    private void GetCurrentLevelManager()
    {
        levelManager = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<LevelManager>();
        if(levelManager)
        {
            Debug.Log("Level Manager found");
        }
        else
        {
            Debug.Log("Level Manager not found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
