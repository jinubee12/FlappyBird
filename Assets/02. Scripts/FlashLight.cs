using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public GameObject spotLight;
    public bool isOn = false;
    // Update is called once per frame

    private void Start()
    {
        spotLight.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isOn = !isOn;
            spotLight.SetActive(isOn);
        }
    }
}
