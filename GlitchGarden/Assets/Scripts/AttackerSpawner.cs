using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool isSpawn = true;
    float minSpawnTime = 1f;
    float maxSpawnTime = 5f;
    [SerializeField]GameObject attacterPerfab;
    IEnumerator Start()
    {
        while (isSpawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
            SpawnAttacter();
        }
    }

    private void SpawnAttacter()
    {
        Instantiate(attacterPerfab, transform.position, Quaternion.identity);
    }

    void Update()
    {

    }
}
