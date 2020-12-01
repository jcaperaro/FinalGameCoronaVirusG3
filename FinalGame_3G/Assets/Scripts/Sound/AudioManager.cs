using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    #region Static Instances
    private static AudioManager _f_instance;        //Field
    public static AudioManager p_Instance           //Property
    {
        get{
            if (_f_instance == null){
                _f_instance = FindObjectOfType<AudioManager>();
                if (_f_instance == null){
                    _f_instance = new GameObject("Spawned Audio Manager", typeof(AudioManager))
                        .GetComponent<AudioManager>();
                }
            }
            return _f_instance;
        }
        private set{
            _f_instance = value;
        }
    }
    #endregion


    #region Fields
    private AudioSource _sfxSource;


    #endregion


    private void Awake()
    {
        _sfxSource = this.gameObject.AddComponent<AudioSource>();
    }

   


    public void PlaySFX(AudioClip clip)
    {
        _sfxSource.PlayOneShot(clip);
    }
    public void PlaySFX(AudioClip clip, float volume)
    {
        _sfxSource.PlayOneShot(clip, volume);
    }

}
