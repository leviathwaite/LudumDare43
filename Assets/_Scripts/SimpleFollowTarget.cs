using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFollowTarget : MonoBehaviour
{
    public GameObject target;
    public Vector3 targetOffset;
    private GameObject cameraNode;

    // Start is called before the first frame update
    void Start()
    {
        cameraNode = FindChildWithTag(target.transform, "CameraNode");
    }

    private GameObject FindChildWithTag(Transform parent, string tag)
    {
        for (int i = 0; i < parent.childCount; i++)
        {
            Transform child = parent.GetChild(i);
            if (child.tag == tag)
            {
                return child.gameObject;
            }
        }
        return null;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = targetOffset + target.transform.position;
        transform.LookAt(cameraNode.transform.position);
    }
}
