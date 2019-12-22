using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour {

    [SerializeField]
    protected int _damage;


    abstract public int Damage { get; set; }

    abstract public void DestroyProjectile(GameObject projectile);
}
