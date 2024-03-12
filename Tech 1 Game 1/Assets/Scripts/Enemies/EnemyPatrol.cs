using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActions : MonoBehaviour
{
    public Transform[] Waypoints;
    int target;
    public float speed;
    public Health HP;
    public float damage;

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
    }

    /*private void OnCollisionEnter2D(Collision2D other)
     {
    if(other.gameObject.CompareTag("Player"))
      {
         Health.TakeDamage(damage);
      }
    }*/
}
