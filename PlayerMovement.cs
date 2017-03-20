using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public float moveSpeed;
    private float maxSpeed=5;
    private Vector3 input;
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //getAxisRaw means that there is no incrementale speed, to have gradual build up, use getAxis
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        print(input);
        //If the movement speed is less than the maxspeed than it increments
        if (GetComponent<Rigidbody>().velocity.magnitude < maxSpeed) {

            GetComponent<Rigidbody>().AddForce(input * moveSpeed);
        }
        
    }
}
