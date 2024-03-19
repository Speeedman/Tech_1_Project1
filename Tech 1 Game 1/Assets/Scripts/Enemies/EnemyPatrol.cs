using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform[] Waypoints;
    int target;
    public float speed;
    public Health HP;
    public float damage;
    public float EnemyHealth;
    public bool keyHolder;
    public GameObject Key;

    // Start is called before the first frame update
    void Start()
    {
        target = 0;
        transform.position = Waypoints[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != Waypoints[target].position)
        {
            transform.position = Vector2.MoveTowards(transform.position, Waypoints[target].position, speed * Time.deltaTime);
        }
        else
        {
            target = (target + 1) % Waypoints.Length;
        }
        if(EnemyHealth <= 0)
        {
            Destroy(gameObject);
        }
        if(EnemyHealth <= 0 && keyHolder == true)
        {
            Instantiate(Key, this.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
     {
    if(other.gameObject.CompareTag("Player"))
      {
         HP.TakeDamage(damage);
      }
    }
}
