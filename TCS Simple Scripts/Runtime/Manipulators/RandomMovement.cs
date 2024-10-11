using UnityEngine;
namespace TCS.SimpleScripts.Manipulators {
    [AddComponentMenu("TCS/SimpleScripts/Manipulators/RandomMovement")]
    public class RandomMovement : MonoBehaviour {
        // Customizable settings exposed to the Unity Inspector
        [Header("Movement Settings")]
        public Vector3 m_movementOffset = Vector3.one * 0.2f; // Initial offset of the movement
        public Vector3 m_amplitude = new Vector3(1f, 0.5f, 1f); // Amplitude of movement in each direction
        public Vector3 m_frequency = new Vector3(2f, 3f, 5f); // Frequency for each axis
        public float m_movementSpeed = 1f; // Overall speed multiplier
        public float m_movementScale = 1f / 3f; // Scaling factor for movement

        void Update() {
            // Use Time.time * movementSpeed to control the speed of movement
            transform.position = m_movementOffset + new Vector3
            (
                Mathf.Sin(Mathf.Sin(Time.time * m_movementSpeed / m_frequency.x) * Mathf.PI) * m_amplitude.x,
                (Mathf.Cos(Mathf.Sin(Time.time * m_movementSpeed / m_frequency.y) * Mathf.PI) + 1f) / 2f * m_amplitude.y,
                Mathf.Sin(Mathf.Sin(Time.time * m_movementSpeed / m_frequency.z) * Mathf.PI) * m_amplitude.z
            ) * m_movementScale; // Apply the overall scaling factor
        }
    }
}