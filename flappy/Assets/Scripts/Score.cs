﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.GetComponent<Bird>() != null)
        {
            GameControl.instance.BirdScored(); 
        }
    }
}