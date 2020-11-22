using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

/*Script que permite que el (poligono) de prueba, elimine a los enemigos cuando los choque, y además va contando cuantas muertes va realizando. 
 Este dato sirve para llevar el conteo de virus eliminados, cuando el personaje tenga un poder recogido. En consola se puede ver cuantas bajas se llevan */
public class Destroyer : MonoBehaviour{
    public float deaths;
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.transform.root.gameObject.CompareTag("Enemy")){
            Destroy(collision.gameObject);
            deaths = deaths + 1f;
            Debug.Log(deaths + " Numero de muertes");
        }
    }
}
