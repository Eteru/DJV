using UnityEngine;
using System.Collections;

public class DirectionDrag : MonoBehaviour
{

    protected float x;

    // Use this for initialization
    void Start ()
    {
        x = Screen.width / 2;
    }
	
	// Update is called once per frame
	void Update ()
    {
        float x = 0;
        if (Input.touches[0].position.y > Screen.height / 2)
        {
            if (Input.touches[0].position.x < Screen.width / 2)
            {
                x -= 0.1f;
            }
            else if (Input.touches[0].position.x > Screen.width / 2)
            {
                x += 0.1f;
            }
        }

        transform.RotateAround(transform.parent.position, Vector3.up, x);
    }
}
