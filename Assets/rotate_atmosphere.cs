using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;

public class rotate_atmosphere : MonoBehaviour
{
    public GameObject objectToRotate;
    Quaternion targetRotation;

    private void Update()
    {
        CheckRotation();
    }

    void CheckRotation()
    {
        targetRotation = Quaternion.Euler(objectToRotate.transform.eulerAngles.x, objectToRotate.transform.eulerAngles.y + 0.015f, objectToRotate.transform.eulerAngles.z);

        objectToRotate.transform.rotation = targetRotation;
    }
}
