using UnityEngine;
namespace TCS.SimpleScripts
{
    public class SimpleRotateObject : MonoBehaviour {
        enum RotationAxis {
            X,
            Y,
            Z
        }
        
        /// <summary>
        /// The axis around which the object will rotate.
        /// </summary>
        [Tooltip("The axis around which the object will rotate.")]
        [SerializeField] RotationAxis m_rotationAxis = RotationAxis.Y;

        /// <summary>
        /// The speed at which the object will rotate.
        /// </summary>
        [Tooltip("The speed at which the object will rotate.")]
        [SerializeField] float m_rotationSpeed = 1f;

        /// <summary>
        /// If true, the rotation direction will be reversed.
        /// </summary>
        [Tooltip("If true, the rotation direction will be reversed.")]
        [SerializeField] bool m_reverse;
        
        float m_currentRotationAngle;
        
        void Update() => RotateObject();
        
        void RotateObject()
        {
            var axis = GetRotationAxis();
            float speed = GetRotationSpeed();
            
            UpdateRotationAngle(speed);
            ApplyRotation(axis);
        }

        /// <summary>
        /// Gets the rotation axis based on the selected enum setDialogueManager.
        /// </summary>
        /// <returns>A Vector3 representing the rotation axis.</returns>
        Vector3 GetRotationAxis()
        {
            return m_rotationAxis switch
            {
                RotationAxis.X => Vector3.right,
                RotationAxis.Y => Vector3.up,
                RotationAxis.Z => Vector3.forward,
                _ => Vector3.zero
            };
        }

        /// <summary>
        /// Gets the rotation speed, taking into account whether the rotation is reversed.
        /// </summary>
        /// <returns>The rotation speed as a float.</returns>
        float GetRotationSpeed() 
            => m_reverse ? -m_rotationSpeed * Time.deltaTime : m_rotationSpeed * Time.deltaTime;

        /// <summary>
        /// Updates the current rotation angle based on the speed.
        /// </summary>
        /// <param name="speed">The speed at which to rotate the object.</param>
        void UpdateRotationAngle(float speed) {
            m_currentRotationAngle += speed;
            if (Mathf.Abs(m_currentRotationAngle) >= 360f) {
                m_currentRotationAngle = 0f;
            }
        }

        /// <summary>
        /// Applies the rotation to the object based on the current rotation angle and axis.
        /// </summary>
        /// <param name="axis">The axis around which to rotate the object.</param>
        void ApplyRotation(Vector3 axis) {
            transform.localRotation = Quaternion.AngleAxis(m_currentRotationAngle, axis);
        }
    }
}