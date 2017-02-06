using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Joystick2DController : MonoBehaviour {

    private Rigidbody2D body;

    public float moveForce = 5;

	// Use this for initialization
	//Alterado da web
    //Alterado na aula
	void Start () {
        this.body = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {
        Vector2 moveVector = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal") * moveForce, CrossPlatformInputManager.GetAxis("Vertical") * moveForce);
        body.AddForce(moveVector);
	}
}
