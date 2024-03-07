using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.Mathematics;
using UnityEngine;



public class ChunkManager : MonoBehaviour
{
    [SerializeField] private GameObject spawnableChunk;
    [SerializeField] private GameObject chunkSpawnLocation;
    [SerializeField] private GameObject[] ChunkArray;


    /*
     * Check if a gameObject has entered the trigger box,
     * and check if that gameObject has a tag called Chuck,
     * then call function lifeCycle to destory and respawn a new chunk.
     */
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Chunk"))
        {
            LifeCycle(other.gameObject);
        }
    }

    /*
     * lifeCycle is responsible for destoring old Chunks and respawning new ones
     * 
     */
    private void LifeCycle(GameObject Chunk)
    {
        Vector3 chunkRotation = new Vector3(-90.0f, 0.0f, 0.0f);
        Destroy(Chunk);
        int randomChunk = UnityEngine.Random.Range(0, ChunkArray.Length);
        GameObject newChunk = Instantiate(ChunkArray[randomChunk], chunkSpawnLocation.transform.position, Quaternion.Euler(chunkRotation));
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
