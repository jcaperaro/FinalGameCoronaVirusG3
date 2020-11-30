using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerTest : MonoBehaviour{
    [SerializeField] private AudioClip sfx;
    [SerializeField] private AudioClip music1;
    [SerializeField] private AudioClip music2;

    private void Update(){
        if (Input.GetButtonDown("Vertical"))
            AudioManager.p_Instance.PlaySFX(sfx);
    }

    void Start() {
        AudioManager.p_Instance.PlayMusic(music2);
    }
}
