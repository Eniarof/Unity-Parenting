using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour
{

		GameObject katamari;
		
		float turnSpeed = 2.0f;

		// Use this for initialization
		void Start ()
		{
	
				katamari = GameObject.Find ("Katamari");
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
				this.transform.position = katamari.transform.position;
				
				if (Input.GetKey ("e") && Input.GetKey ("k")) {
						transform.Rotate (0, turnSpeed, 0);
				}
				
				if (Input.GetKey ("d") && Input.GetKey ("i")) {
						transform.Rotate (0, -turnSpeed, 0);
				}
	
		}
}
