using System.Collections;
using System.Collections.Generic;
using UnityEngine.Assertions;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterControllerBehaviour : MonoBehaviour {

    private CharacterController _characterController;

	// Use this for initialization
	void Start () {
        _characterController = GetComponent<CharacterController>();
#if DEBUG
        Assert.IsNotNull(_characterController, "amai goe kees,geen characterController");
#endif
    }
	
	// Update is called once per frame
	void Update () {
		
	}


}
