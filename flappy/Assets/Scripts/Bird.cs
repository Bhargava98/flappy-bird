using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour {

    private bool isDead = false;
    public float upForce = 200f;
    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
        if(isDead == false)
        {
            if(Input.GetKey(KeyCode.Space))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0, upForce));
            }
        }

        if (isDead == true & Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

	}

    private void OnCollisionEnter2D(Collision2D coll)
    {
        GameControl.instance.BirdDed();
        isDead = true;
    }
}
