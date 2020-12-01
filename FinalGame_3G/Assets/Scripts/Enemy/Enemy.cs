using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

/*Script que permite que los (Enemigos) puedan eliminar al personaje principal (Player) cuando los choque */
public class Enemy : MonoBehaviour{
    public AudioSource clip;
    //private void OnCollisionEnter2D(Collision2D collision){
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.root.gameObject.CompareTag("Player")){
            clip.Play();
            Destroy(collision.gameObject, 0.5f);
            //RestartGameAfterEnemyKillPlayer();
        }
    }

    public void RestartGameAfterEnemyKillPlayer()
    {
        //SceneManager.LoadScene(0);
    }
}
