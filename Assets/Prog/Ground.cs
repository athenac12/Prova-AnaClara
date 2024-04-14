using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    // Start is called before the first frame update

    Character Player;

    void Start()
    {
        Player = gameObject.transform.parent.gameObject.GetComponent<Character>();

    }

     void OnCollisionEnter2D(Collision2D collisor)
    {
        if(collisor.gameObject.layer == 8)
        {
            Player.isJumping = false;
        }    
    }

    void OnCollisionExit2D(Collision2D collisor)
    {
        if (collisor.gameObject.layer == 8)
        {
            Player.isJumping = true;
        }
    }

}
