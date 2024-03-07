using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchPhaseDisplay : MonoBehaviour
{
    public Text phaseDisplayText;
    private Touch theTouch;
    private float timeTouchEnd;
    private float displayTime = .5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);
            phaseDisplayText.text = theTouch.phase.ToString();

            if(theTouch.phase == TouchPhase.Ended)
            {
                timeTouchEnd = Time.time;
            }
        }
        else if (Time.time - timeTouchEnd > displayTime)
        {
            phaseDisplayText.text = "";
        }
    }
}
