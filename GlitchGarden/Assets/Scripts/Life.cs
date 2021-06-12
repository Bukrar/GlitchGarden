using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    private float baselifePoint = 3;
    private float lifePoint;
    private int damage = 1;
    Text lifeText;

    void Start()
    {
        lifePoint = baselifePoint - PlayerPrefabController.GetDifficulty();
        lifeText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        lifeText.text = lifePoint.ToString();
    }

    public void TakeLife()
    {
        lifePoint -= damage;
        UpdateDisplay();

        if(lifePoint <= 0)
        {
            FindObjectOfType<LevelController>().HandleLostnCondition();
        }
    }
}
