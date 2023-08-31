using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed=0f;
    public Transform shootOrigin;
    public GameObject shootPrefab;


    // Update is called once per frame
    void Update()
    {
        //movimiento w,d dinamico para que valga con varios botones
        transform.Translate(Input.GetAxis("Horizontal")*speed * Time.deltaTime,
            transform.position.z, transform.position.z);
        //Poner un boton para shoot tanto para pc, android, etc
    if (Input.GetButtonDown("Shoot"))
    {
            //Se crear la bala cada vez que aplasto espacio con todo y script move
            Instantiate(shootPrefab, shootOrigin, false);
     }
    }
}
