using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class DragonControls : MonoBehaviour {

    // Use this for initialization

    public Transform Dragon;

    public float Speed =1.5f;
    public float rotationSpeed=75f;

    private void Start()
    {

    }

    void Update()
    {

        float translation=CrossPlatformInputManager.GetAxis("Vertical") * Speed;
        float rotation=CrossPlatformInputManager.GetAxis("Horizontal") * rotationSpeed;
        translation*=Time.deltaTime;
        rotation*=Time.deltaTime;
        Dragon.Translate(0,0,translation);
        Dragon.Rotate(0,rotation,0);
    }
}
