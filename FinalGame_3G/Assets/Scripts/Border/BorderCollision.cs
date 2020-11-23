using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

/*Script que permite que el (Borde del juego) pueda manipular el (Triger) que se le colocó en la parte inferior, donde detecta cuando entre el personaje,
 lo que quiere decir que el personaje se cayó al vacio y muere, entonces apenas pase por este (Trigger) quedará eliminado el personaje (Player), se muestra
 un mensaje en consola que dice (Has perdido la partida - Reinicie juego)*/
public class BorderCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.transform.root.gameObject.CompareTag("Player")){
            Destroy(collision.transform.root.gameObject);
            RestartGameAfterFall();
            Debug.Log("Has perdido la partida - Reinicia el juego");
        }
    }

    public void RestartGameAfterFall()
    {
        SceneManager.LoadScene(0);
    }
}
