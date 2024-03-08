using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFish : MonoBehaviour
{
    [SerializeField] private float speed;

    public GameManager GM;
    public Vector3 rotationAngles = new Vector3(-90, 90, 90);

    private void FishMovement()
    {
        /*
        Add the accelaration to the speed value and use Clamp to make sure the speed value stays between 0 and maxSpeed value.
        Then use that speed value to update chuck position on the Y axis
        */

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }

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
        transform.Rotate(rotationAngles);
    }
}
