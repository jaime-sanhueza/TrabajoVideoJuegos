using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRepeat : MonoBehaviour
{
    public GameObject cuboIvoke;
   
    
    // Start is called before the first frame update
    public void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Invoke("ObjetoInvoke", 0);
        }
        
        //InvokeRepeating("ObjetoInvoke", 3, 5);

        //    CancelInvoke("ObjetoInvoke");
      
    }
    public void ObjetoInvoke()
    {
        float x = Random.Range(-10f,10f);
        float z = Random.Range(5f, 15f);

        Instantiate(cuboIvoke, new Vector3(x, 0f, z), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
