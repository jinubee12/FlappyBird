using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotation : MonoBehaviour
{
    public Transform directionalLight;
    public float rotSpeed = 10f;
    // Update is called once per frame
    void Update()
    {
        directionalLight.Rotate(Vector3.right * rotSpeed * Time.deltaTime);
    }
}
