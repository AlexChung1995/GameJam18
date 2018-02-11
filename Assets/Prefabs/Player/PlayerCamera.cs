using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {
    //public GameObject Player;
    public float xSpeedMouse;
    public float ySpeedMouse;
    private float yaw = 0f;
    private float pitch = 0f;

    private const float yawActMax = 180f;
    private const float yawActMin = -180f;
    private const float pitchActMax = 90f;
    private const float pitchActMin = -90f;

    private float maxYaw = 180f;
    private float minYaw = -180f;
    private float maxPitch = 90f;
    private float minPitch = -90f;
    // Use this for initialization
    void Start () {
        Cursor.lockState = CursorLockMode.Locked;
        transform.localPosition = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        /*if (Input.GetButtonDown("Submit"))
        {
            if (Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }*/
        changeAngle();
	}

    private void changeAngle()
    {
        yaw += xSpeedMouse * Input.GetAxis("Mouse X");
        pitch -= ySpeedMouse * Input.GetAxis("Mouse Y");
        if (yaw > maxYaw) yaw = maxYaw;
        if (yaw > minYaw) yaw = minYaw;

        if (pitch > maxPitch) pitch = maxPitch;
        if (pitch < minPitch) pitch = minPitch;

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }

    public void restrictYaw(float max, float min)
    {
        if (max > yawActMax) max = yawActMax;
        this.maxYaw = max;
        if (min < yawActMin) min = yawActMin;
        this.minYaw = min;
    }

    public void restrictPitch(float max, float min)
    {
        if (max > pitchActMax) max = pitchActMax;
        this.maxPitch = max;
        if (min < pitchActMin) min = pitchActMin;
        this.minPitch = min;
    }



}
