using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowTower : MonoBehaviour {

    public Arrow Arrow;

    private Arrow _arrowClone;
    private Transform _bulletSpawnLocation;
    private List<GameObject> _enemies;
    private GameObject _currentEnemy;
    [SerializeField]
    private float _shotTimer = 5.0f;
    [SerializeField]
    private float _shotCooldown = 5.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            _enemies.Add(other.gameObject);
            Debug.Log("Enemy entered");
            Debug.Log(_enemies[0]);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            _enemies.Remove(other.gameObject);
            Debug.Log("Enemy Left");
        }
    }

    // Use this for initialization
    void Start () {
        _bulletSpawnLocation = gameObject.GetComponentsInChildren<Transform>()[2];
        _enemies = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(_enemies.Count);

        _enemies.RemoveAll(GameObject => GameObject == null);

        if ((_enemies.Count != 0))
        {
        
            _shotTimer += Time.deltaTime;
            if (_shotTimer > _shotCooldown)
            {
                Shoot(_enemies[0]);
                _shotTimer = 0.0f;
            }
        }
        if((_enemies.Count == 0))
        {
            _shotTimer = _shotCooldown;
        }



    }


    public void Shoot(GameObject target)
    {
        _arrowClone = Instantiate(Arrow, _bulletSpawnLocation.position, Quaternion.identity, _bulletSpawnLocation);
        _arrowClone.transform.LookAt(target.transform.position);
        _arrowClone.transform.Rotate(90, 0, 0);
        _arrowClone.Target = target;
        _currentEnemy = target;
    }
}
