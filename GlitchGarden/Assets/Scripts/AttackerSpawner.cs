using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool isSpawn = true;
    float minSpawnTime = 2f;
    float maxSpawnTime = 7f;
    [SerializeField] GameObject attacterPerfab;
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
        GameObject newAttacker = Instantiate(attacterPerfab, transform.position, Quaternion.identity);
        newAttacker.transform.parent = transform;
    }

    void Update()
    {

    }
}
