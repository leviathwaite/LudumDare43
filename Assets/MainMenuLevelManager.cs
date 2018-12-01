using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuLevelManager : LevelManager
{
    private SceneController sceneController;

    // Start is called before the first frame update
    void Start()
    {
        sceneController = GameObject.FindGameObjectWithTag("GameController").GetComponent<SceneController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey)
        {
            sceneController.NextScene();
        }
    }
}
