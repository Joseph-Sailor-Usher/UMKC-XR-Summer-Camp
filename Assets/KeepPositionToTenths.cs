using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepPositionToTenths : MonoBehaviour
{
    public void Round()
    {
        Vector3 temp = transform.position;
        temp.x = Mathf.Round((temp.x * 10)) / 10;
        temp.y = Mathf.Round((temp.y * 10)) / 10;
        temp.z = Mathf.Round((temp.z * 10)) / 10;
    }
}
