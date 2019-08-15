using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]


public class BocaManager : MonoBehaviour{

    AudioManager manager;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "Carnitas"){
            manager.listener.clip = manager.audios[0];
        }
    }
}
