using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tirar : MonoBehaviour
{
    public float velocidad = 5f;
    Rigidbody cuerpoRigido;
    // Start is called before the first frame update
    void Start()
    {
        cuerpoRigido = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moverVertical = Input.GetAxis("Vertical");
        float moverHorizontal = Input.GetAxis("Horizontal");


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 MovimientoForce = new Vector3(0f, 0f, 200f);
            velocidad = 10f;
            cuerpoRigido.AddForce(MovimientoForce * velocidad);
        }else
        {
            Vector3 Movimiento = new Vector3(moverHorizontal, 0f, 0f);

            cuerpoRigido.AddForce(Movimiento * velocidad);
        }

    }
}

