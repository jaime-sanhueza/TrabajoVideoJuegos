﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneInicial : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        
        if (collision.gameObject.tag == "Inicio")
        {
            Application.LoadLevel(0);
        }

    }
}
