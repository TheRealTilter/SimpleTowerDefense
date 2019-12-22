using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : Projectile {

    public GameObject Target = null;
    public GameObject Explosion;

    public override int Damage
    {
        get { return _damage; }
        set { _damage = value; }
    }

    public override void DestroyProjectile(GameObject projectile)
    {
        Destroy(projectile);
    }

    public void Explode ()
    {
        StartCoroutine(ExplosionTime());
        
    }

    // Use this for initialization
    void Start () {
		
	}

    private void Update()
    {
        if (Target)
        {
            this.FollowTarget(Target);
        }
        

    }

    public IEnumerator ExplosionTime()
    {
        GameObject explosion = Instantiate(Explosion, gameObject.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        Destroy(explosion);
        Destroy(this.gameObject);
    }

    public void FollowTarget(GameObject target)
    {

        this.transform.LookAt(target.transform.position);

        this.transform.Translate(Vector3.forward * Time.deltaTime * 10);

        this.transform.Rotate(90, 0, 0);

    }
}
