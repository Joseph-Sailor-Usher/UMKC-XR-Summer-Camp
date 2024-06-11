using System.Collections.Generic;
using UnityEngine;

namespace SpawningTools
{
    public class ObjectPool : MonoBehaviour
    {
        [Tooltip("The GameObjet this pool will contain")]
        public GameObject prefab;
        [Tooltip("The number of prefabs that will be instantiated in the pool")]
        public uint poolSize = 10;
        private Queue<GameObject> objects = new Queue<GameObject>();

        // Called when the gameobject becomes awake
        private void Awake()
        {
            // Ensure the objects Queue is non-null
            if (objects == null)
                objects = new();

            // Ensure the objects Queue is filled
            Refill();
        }

        // Function to withdraw an object form the pool
        public GameObject Withdraw()
        {
            // If queue has only 1 or fewer instances of the prefab object remaining
            if (objects.Count <= 1)
                Refill();
            
            // Return an instance of the prefab object
            return objects.Dequeue();
        }

        // Function to return an object to the pool
        public void Deposit(GameObject objectToReturn)
        {
            // If the object is already in the pool, do not add it again
            if (objects.Contains(objectToReturn))
                return;

            // Set the object to inactive
            objectToReturn.SetActive(false);

            // Enqueue it
            objects.Enqueue(objectToReturn);

            // Make this gameObject its parent
            objectToReturn.transform.parent = this.gameObject.transform;
        }

        // Function to add an object to the pool
        private void AddObject()
        {
            Deposit(Instantiate(prefab));
        }

        // Function to return the pool to the target size
        private void Refill()
        {
            while (objects.Count < poolSize)
                AddObject();
            while (objects.Count > poolSize)
                Destroy(Withdraw());
        }
    }
}
