using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabHandSC : MonoBehaviour
{

    [Header("Params")]
    public HandType handType;
    public float minTograb = 0.2f;

    public Transform grabbableObject = null;

    public enum HandType
    {
        Left,
        Right
    }

    private bool grabbingObject = false;

    private bool _grabbing;
    public bool Grabbing //Evento agarrar o soltar
    {
        get
        {
            return _grabbing;
        }
        set
        {
            bool _lastValue;
            //Comparacion
            if (_grabbing)
            {
                _lastValue = true;
            }
            else
            {
                _lastValue = false;
            }
                        
            _grabbing = value;

            if (_grabbing != _lastValue)
            {
                if (_grabbing)
                {
                    TakeObject();                    
                }
                else
                {
                    DropObject();
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        InputControl();
    }

    void InputControl()
    {
        //Input Manos
        if (handType == HandType.Left)
        {
            if (Input.GetAxis("LeftHandTrigger") > minTograb)
            {
                Grabbing = true;
            }
            else
            {
                Grabbing = false;
            }

        }
        if (handType == HandType.Right)
        {
            if (Input.GetAxis("RightHandTrigger") > minTograb)
            {
                Grabbing = true;
            }
            else
            {
                Grabbing = false;
            }
        }
    }

    void TakeObject()
    {
        Debug.Log("Mano " + handType.ToString() + " agarro!");

        if(grabbableObject != null)
        {
            
            grabbableObject.transform.parent = transform;
            grabbableObject.transform.localPosition = Vector3.zero;

            grabbingObject = true;            
        }
    }

    void DropObject()
    {
        Debug.Log("Mano " + handType.ToString() + " solto!");

        if (grabbableObject != null)
        {
            grabbableObject.transform.parent = null;

            grabbingObject = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Grabbable")
        {

            Debug.Log("Puede agarrar a objeto: " + other.gameObject.name);


            if (!grabbingObject)
            {                
                grabbableObject = other.transform;                
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Grabbable")
        {
            Debug.Log("Ya no puede agarrar a objeto: " + other.gameObject.name);

            if(!grabbingObject)
                grabbableObject = null;
        }
    }
}
