using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerTest : MonoBehaviour{
    [SerializeField] private AudioClip sfx;

    private void Update(){
        if (Input.GetButtonDown("Vertical"))
            AudioManager.p_Instance.PlaySFX(sfx);  
    }

}
