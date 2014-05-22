using UnityEngine;
using System.Collections;

public class Drive : MonoBehaviour
{

		float force = 8.0f;
	
		// Update is called once per frame
		void Update ()
		{
				Vector3 heading = this.transform.position - Camera.main.transform.position;
		
				if (Input.GetKey ("e") && Input.GetKey ("i")) {
						this.rigidbody.AddForce (heading.normalized * force);
				}
				
				if (Input.GetKey ("d") && Input.GetKey ("k")) {
						this.rigidbody.AddForce (-heading.normalized * force);
				}
				
				if (Input.GetKey ("s") && Input.GetKey ("j")) {
						Vector3 left = Vector3.Cross (heading, Camera.main.transform.up).normalized * force;
						this.rigidbody.AddForce (left);
				}
				
				if (Input.GetKey ("f") && Input.GetKey ("l")) {
						Vector3 right = Vector3.Cross (heading, -Camera.main.transform.up).normalized * force;
						this.rigidbody.AddForce (right);
				}
	
		}
	
}
