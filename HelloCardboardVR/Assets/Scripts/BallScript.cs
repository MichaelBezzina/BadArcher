using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallScript : MonoBehaviour {
    public ParticleSystem explosion;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        explosion.transform.position = this.transform.position; //You can add this so that the effect appears where the collision happens. In case there is more than one collision
        Debug.Log(explosion.transform.position);
        explosion.Play();
        new WaitForSeconds(.5f);
        Destroy(gameObject);
    }
}
