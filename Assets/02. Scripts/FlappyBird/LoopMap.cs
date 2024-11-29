using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopMap : MonoBehaviour
{

    private SpriteRenderer sp;
    public float offsetSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float offsetVal = offsetSpeed * Time.deltaTime;
        sp.material.SetTextureOffset("_MainTex", sp.material.mainTextureOffset + new Vector2(offsetVal, 0f));

    }
}
