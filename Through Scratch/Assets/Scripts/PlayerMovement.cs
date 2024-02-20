using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rg;
    public float forceMove, forceSideways;
    private float dirX;
    void FixedUpdate()
    {
        //player.position += new Vector3(0f, 0f, forceForward * Time.deltaTime);
        /*rg.AddForce(0f, 0f, forceForward * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            //player.position += new Vector3(forceSideway* Time.deltaTime, 0f, 0f);
            rg.AddForce(forceSideway* Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey("a"))
        {
            //player.position += new Vector3(-(forceSideway* Time.deltaTime), 0f, 0f);
            rg.AddForce(-(forceSideway * Time.deltaTime), 0f, 0f);
        }*/

        dirX = Input.GetAxis("Horizontal") * forceSideways;

        rg.velocity = new Vector3(dirX, 0, forceMove * Time.deltaTime);
    }

}
