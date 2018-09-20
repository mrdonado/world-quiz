using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthMovement : MonoBehaviour
{

  public Rigidbody rb;

  // Use this for initialization
  void Start()
  {


  }

  // Update is called once per frame
  void FixedUpdate()
  {

    rb.AddForce(0, 0, 1000 * Time.deltaTime);

  }
}

