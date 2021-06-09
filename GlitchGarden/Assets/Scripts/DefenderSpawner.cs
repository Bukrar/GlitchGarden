using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;
    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClicked());
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 wordPos = Camera.main.ScreenToWorldPoint(clickPos);
        return wordPos;
    }

    private void SpawnDefender(Vector2 wordPos)
    {
        GameObject newDefender = Instantiate(defender, wordPos, Quaternion.identity);
    }
}
