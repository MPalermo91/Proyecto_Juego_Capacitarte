using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy_Controller : MonoBehaviour
{
    public NavMeshAgent nav;

    public Transform target;

    public Transform jugador;

    public Transform puntoA;
    public Transform puntoB;
    public float cambioDireccion;
    private Transform puntoObjetivo;

    public Animator anim;

    public void Start()
    {
        puntoObjetivo = puntoA;
    }

    private void Update()
    {


        patrullajeAI();

        /*float distance = Vector3.Distance(transform.position, jugador.position);

        if (distance <= minDistPerseguir)
        {
        perseguir = true;

        // anim.SetBool ( "pers", true);
        }

        if (distance <= 

        */
        float distance = Vector3.Distance(transform.position, puntoObjetivo.position);

        if (distance <= cambioDireccion)
        {
            if (puntoObjetivo == puntoA)
            {
                puntoObjetivo = puntoB;

                else
                    puntoObjetivo = puntoA
            }
        }
        nav.SetDestination(puntoObjetivo.position);
        //nav.SetDestination(target.position)    //Apunta y sigue al Objetivo (sin medir distancia, solo lo sigue siempre)
    }

   // public void patrullajeAI;   
    {

    }
}
