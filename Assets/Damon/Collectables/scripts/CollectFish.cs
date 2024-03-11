using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFish : MonoBehaviour
{
    [SerializeField] private float speed;

    public GameManager GM;
    public Vector3 rotationAngles = new(-0, 90, 90);

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
        // Rotate the GameObject by the specified angles
        //transform.Rotate(rotationAngles);
    }
}
