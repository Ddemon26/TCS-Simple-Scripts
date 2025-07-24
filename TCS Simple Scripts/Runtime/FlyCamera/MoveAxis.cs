using System;
using UnityEngine;
using UnityEngine.Serialization;
namespace TCS.SimpleScripts.FlyCamera {
    /// <summary>
    /// Represents an axis of movement, with positive and negative directions.
    /// </summary>
    [Serializable]
    public class MoveAxis
    {
        /// <summary>
        /// The key that represents positive movement along the axis.
        /// </summary>
        [FormerlySerializedAs("Positive")]
        public KeyCode m_positive;

        /// <summary>
        /// The key that represents negative movement along the axis.
        /// </summary>
        [FormerlySerializedAs("Negative")]
        public KeyCode m_negative;

        /// <summary>
        /// Creates a new MoveAxis with the specified positive and negative keys.
        /// </summary>
        /// <param name="positive">The key that represents positive movement along the axis.</param>
        /// <param name="negative">The key that represents negative movement along the axis.</param>
        public MoveAxis(KeyCode positive, KeyCode negative)
        {
            m_positive = positive;
            m_negative = negative;
        }

        /// <summary>
        /// Implicitly converts a MoveAxis to a float, representing the current state of movement along the axis.
        /// </summary>
        /// <param name="axis">The MoveAxis to convert.</param>
        public static implicit operator float(MoveAxis axis)
        {
            return (Input.GetKey(axis.m_positive)
                       ? 1.0f : 0.0f) -
                   (Input.GetKey(axis.m_negative)
                       ? 1.0f : 0.0f);
        }
    }
}