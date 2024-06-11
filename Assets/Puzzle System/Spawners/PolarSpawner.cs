using UnityEngine;

namespace SpawningTools
{
    [RequireComponent(typeof(ObjectPool))]
    public class PolarSpawner : MonoBehaviour
    {
        public ObjectPool objectPool;
        public float radius;

        // Function to instantiate an object at a random point within the bounds of a circle
        public void SpawnObjectAtRandomPoint()
        {
            SpawnObjectAtAngleAndRadius(gameObject.transform.position, Random.Range(0, radius), Random.Range(0, 360));
        }

        // Function to instantiate an object at radius and angle away from an origin point
        public GameObject SpawnObjectAtAngleAndRadius(Vector3 origin, float radius, float angle)
        {
            // Convert angle from degrees to radians
            angle *= Mathf.Deg2Rad;

            // Get an object out of the object pool
            GameObject newObject = objectPool.Withdraw();
            newObject.transform.parent = this.gameObject.transform;

            // Calculate new position
            Vector3 newPos = Vector3.zero;
            newPos.x = origin.x + (radius * Mathf.Cos(angle));
            newPos.y = origin.y;
            newPos.z = origin.z + (radius * Mathf.Sin(angle));

            // Set the new position and activate the object
            newObject.transform.position = newPos;
            newObject.transform.rotation = Quaternion.identity;
            newObject.SetActive(true);

            return newObject;
        }
    }
}
