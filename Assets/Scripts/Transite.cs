using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transite : MonoBehaviour
{
    public float movimientoSpeed = 1f;
    //public float rotationSpeed = 1f;
    Vector3 targetPosition;
    Vector3 towardsTarget;
    
    float wanderRadius = 5f;
    public void RecalcularPosicionObjetivo()
    {
        targetPosition = transform.position + Random.insideUnitSphere * wanderRadius;
        targetPosition.y = 0;
    }
        
    // Start is called before the first frame update
    void Start()
    {
        RecalcularPosicionObjetivo();   
    }

    // Update is called once per frame
    void Update()
    {
        towardsTarget = targetPosition - transform.position;
        if(towardsTarget.magnitude < 0.25f)
        {
            RecalcularPosicionObjetivo();
        }
        transform.position += towardsTarget.normalized * movimientoSpeed * Time.deltaTime;
        
    }
}
