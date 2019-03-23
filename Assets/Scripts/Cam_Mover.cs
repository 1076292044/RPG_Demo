using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Mover : MonoBehaviour
{
    public float X_mov = 0f;
    public float Y_mov = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        X_mov = Input.GetAxis("Horizontal");
        Y_mov = Input.GetAxis("Vertical");

        Debug.Log(X_mov + "X_mov");
        Debug.Log(Y_mov + "Y_mov");

        Vector2 CamMove_Vec = new Vector2(X_mov, Y_mov);


        transform.Translate(CamMove_Vec);
    }
}
