using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*Script que permite que los (Enemigos) puedan eliminar al personaje principal (Player) cuando los choque */
public class Enemy : MonoBehaviour{
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.transform.root.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            RestartGame();

        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
