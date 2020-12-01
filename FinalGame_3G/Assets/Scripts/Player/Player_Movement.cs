using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

public class Player_Movement : MonoBehaviour
{
    //Declaro las variables globales

    private float maxSpeedPlayer = 5f; //velocidad maxima del jugador
    private float speedPlayer = 10f; //velocidad normal del jugador
    public bool grounded; //validar si esta tocando el suelo
    
    private Rigidbody2D RBplayer; //para guardar el rigidbody2D del gameobject
    private Animator animatorPlayer; //para guardar el animator del gameobject
    
    private float jumpPower = 6f; //para guardar el valor de la fuerza para el salto
    private bool jump; //para validar si estoy saltando
    private bool doubleJump; //para validar si puedo hacer doble salto

    private bool movementPlayer = true; //para validar si el player fue golpeado por un enemigo
    private SpriteRenderer SRPlayer; //para guardar el SR del jugador

    void Start()
    {
        //obtengo el rigidbody del player
        RBplayer = GetComponent<Rigidbody2D>(); //cargo el rigidbody del gameobject donde esta adjunto este script
        animatorPlayer = GetComponent<Animator>(); //cargo el animator adjunto al gameobject donde esta adjunto este script
        SRPlayer = GetComponent<SpriteRenderer>(); //cargo el SpriteRenderer del gameobject
    }

    void Update()
    {
        //configuro el valor para las variables del animator cargado
        animatorPlayer.SetFloat("Speed", Mathf.Abs(RBplayer.velocity.x)); 
        animatorPlayer.SetBool("Grounded", grounded);

        //valido  si estoy saltando detectando la tecla
        if (Input.GetKeyDown(KeyCode.UpArrow)) //si la tecla de salto esta presionada 1 vez y si esta tocando el escenario
        {
            if (grounded)
            {
                jump = true;
                doubleJump = true;
            }
            else if (doubleJump)
            {
                jump = true;
                doubleJump = false;
            }
            
        }
    }

    private void FixedUpdate()
    {
        
        //obtengo la entrada del teclado para el eje x
        float horizontalMovement = Input.GetAxis("Horizontal");

        // valido si hay movimiento presionando las teclas de direccion horizontal.
        if (!movementPlayer)
        {
            horizontalMovement = 0;
        }

        //agrego la fuerza al gameobject
        RBplayer.AddForce(Vector2.right * speedPlayer * horizontalMovement,ForceMode2D.Force);

        //Debug.Log(RBplayer.velocity.x); //saber la velocidad

        //limito la velocidad a la maxima
        float limitedSpeedPlayer = Mathf.Clamp(RBplayer.velocity.x, -maxSpeedPlayer, maxSpeedPlayer);
        RBplayer.velocity = new Vector2(limitedSpeedPlayer, RBplayer.velocity.y);

        //Debug.Log(RBplayer.velocity.x); //observo la velocidad

        //cambio la orientacion del gameobject
        if (horizontalMovement > 0.01f)
        {
            //oriento el sprite a la derecha
            transform.localScale = new Vector3(1f, 1f, 1f); 
        }

        if (horizontalMovement < 0.01f)
        {
            //oriento el sprite a la izquierda
            transform.localScale = new Vector3(-1f, 1f, 1f);

        }

        //si la variable jump es verdadera cuando presiono la tecla
        if (jump)
        {
            //aplico la fuerza
            RBplayer.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            //dejo la variable en falso para otro salto cuando se presione la tecla
            jump = false; 
        }
    }

    // restablecer el jugador a su posicion inicial
    void OnBecameInvisible()
    {
        RestartGameOutCameraFocus();
    }

    // saltar cuando se elimina un enemigo
    public void EnemyJump()
    {
        jump = true;
    }

    // efecto de daño del enemigo
    public void EnemyHitPlayer(float enemyPosX)
    {
        jump = true;
        
        // capturo la diferencia de las posisiones en x del jugador y el enemigo
        float side = Mathf.Sign(enemyPosX - transform.position.x);

        // hago una fuerza en la posicion contraria al enemigo, para hacer una diagonal
        RBplayer.AddForce(Vector2.left * side * jumpPower, ForceMode2D.Impulse);

        // detengo el movimiento del jugador durante el impacto
        movementPlayer = false; 

        // configuro el delay para que el jugador recupere el movimiento
        Invoke("EnableMovementPlayer", 0.7f);

        // cambiamos el color del gameobject
        SRPlayer.color = Color.red;
    }

    private void EnableMovementPlayer()
    {
        // habilita el movimiento del jugador
        movementPlayer = true;
        // cambiamos el color del gameobject al predeterminado
        SRPlayer.color = Color.white;
    }

    private void RestartGameOutCameraFocus()
    {
        SceneManager.LoadScene(0);
    }

}
