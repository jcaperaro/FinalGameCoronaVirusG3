using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capturePower : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.transform.root.gameObject.CompareTag("Player")){
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject, 1f);
        }
    }
}
