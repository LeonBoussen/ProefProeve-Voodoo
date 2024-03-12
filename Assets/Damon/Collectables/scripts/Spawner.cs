using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject Collectables;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float TimeBetweenSpawn;
    private float SpawnTime;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }


    }


    void Spawn()
    {
        float X = Random.Range(minX, maxY);
        float Y = Random.Range(minY, maxY);

        Vector3 fishRotation = new Vector3(0.0f, 0.0f, 0.0f);

        GameObject fish = Instantiate(Collectables, transform.position + new Vector3(X, Y, 0), Quaternion.Euler(fishRotation));
        fish.transform.parent = transform;

    }




}