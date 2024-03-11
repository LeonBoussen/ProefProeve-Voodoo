using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int FishCollected = 0;

    public Text FishOutput;
    private void Update()
    {
        FishOutput.text = "Fish: " + FishCollected;
    }

    public void CollectedFish()
    {
        FishCollected++;
    }
}
