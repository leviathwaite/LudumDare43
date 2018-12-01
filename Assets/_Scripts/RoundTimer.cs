using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RoundTimer : MonoBehaviour
{
    public TMP_Text ui_text;
    [SerializeField]
    private float changeSceneDelay = 2;
    [SerializeField]
    private float startingRoundTimeInMins = 5;

    const float SECONDS_IN_MINUTES = 60;

    private string timeLeftString = "Time Left: ";
    private float timeLeft;

    private SceneController sceneController;

    // Start is called before the first frame update
    void Start()
    {
        SetupTimer();
        sceneController = GameObject.FindGameObjectWithTag("GameController").GetComponent<SceneController>();
    }

    // TODO change to private when not debugging
    public void SetupTimer()
    {
        timeLeft = startingRoundTimeInMins * SECONDS_IN_MINUTES;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    private void UpdateTimer()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft > 0)
        {
            //If time is greater than 0, display time left
            ui_text.text = Mathf.RoundToInt(timeLeft).ToString();
        }
        else
        {
            //Otherwise display this
            ui_text.text = "Time is up!";

            StartCoroutine(ChangeToTimeUpScene());
        }
    }

    IEnumerator ChangeToTimeUpScene()
    {
        yield return new WaitForSeconds(changeSceneDelay);
        sceneController.TimeUpScene();
    }
}
