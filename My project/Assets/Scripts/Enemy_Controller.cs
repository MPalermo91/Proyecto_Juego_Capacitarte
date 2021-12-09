using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy_Controller : MonoBehaviour
{

    public NavMeshAgent nav;

    public Transform target;

    public Transform jugador;
    public bool perseguir;
    public Transform puntoA;
    public Transform puntoB;
    public float cambioDireccion;
    private Transform puntoObjetivo;

    

    

   

public void Start()
{
    puntoObjetivo = puntoA;
}
private void Update()
{
    nav.SetDestination(puntoObjetivo.position);     //Envia al enemigo al punto Objetivo seteado
    //nav.SetDestination(target.position)           //Apunta y sigue al Objetivo (sin medir distancia, solo lo sigue siempre)
        patrullajeAI();
    }

public void perseguirPlayer()
  {
    perseguir = true;

    float distance = Vector3.Distance(transform.position, jugador.position);

    if (distance >= 5f)
    {

        perseguir = false;
    }
  }
    private void patrullajeAI()
        {

            float distance = Vector3.Distance(puntoObjetivo.transform.position, puntoObjetivo.position);

            if (distance <= cambioDireccion)
            {
                if (puntoObjetivo == puntoA)
                {
                    puntoObjetivo = puntoB;

                }
                else
    puntoObjetivo = puntoA;
            }
        }
}