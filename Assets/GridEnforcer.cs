using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GridEnforcer : MonoBehaviour
{
    public List<GameObject> objectsOnGrid = new List<GameObject>();
    private bool enforcingGrid = false;

    public void EnforceGrid()
    {
        if(enforcingGrid == false)
        {
            StartCoroutine(EnforceGridSlow());
        }
    }

    private IEnumerator EnforceGridSlow()
    {
        enforcingGrid = true;
        yield return new WaitForSeconds(0.1f);
        foreach (GameObject obj in objectsOnGrid)
        {
            if (obj != null)
            {
                obj.transform.position = gridPosition(obj.transform.position);
                // obj.transform.rotation = Quaternion.identity;
            }
        }
        enforcingGrid = false;
        yield return null;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            {
                if (other.CompareTag("GridObject"))
                {
                    if (!objectsOnGrid.Contains(other.gameObject))
                    {
                        objectsOnGrid.Add(other.gameObject);
                    }
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other != null)
        {
            {
                if (other.CompareTag("GridObject"))
                {
                    if (objectsOnGrid.Contains(other.gameObject))
                    {
                        objectsOnGrid.Remove(other.gameObject);
                    }
                }
            }
        }
    }

    // Round the Vector3 to the nearest 10th, and return that
    public static Vector3 gridPosition(Vector3 originalPosition)
    {
        return new Vector3(Mathf.RoundToInt(originalPosition.x * 10) / 10.0f, Mathf.RoundToInt(originalPosition.y * 10) / 10.0f, Mathf.RoundToInt(originalPosition.z * 10) / 10.0f);
    }
}
