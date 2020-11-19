using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class BorderCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Player")){
            Debug.Log("Me han chocado");
        }   
    }
}
