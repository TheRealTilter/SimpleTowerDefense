using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour {

    public HealthManager enemyHealthManager;
    public Projectile projectile;

    // Use this for initialization
    void Start()
    {
        projectile = gameObject.GetComponent<Projectile>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            enemyHealthManager = other.GetComponent<HealthManager>();
            if (enemyHealthManager)
            {
                enemyHealthManager.Health -= projectile.Damage;
            }

            projectile.DestroyProjectile(gameObject);

        }
        else if (other.gameObject.tag == "Floor")
        {
            projectile.DestroyProjectile(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
