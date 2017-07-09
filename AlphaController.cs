using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaController : MonoBehaviour {

    private MeshRenderer meshrender;
    public float test = 0;
    // Use this for initialization
    void Start () {
        meshrender = GetComponent<MeshRenderer>();
        meshrender.material.color = new Color(meshrender.material.color.r, meshrender.material.color.g, meshrender.material.color.b, 1.0f);  
    }
	
	// Update is called once per frame
	void Update () {
        meshrender.material.color = new Color(meshrender.material.color.r, meshrender.material.color.g, meshrender.material.color.b, test);
    }
}
