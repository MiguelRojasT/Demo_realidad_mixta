using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour {

    public float speed = 0;
    GameObject palanca;

   // Use this for initialization
   void Start () {
        palanca = GameObject.Find("EsferaControl");
    }
	
	// Update is called once per frame
	void Update () {
        speed = palanca.transform.position.x;
        speed = (float)(speed-98.5) * 300;

        transform.Rotate(new Vector3(1,0,1),speed*Time.deltaTime);
	}
}
