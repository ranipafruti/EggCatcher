using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawnerController : MonoBehaviour
{
    [SerializeField] private GameObject eggPrefabs;
    [SerializeField] private float maxX;
    [SerializeField] private float minTime;
    [SerializeField] private float maxTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawnEggCoRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator StartSpawnEggCoRoutine()
    {
       while(true) 
        {
            float randomTime = Random.Range(minTime, maxTime);

            yield return new WaitForSeconds(randomTime);
            SpawnEgg();
        }
    }
    private void SpawnEgg()
    {
        float randomX = Random.Range(-maxX, maxX);   

        Vector3 spawnpos = transform.position;
        spawnpos.x = randomX;

        Instantiate(eggPrefabs, spawnpos, Quaternion.identity);

    }
}
