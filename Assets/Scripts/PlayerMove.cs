using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    //the speed you want your player to move with.
    public GameObject player;
    public float speed;
    public float stopAnimation = 0.5f;

    void FixedUpdate()
    {
        Vector3 directionVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if ((directionVector.x > stopAnimation || directionVector.x < -stopAnimation) ||
                (directionVector.y > stopAnimation || directionVector.y < -stopAnimation) ||
           (directionVector.z > stopAnimation || directionVector.z < -stopAnimation))
        {
            Walk();
            GetComponent<Rigidbody>().velocity = directionVector * speed;
        }
        else
        {
            Idle();
        }
    }

    void Walk()
    {
        player.GetComponent<Animator>().SetBool("Idle", false);
        player.GetComponent<Animator>().SetBool("Walk", true);
    }

    void Idle()
    {
        player.GetComponent<Animator>().SetBool("Walk", false);
        player.GetComponent<Animator>().SetBool("Idle", true);
    }

    void Update()
    {
    }
}
