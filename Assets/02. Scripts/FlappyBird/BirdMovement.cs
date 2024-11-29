using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public SoundManager soundManager;
    private Rigidbody2D myRigid;
    public float JumpHeight = 10f;
    public float limitPower = 5f;

    public TMP_Text tmpText;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
        soundManager.OnMainBGM();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            myRigid.AddForce(Vector3.up * JumpHeight, ForceMode2D.Impulse);

            if (myRigid.velocity.y >= limitPower) 
                myRigid.velocity = new Vector3(myRigid.velocity.x, limitPower);
            soundManager.OnEventSound(2);
        }

        var playerEulerAngle = transform.eulerAngles;
        playerEulerAngle.z = myRigid.velocity.y * 5f;

        transform.eulerAngles = playerEulerAngle;

        timer += Time.deltaTime;
        tmpText.text = "Time : " + timer.ToString("F1") + "sec";
    }
}
