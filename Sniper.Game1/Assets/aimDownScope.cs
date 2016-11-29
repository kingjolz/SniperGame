using UnityEngine;
using System.Collections;

public class aimDownScope : MonoBehaviour {

    public Vector3 aimDownSight;
    public Vector3 hipFire;
	
	void Update ()
    {
        if (Input.GetMouseButton(1))
        {
            transform.localPosition = Vector3.Slerp(transform.localPosition, aimDownSight, 10 * Time.deltaTime);
        }
        if (Input.GetMouseButtonUp(1))
        {
            transform.localPosition = hipFire;
        }
    }
}
