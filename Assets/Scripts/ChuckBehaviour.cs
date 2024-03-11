using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class ChuckBehaviour : MonoBehaviour
{
    
    [SerializeField] private float speed; //Current falling speed of chunk


    private void ChunkMovement()
    {
        /*
        Add the accelaration to the speed value and use Clamp to make sure the speed value stays between 0 and maxSpeed value.
        Then use that speed value to update chuck position on the Y axis
        */
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }

    void Update()
    {

        ChunkMovement();
    }

}
