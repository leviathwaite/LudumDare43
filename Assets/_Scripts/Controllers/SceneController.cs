using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string playerOneWinsSceneName;
    public string playerTwoWinsSceneName;
    public string timeUpSceneName;

    private void Awake()
    {
        //Ensure the script is not deleted while loading
        DontDestroyOnLoad(this);

        //Make sure there are copies are not made of the GameObject when it isn't destroyed
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            //Destroy any copies
            Destroy(gameObject);
        }
            
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetScene()
    {
        // reset scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextScene()
    {
        // load next level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayerOneWinsScene()
    {
        SceneManager.LoadScene(playerOneWinsSceneName);
    }

    public void PlayerTwoWinsScene()
    {
        SceneManager.LoadScene(playerTwoWinsSceneName);
    }

    public void TimeUpScene()
    {
        SceneManager.LoadScene(timeUpSceneName);
    }
}
