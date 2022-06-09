using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector2 minPos;
    public Vector2 maxPos;

    public Transform followObj;
    public float speed = 1;


    private void FixedUpdate()
    {
        Vector3 targetPos = followObj.position;

        float xPos = Mathf.Clamp(targetPos.x, minPos.x, maxPos.x);
        float yPos = Mathf.Clamp(targetPos.y, minPos.y, maxPos.y);

        Vector3 boundPos = new Vector3(xPos, yPos, transform.position.z);

        Vector3 smoothT = Vector3.Lerp(transform.position, boundPos, Time.fixedDeltaTime * speed);
        transform.position = new Vector3(smoothT.x, smoothT.y, transform.position.z);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
