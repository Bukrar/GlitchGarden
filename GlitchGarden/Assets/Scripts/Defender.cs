using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int costStart = 100;
    public void AddStars(int amount)
    {
        FindObjectOfType<StartDisplay>().Addstars(amount);
    }

    public int GetStartCost()
    {
        return costStart;
    }
}
