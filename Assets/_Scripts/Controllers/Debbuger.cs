using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debbuger : MonoBehaviour
{
    SceneController sceneController;

    // Start is called before the first frame update
    void Start()
    {
        sceneController = GetComponent<SceneController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.R))
        {
            sceneController.ResetScene();
        }

        if(Input.GetKeyUp(KeyCode.T))
        {
            sceneController.NextScene();
        }
    }
}
