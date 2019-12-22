using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour {



    [Header("THESE ARE PRIVATE")]
    [SerializeField]
    private int _health = 100;
    [SerializeField]
    private int _maxHealth = 100;
    [SerializeField]
    //private int _health = 100;

    //Properties
    public int Health
    {
        get { return _health; }
        set { _health = value; }
    }
    public int MaxHealth
    {
        get { return _maxHealth; }
        set { _maxHealth = value; }
    }


    // Update is called once per frame
    void Update () {
		if(_health <= 0)
        {
            Destroy(gameObject);
        }
	}
}
