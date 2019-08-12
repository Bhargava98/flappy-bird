using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObject : MonoBehaviour {

    public float scrollSpeed = 10;
    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-scrollSpeed, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
