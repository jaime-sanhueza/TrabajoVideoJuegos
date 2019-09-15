using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public Rigidbody BalaPrefab;
    public Transform lanzador;
    public float ValDisparador;
    public float tiempoDisparo;
    private float inicioDisparar;
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > inicioDisparar)
        {
            inicioDisparar = Time.time * tiempoDisparo;
            Rigidbody prefabInstanc;
            prefabInstanc = Instantiate(BalaPrefab, lanzador.position, Quaternion.identity) as Rigidbody;
            prefabInstanc.AddForce(lanzador.forward * 100 * ValDisparador);
            
            
        }
      
    }
}
