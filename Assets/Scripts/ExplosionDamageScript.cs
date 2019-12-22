using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDamageScript : MonoBehaviour {

    public HealthManager enemyHealthManager;
    public Bomb Bomb;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            enemyHealthManager = other.GetComponent<HealthManager>();
            if (enemyHealthManager)
            {
                enemyHealthManager.Health -= Bomb.Damage;
            }
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
