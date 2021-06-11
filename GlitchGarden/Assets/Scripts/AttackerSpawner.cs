using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool isSpawn = true;
    float minSpawnTime = 2f;
    float maxSpawnTime = 7f;
    [SerializeField] GameObject[] attacterPerfabArray;
    IEnumerator Start()
    {
        while (isSpawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
            SpawnAttacter();
        }
    }

    public void StopSpawning()
    {
        isSpawn = false;
    }

    private void SpawnAttacter()
    {
        var attackerIndex = Random.Range(0, attacterPerfabArray.Length);
        Spawn(attacterPerfabArray[attackerIndex]);
    }

    private void Spawn(GameObject myAttacker)
    {
        GameObject newAttacker = Instantiate(myAttacker, transform.position, Quaternion.identity);
        newAttacker.transform.parent = transform;
    }
}
