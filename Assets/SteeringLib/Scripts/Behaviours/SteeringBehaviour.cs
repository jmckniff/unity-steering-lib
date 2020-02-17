using UnityEngine;

namespace UnitySteeringLib
{
    public abstract class SteeringBehaviour
    {
        public SteeringAgent owner { get; protected set; }
        public SteeringBehaviour(SteeringAgent owner)
        {
            this.owner = owner;
        }
        public abstract Vector3 step();
    }
}