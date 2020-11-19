using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class BorderCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.transform.root.gameObject.CompareTag("Player")){
            Destroy(collision.transform.root.gameObject);
            Debug.Log("Has perdido la partida - Reinicia el juego");
        }
    }
}
