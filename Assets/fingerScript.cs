using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fingerScript : MonoBehaviour
{

    public bool animation_bool;
    public Animation animation;
    public GameObject finger;
    private bool move;
    private float speed= 1;
    new Vector3 originalSpot;
    new float maxHeight;
    private int mPPro = 0;

    // Start is called before the first frame update
    void Start()
    {
        move = false;
        originalSpot = new Vector3(finger.transform.localPosition.x, finger.transform.localPosition.y, finger.transform.localPosition.z);
        maxHeight = finger.transform.localPosition.y + 0.001f;
    }


    void FixedUpdate()
    {


        if (Input.GetKey(KeyCode.F))
        {
            if (mPPro <= 3)
            {
                finger.transform.localPosition = Vector3.Slerp(finger.transform.localPosition, new Vector3(0, 0.2f, 0), 0.08f);
                Debug.Log("flipping");
                mPPro += 1;
            }
        }
        else {
            finger.transform.localPosition = Vector3.Slerp(originalSpot, new Vector3(0, 0.3f, 0), 0.07f);
            if(mPPro >= 0) { mPPro -= 2; }
        }

        


    }
}
