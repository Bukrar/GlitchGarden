using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Time")]
    private float levelTime =10;
    bool triggerLevelFinished = false;

    private void Update()
    {
        if (triggerLevelFinished) { return; }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;
        bool timerFinished = (Time.timeSinceLevelLoad >= levelTime);
        if(timerFinished)
        {
            FindObjectOfType<LevelController>().LeveTimerFinished();
            triggerLevelFinished = true;
        }
    }


}
