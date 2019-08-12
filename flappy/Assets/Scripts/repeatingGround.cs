using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatingGround : MonoBehaviour {

   // private BoxCollider2D groundCollider;
   // private float groundHorizontalLength;

    private float Groundcoll;
	// Use this for initialization
	void Start () {
        //groundCollider = GetComponent<BoxCollider2D>();
        //groundHorizontalLength = groundCollider.size.x;

        Groundcoll = gameObject.transform.localScale.x;
	}
	
	// Update is called once per frame
	void Update () {
		
        if(transform.position.x < -Groundcoll)
        {
            RepositionGround();
        }
	}

    private void RepositionGround()
    {
        //Vector2 groundOffset = new Vector2(groundHorizontalLength * 2, 0);
        //transform.position = (Vector2)transform.position + groundOffset;

        Vector2 GroundOffset = new Vector2(Groundcoll * 2f, 0);
        transform.position = (Vector2)transform.position + GroundOffset;

    }
}