using UnityEngine;
using System.Collections;

public class BallForce : MonoBehaviour
{
    private const float MAX_STRENGTH = 500.0f;

    private bool start = false;
    private float strength;
    private Rigidbody rb;

    public void Awake()
    {
        strength = 0.0f;
        rb = GetComponent<Rigidbody>();
    }

    // Use this for initialization
    public void Start ()
    {}

    // Update is called once per frame
    public void Update()
    {
        // Increment the force strength while mouse button is pressed
        if (!start && Input.GetMouseButton(0)) {
            strength += 5.0f; 
            strength = Mathf.Min(MAX_STRENGTH, strength);
        }

        if (!start && Input.GetMouseButtonUp(0)) {

            // Add force in the direction of Up vector of the "arrow"
            // The "arrow" is rotated 90 degrees on Y so it can be horizontal
            rb.AddForce(transform.GetChild(0).up * strength);
            start = true;

            // Destroy the "arrow"
            Destroy(transform.GetChild(0).gameObject);
        }
    }
}
