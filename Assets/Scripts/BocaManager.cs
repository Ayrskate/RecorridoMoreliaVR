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
        switch(other.gameObject.name){
            case "Uchepos":
                manager.listener.clip = manager.audios[2];
                break;
            case "Corunda":
                manager.listener.clip = manager.audios[3];
                break;
            case "Carnitas":
                manager.listener.clip = manager.audios[1];
                break;
            case "Pozole":
                manager.listener.clip = manager.audios[4];
                break;
            case "Sopa Tarasca":
                manager.listener.clip = manager.audios[6];
                break;
            case "Morisqueta":
                manager.listener.clip = manager.audios[5];
                break;
        }
        manager.listener.Pause();
        manager.listener.Play();
    }
}
