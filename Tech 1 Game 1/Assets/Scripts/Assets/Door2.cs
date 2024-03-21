using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    public Movement player;
    public BoxCollider2D box;
    public SpriteRenderer spriteR;
    public Sprite openDoor;

    void Update()
    {
        if (player.hasKey2 == true)
        {
            box.enabled = false;
            spriteR.sprite = openDoor;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

}
