using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //variable para capturar el gameobject a seguir
    public GameObject followObjectTarget;

    //variables para suavizar el seguimiento de la camara
    private float smoothTime = 0.25f;
    private Vector2 velocity;

    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        //hago equivalencia con la ubicacion de la camara y el gameobject a seguir
        float posX = Mathf.SmoothDamp
            (transform.position.x
            , followObjectTarget.transform.position.x
            , ref velocity.x
            , smoothTime);
        float posY = Mathf.SmoothDamp
            (transform.position.y
            , followObjectTarget.transform.position.y
            , ref velocity.y
            , smoothTime);

        //modifico la posicion de la camara con la del objeto a seguir
        transform.position = new Vector3(posX, posY, transform.position.z);
    }
}
