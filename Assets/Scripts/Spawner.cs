using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject coinPrefabs;
    public GameObject MissilePrefabs;
    [Header("���� Ÿ�̹� ����")]
    public float minSpaWnInterval = 0.5f;
    public float maxSpaWnInterval = 2.0f;
    [Header("���� ���� Ȯ�� ����")]
    [Range(0, 100)]
    public int coinSpwnChance = 50;
    public float timer = 0.0f;
    public float nextSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        SetNextSpawnTime();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // �ð��� 
        if (timer >= nextSpawnTime)
        {
            SpawnObject();
            timer = 0.0f;
            SetNextSpawnTime();
        }

    }
    void SpawnObject()
    {
        Transform spawnTransform = transform;

        int randomValue = Random.Range(0, 100);
        if (randomValue < coinSpwnChance)
        {
         Instantiate(coinPrefabs, spawnTransform.position, spawnTransform.rotation);
        }
        else
        {
            Instantiate(MissilePrefabs, spawnTransform.position, spawnTransform.rotation);
        }



    }



    void SetNextSpawnTime()
    {
        nextSpawnTime = Random.Range(minSpaWnInterval, maxSpaWnInterval);
    }

}