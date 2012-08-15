using UnityEngine;
using System;
using System.Collections;

public class CameraOrbit : MonoBehaviour {
  //public Transform m_myCamera;
  private Transform m_myTransform;
  private float speed = 20.0f;

	void Start () {
    m_myTransform = transform;
	  if (m_myTransform == null) 
    {
      throw new ArgumentNullException("m_myTransform");
    }  
	}
	
	void Update () {
    float trueSpeed = speed * Time.deltaTime;

    m_myTransform.Rotate(Input.GetAxis("Vertical")   * trueSpeed,
                         Input.GetAxis("Horizontal") * trueSpeed, 
                         0.0f);
	}
}
