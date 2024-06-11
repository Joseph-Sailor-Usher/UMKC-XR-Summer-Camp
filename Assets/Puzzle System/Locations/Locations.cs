using System.Collections.Generic;
using UnityEngine;

namespace PuzzleSystem
{
    public class Locations : MonoBehaviour {
        public List<Transform> locations = new List<Transform>();
        public void PopulateFromChildObjects() {
            locations.Clear();
            foreach(Transform child in transform)
                locations.Add(child);
        }
    }
}