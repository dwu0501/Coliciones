using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public Transform player;
    public Transform camera;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name== "DeathWall")
        {
            transform.position = new Vector3(-3.49f, 0.5f, 0);
        }

    }

    void OnCollisionExit()
    {
        transform.position = new Vector3(-3.49f, 0.5f, 0);
        camera.position = Vector3.Lerp(camera.position, player.position, 0);
        camera.rotation = Quaternion.Lerp(camera.rotation, player.rotation, 0);

    }
}
