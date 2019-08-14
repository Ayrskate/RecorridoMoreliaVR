using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(AudioSource))]

public class AudioManager : MonoBehaviour{
    AudioSource listener;

    int index = 0;
    public AudioClip [] audios;

    // Start is called before the first frame update
    void Start(){
        StartCoroutine(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update(){
        
    }

    IEnumerator Patzcuaro(){
        yield return new WaitForSeconds(2);
        listener.Pause();
        listener.clip = audios[index];
        listener.Play();
        index++;
        StartCoroutine(SceneManager.GetActiveScene().name);
    }
}
