﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HitRay : MonoBehaviour {

    public Transform Point;
    public GameObject Hole;
    float force = 2000f;
    public Slider slider;
    int remainingKills;

    // Use this for initialization
    void Start () {
        slider = GetComponent<Slider>();
	}

    // Update is called once per frame
    void Update()
    {

        Debug.DrawRay(Point.position, Point.forward * 10, Color.cyan);
       
    }
    public void fireSniper()
    {

        Ray ray = new Ray(Point.position, Point.forward);

        RaycastHit hit = new RaycastHit();

        if (Physics.Raycast(ray, out hit, 2000f))
        {
            if (hit.rigidbody)
            {
                hit.rigidbody.AddForceAtPosition(force * Point.forward, hit.point);
            }

            if (hit.transform.tag == "Enemy")
            {
                Destroy(hit.transform.gameObject);
                FindObjectOfType<score>().RegisterKill();
                
            }  
            

        }
        GameObject hole1;

        hole1 = Instantiate(Hole, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal)) as GameObject;
        hole1.transform.localRotation = hole1.transform.localRotation * Quaternion.Euler(0, Random.Range(-90, 90), 0);
        hole1.transform.parent = hit.transform;

        
       

        //Debug.Log("fired");
    }

}
