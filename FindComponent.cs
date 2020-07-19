using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindComponent : MonoBehaviour {

  // Canvas Object
  public Transform canvas;
  
  // Text Object
  public Text text;
  
  // Image Object
  public Image image;
  
	// Use this for initialization
	void Start () {
    // Find Canvas Transform
    canvas = GameObject.Find("Canvas").transform;
    
    // Find Text Component
    text = canvas.FindChild("Text").GetComponent<Text>();
    
    // Find Image Component
    image = canvas.FindChild("Image").GetComponent<Image>();
  }
  
	// Update is called once per frame
	void Update () {
      // When Key Press
      if (Input.GetButtonDown("Submit") || Input.GetButtonDown("Jump")) {
        // Do stuff
      }
  }
  
  

}
