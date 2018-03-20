﻿//#####################################################################################
//#####################################################################################
//#####################################################################################
// XBOX 360 CONTROLLER CODE SETUP FOR THE UNITY 3D ENGINE IN C SHARP
// THIS HAS BEEN WRITTEN BY KYLE D'AOUST FOR FREE AND EDUCATIONAL USE, ROYALTY FREE.
// FEEL FREE TO USE THIS CODE IN ANY OF YOUR PROJECTS
//#####################################################################################
//#####################################################################################
//#####################################################################################

using UnityEngine;
using System.Collections;

public class Xbox360_Controls_CSHARP : MonoBehaviour 
{
	// These are used to modify the player movement speed, and rotation speed.
	public float moveSpeed = 3.0f;
	public float PlayerRotationSpeed = 180;
	public float gravity = 9.81f;
	//private CharacterController myController;

	// Use this for initialization
	void Start () {
		// store a reference to the CharacterController component on this gameObject
		// it is much more efficient to use GetComponent() once in Start and store
		// the result rather than continually use etComponent() in the Update function
		//myController = gameObject.GetComponent<CharacterController>();
	}

	// I seperated Movement and Button inputs into seperate functions, it makes for easier debugging
	void Update ()
	{
		

		// Determine how much should move in the z-direction
		Vector3 movementZ = Input.GetAxis("Vertical") * Vector3.forward * moveSpeed * Time.deltaTime;

		// Determine how much should move in the x-direction
		Vector3 movementX = Input.GetAxis("Horizontal") * Vector3.right * moveSpeed * Time.deltaTime;

		// Convert combined Vector3 from local space to world space based on the position of the current gameobject (player)
		Vector3 movement = transform.TransformDirection(movementZ+movementX);

		// Apply gravity (so the object will fall if not grounded)
		movement.y -= gravity * Time.deltaTime;

		Debug.Log ("Movement Vector = " + movement);

		Movement();
		UserInputs();
	}

	// This function handles the Movement calculations. You can adjust the code to work with different AXES if preferred.
	// Right Thumbstick uses the 4th(Vertical) and 5th(Horizontal) Input Joystick Axes, and the Left Thumbstick uses the X(Horizontal) and Y(Vertical) Input Joystick Axes.
	// For movement the Vertical Axis is read from moving the LEFT THUMBSTICK up and down,
	// the Horizontal Axis is read from moving the LEFT THUMBSTICK left and right.
	// For Rotation I have it reading from the RIGHT THUMBSTICK.
	void Movement()
	{
		// This line is for vertical movement, right now its on the Z AXIS.
		transform.Translate(0,0,Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed);

		// This line is for horizontal movement, right now its on the X AXIS. When combined with vertical movement it can be used for Strafing.
		transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed,0,0);

		// This line is for rotation, right now its on the Y AXIS. 
		transform.Rotate(0,Input.GetAxis("RightStick") * Time.deltaTime * PlayerRotationSpeed,0);
	}

	// This function handles the Inputs from the buttons on the controller
	void UserInputs()
	{
		// A Button is read from Input Positive Button "joystick button 0"
		if(Input.GetButtonDown ("360_AButton"))
		{
			Debug.Log("A Button!");
		}

		// B Button is read from Input Positive Button "joystick button 1"
		if(Input.GetButtonDown ("360_BButton"))
		{
			Debug.Log("B Button!");
		}

		// X Button is read from Input Positive Button "joystick button 2"
		if(Input.GetButtonDown ("360_XButton"))
		{
			Debug.Log("X Button!");
		}

		// Y Button is read from Input Positive Button "joystick button 3"
		if(Input.GetButtonDown ("360_YButton"))
		{
			Debug.Log("Y Button!");
		}

		// Left Bumper is read from Input Positive Button "joystick button 4"
		if(Input.GetButtonDown ("360_LeftBumper"))
		{
			Debug.Log("Left Bumper!");
		}

		// Right Bumper is read from Input Positive Button "joystick button 5"
		if(Input.GetButtonDown ("360_RightBumper"))
		{
			Debug.Log("Right Bumper!");
		}

		// Back Button is read from Input Positive Button "joystick button 6"
		if(Input.GetButtonDown ("360_BackButton"))
		{
			Debug.Log("Back Button!");
		}

		// Start Button is read from Input Positive Button "joystick button 7"
		if(Input.GetButtonDown ("360_StartButton"))
		{
			Debug.Log("Start Button!");
		}

		// Left Thumbstick Button is read from Input Positive Button "joystick button 8"
		if(Input.GetButtonDown ("360_LeftThumbstickButton"))
		{
			Debug.Log("Left Thumbstick Button!");
		}

		// Right Thumbstick Button is read from Input Positive Button "joystick button 9"
		if(Input.GetButtonDown ("360_RightThumbstickButton"))
		{
			Debug.Log("Right Thumbstick Button!");
		}

		// Triggers are read from the 3rd Joystick Axis and read from a Sensitivity rating from -1 to 1
		//
		// Right Trigger is activated when pressure is above 0, or the dead zone.
		if(Input.GetAxis("360_Triggers")>0.001)
		{
			Debug.Log ("Right Trigger!");
		}

		// Right Trigger is activated when pressure is under 0, or the dead zone.
		if(Input.GetAxis("360_Triggers")<0)
		{
			Debug.Log("Left Trigger!");
		}

		// The D-PAD is read from the 6th(Horizontal) and 7th(Vertical) Joystick Axes and read from a Sensitivity rating from -1 to 1, similar to the Triggers.
		//
		// Right D-PAD Button is activated when pressure is above 0, or the dead zone.
		if(Input.GetAxis("360_HorizontalDPAD")>0.001)
		{
			Debug.Log ("Right D-PAD Button!");
		}

		// Left D-PAD Button is activated when pressure is under 0, or the dead zone.
		if(Input.GetAxis("360_HorizontalDPAD")<0)
		{
			Debug.Log("Left D-PAD Button!");
		}

		// Up D-PAD Button is activated when pressure is above 0, or the dead zone.
		if(Input.GetAxis("360_VerticalDPAD")>0.001)
		{
			Debug.Log ("Up D-PAD Button!");
		}

		// Down D-PAD Button is activated when pressure is under 0, or the dead zone.
		if(Input.GetAxis("360_VerticalDPAD")<0)
		{
			Debug.Log("Down D-PAD Button!");
		}
	}
}