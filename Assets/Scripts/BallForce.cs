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
        if (Input.touches[0].position.y < Screen.height / 2)
        {
            // Increment the force strength while mouse button is pressed
            if (!start && (Input.GetMouseButton(0) || Input.GetTouch(0).phase == TouchPhase.Ended))
            {
                strength += 5.0f;
                strength = Mathf.Min(MAX_STRENGTH, strength);
            }

            if (!start && Input.GetTouch(0).phase == TouchPhase.Ended)
            {

                // Add force in the direction of Up vector of the "arrow"
                // The "arrow" is rotated 90 degrees on Y so it can be horizontal
                rb.AddForce(transform.GetChild(0).up * strength);
                start = true;

                // Destroy the "arrow"
                Destroy(transform.GetChild(0).gameObject);
            }
        }
    }
}
