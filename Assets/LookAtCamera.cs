﻿using UnityEngine;
using System.Collections;

public class LookAtCamera : MonoBehaviour {

	public Camera myCamera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.eulerAngles = Vector3.zero;
	
	}
}
