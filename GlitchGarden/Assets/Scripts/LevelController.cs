using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject lostLabel;
    int numberOfAttacker = 0;
    bool levelTimerFinished = false;

    private void Start()
    {
        winLabel.SetActive(false);
        lostLabel.SetActive(false);
    }
    public void AttackerSpawned()
    {
        numberOfAttacker++;
    }

    public void AttackerKilled()
    {
        numberOfAttacker--;
        if(numberOfAttacker <= 0 && levelTimerFinished)
        {
            StartCoroutine(HandleWinCondition());
        }
    }

    private IEnumerator HandleWinCondition()
    {
        winLabel.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(4f);
        FindObjectOfType<LevelLoader>().LoadNextScene();
    }

    public void HandleLostnCondition()
    {
        lostLabel.SetActive(true);
        Time.timeScale = 0;
    }

    public void LeveTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawner();
    }

    private void StopSpawner()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach(var spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }
}
