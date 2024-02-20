using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rb;
    public Animator anim;
    public SpriteRenderer Sprite;
    private Vector2 dir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        dir = new Vector2(x, y).normalized;

        if (x != 0)
        {
            ClearWalkCycle();
            anim.SetBool("Side", true);
        }
        
        else if (y > 0)
        {
            ClearWalkCycle();
            anim.SetBool("Back", true);
        }

        else if (y < 0)
        {
            ClearWalkCycle();
            anim.SetBool("Front", true);
        }

        else if (x == 0 && y == 0)
        {
            ClearWalkCycle();
            anim.SetBool("Idle", true);
        }

        if (x < 0)
        {
            Sprite.flipX = true;
        }
        if (x > 0)
        {
            Sprite.flipX = false;
        }
    }

    public void ClearWalkCycle()
    {
        anim.SetBool("Back", false);
        anim.SetBool("Idle", false);
        anim.SetBool("Front", false);
        anim.SetBool("Side", false);
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dir.x * speed, dir.y * speed);
    }
}
