using UnityEngine;
using System.Collections;

public class DirectionDrag : MonoBehaviour
{
    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.RotateAround(transform.parent.position, Vector3.up, (Input.GetAxis("Mouse X")));
    }
}
