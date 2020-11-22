using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

/*Script que permite que la (banderira - Flag) de la meta, tenga un Trigger, que detecte que cuando la toque el personaje (Player), muestra en consola un
 mensaje que diga (Has ganado este nivel).... Por el momento es de prueba, pero la idea es que cuando el personaje toque está bandera, aparezca un mensaje
 en pantalla, y además se salte a un nuevo nivel de juego*/
public class Flag : MonoBehaviour{
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.transform.root.gameObject.CompareTag("Player")){
            Debug.Log("Has Ganado Este Nivel - Felicitaciones");
        }
    }
}
