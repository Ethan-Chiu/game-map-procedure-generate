using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class world : MonoBehaviour {
    public map_creator worldcreat;
	// Use this for initialization
	void Start () {
        
        worldcreat.creator(5f, 5f, 50);

	}
	
	
}
