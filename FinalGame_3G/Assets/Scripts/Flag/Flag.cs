using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Flag : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.root.gameObject.CompareTag("Player")){
            Debug.Log("Has Ganado Este Nivel - Felicitaciones");
        }
    }
}
