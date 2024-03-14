using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFish : MonoBehaviour
{
    [SerializeField] private float speed;

    public GameManager GM;

    private void OnTriggerEnter2D(Collider2D Hook)
    {
       if(Hook.name == "Player")
        {
            GM.CollectedFish();
            Destroy(gameObject);
        } 
    }

    void Update()
    {

    }
}
