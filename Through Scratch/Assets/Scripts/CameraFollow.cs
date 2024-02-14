using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform camera,player;

    // Update is called once per frame
    void FixedUpdate()
    {
        camera.position = new Vector3(player.position.x, player.position.y+2, player.position.z-6);
    }
}
