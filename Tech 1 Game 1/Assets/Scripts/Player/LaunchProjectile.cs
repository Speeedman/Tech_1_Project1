using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public GameObject projectile;
    public Movement player;
    public float launchVelocity = 700f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject ball = Instantiate(projectile, transform.position, transform.rotation);
            ball.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector3 (launchVelocity, 0, 0));
        }
    }
}
