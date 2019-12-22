using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GroundImpact : MonoBehaviour {

    private Bomb _bomb;
    private bool _once = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!_once)
        {
            if (other.gameObject.tag == "Floor" || other.gameObject.tag == "Enemy")
            {
                _bomb.Explode();
                _once = true;
            }
        }
    }

    // Use this for initialization
    void Awake () {
        _bomb = gameObject.GetComponent<Bomb> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
