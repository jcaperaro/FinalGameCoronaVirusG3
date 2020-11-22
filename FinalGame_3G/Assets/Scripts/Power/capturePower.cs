using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Script que permite que los (poderes - Power) tengan un trigger, que detecten cuando el personaje los toque, de inmediato, se ocultará el (Sprite Renderer) del poder, 
 y queda en valor (false), luego como debajo del (Poder) está la animación de cuando cogen el poder, pero está apagada desde el inicio, pues de inmediato cuando se apaga el poder,
 se prende el (Game Object) del (capture Power), lo cual crea la ilusión de que hay un efecto cuando cogen el poder.... y después de 1 segundo se elimina este game object del
 (capture Power)*/
public class capturePower : MonoBehaviour{
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.transform.root.gameObject.CompareTag("Player")){
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject, 1f);
        }
    }
}
