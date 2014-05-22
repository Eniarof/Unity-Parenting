using UnityEngine;
using System.Collections;

public class Attach : MonoBehaviour
{

		void OnCollisionEnter (Collision other)
		{
	
				if (other.gameObject.name != "Plane") {
		
						other.gameObject.transform.parent = this.transform;
						
						Vector3 otherPosition = other.transform.localPosition;
						otherPosition *= 0.5f;
						other.transform.localPosition = otherPosition;
		
				}
	
		}

}
