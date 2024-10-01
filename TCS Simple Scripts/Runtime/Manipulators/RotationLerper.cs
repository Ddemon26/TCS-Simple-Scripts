using UnityEngine;

namespace TCS.SimpleScripts.Manipulators {
    /// <summary>
    /// Utility struct to linearly interpolate between two Quaternion values. Allows for flexible linear interpolations
    /// where current and target change over time.
    /// </summary>
    public struct RotationLerper {
        // Calculated start for the most recent interpolation
        Quaternion m_lerpStart;

        // Calculated time elapsed for the most recent interpolation
        float m_currentLerpTime;

        // The duration of the interpolation, in seconds
        readonly float m_lerpTime;

        // Cache of the previous target to detect changes
        Quaternion m_previousTarget;

        public RotationLerper(Quaternion start, float lerpTime) {
            m_lerpStart = start;
            m_currentLerpTime = 0f;
            m_lerpTime = lerpTime;
            m_previousTarget = start;
        }

        /// <summary>
        /// Linearly interpolate between two Quaternion values.
        /// </summary>
        /// <param name="current"> Start of the interpolation. </param>
        /// <param name="target"> End of the interpolation. </param>
        /// <returns> A Quaternion value between current and target. </returns>
        public Quaternion LerpRotation(Quaternion current, Quaternion target) {
            // If the target has changed, reset the interpolation.
            if (target != m_previousTarget) {
                m_lerpStart = current;
                m_currentLerpTime = 0f;
                m_previousTarget = target;
            }

            // Increment the elapsed time
            m_currentLerpTime += Time.deltaTime;
            if (m_currentLerpTime > m_lerpTime) {
                m_currentLerpTime = m_lerpTime;
            }

            // Calculate the interpolation percentage
            float lerpPercentage = m_lerpTime > 0f ? m_currentLerpTime / m_lerpTime : 1f;

            // Return the interpolated Quaternion using Slerp
            return Quaternion.Slerp(m_lerpStart, target, lerpPercentage);
        }
    }
}