using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabHandSC : MonoBehaviour
{

    [Header("Params")]
    public HandType handType;
    public bool grabbing;
    public float minTograb = 0.2f;

    public enum HandType
    {
        Left,
        Right
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input Manos
        if(handType == HandType.Left)
        {
            if (Input.GetAxis("LeftHandTrigger") > minTograb)
            {
                grabbing = true;
            }
            else
            {
                grabbing = false;
            }
            
        }
        if (handType == HandType.Right)
        {
            if (Input.GetAxis("RightHandTrigger") > minTograb)
            {
                grabbing = true;
            }
            else
            {
                grabbing = false;
            }
        }

    }
}
