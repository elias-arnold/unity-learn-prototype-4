using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3;

    private Rigidbody enemyRb;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 toPlayerVector = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(toPlayerVector * speed * Time.deltaTime);
    }
}
