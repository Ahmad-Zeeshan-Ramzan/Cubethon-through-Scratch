using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform player;
    public float forceForward, forceSideway;
    void FixedUpdate()
    {
        player.position += new Vector3(0f, 0f, forceForward * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            player.position += new Vector3(forceSideway* Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey("a"))
        {
            player.position += new Vector3(-(forceSideway* Time.deltaTime), 0f, 0f);
        }
    }

}
