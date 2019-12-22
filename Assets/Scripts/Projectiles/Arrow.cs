using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : Projectile {

 
    public GameObject Target = null;
    
    public override int Damage
    {
        get { return _damage; }
        set { _damage = value; }
    }

    private void Update()
    {
        if (Target)
        {
            this.FollowTarget(Target);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public override void DestroyProjectile(GameObject projectile)
    {
        Destroy(projectile);
    }

    public void FollowTarget(GameObject target)
    {
        
        this.transform.LookAt(target.transform.position);
        
        this.transform.Translate(Vector3.forward * Time.deltaTime * 10);
        
        this.transform.Rotate(90, 0, 0);
        
    }
}
