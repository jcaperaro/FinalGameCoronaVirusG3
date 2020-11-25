using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_CheckGrounded : MonoBehaviour
{
    private Player_Movement player;

    // Start is called before the first frame update
    void Start()
    {
        //llamo la clase Player_Movement, para acceder a sus atributos.
        player = GetComponent<Player_Movement>();
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        //valido que estoy chocando contra el escenario por su tag
        if (collision.gameObject.tag == "Ground")
        {
            player.grounded = true;
            //Debug.Log(player.grounded); //valido el valor
        }      

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            //valido que no estoy chocando con el escenario por su tag
            player.grounded = false;
            //Debug.Log(player.grounded); //valido el valor
        }

    }


}
