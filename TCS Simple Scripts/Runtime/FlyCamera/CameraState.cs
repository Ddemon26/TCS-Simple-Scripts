using UnityEngine;
namespace TCS.SimpleScripts
{
    /// <summary>
    /// Represents the state of a camera in 3D space.
    /// </summary>
    class CameraState
    {
        /// <summary>
        /// The yaw of the camera (rotation around the y-axis).
        /// </summary>
        public float yaw;

        /// <summary>
        /// The pitch of the camera (rotation around the x-axis).
        /// </summary>
        public float pitch;

        /// <summary>
        /// The roll of the camera (rotation around the z-axis).
        /// </summary>
        public float roll;

        /// <summary>
        /// The x position of the camera.
        /// </summary>
        public float x;

        /// <summary>
        /// The y position of the camera.
        /// </summary>
        public float y;

        /// <summary>
        /// The z position of the camera.
        /// </summary>
        public float z;

        /// <summary>
        /// Sets the state from a Transform.
        /// </summary>
        /// <param name="t">The Transform to set the state from.</param>
        public void SetFromTransform(Transform t)
        {
            pitch = t.eulerAngles.x;
            yaw = t.eulerAngles.y;
            roll = t.eulerAngles.z;
            x = t.position.x;
            y = t.position.y;
            z = t.position.z;
        }

        /// <summary>
        /// Translates the camera state by a Vector3.
        /// </summary>
        /// <param name="translation">The Vector3 to translate the camera state by.</param>
        public void Translate(Vector3 translation)
        {
            Vector3 rotatedTranslation = Quaternion.Euler(pitch, yaw, roll) * translation;

            x += rotatedTranslation.x;
            y += rotatedTranslation.y;
            z += rotatedTranslation.z;
        }

        /// <summary>
        /// Lerps the camera state towards a target state.
        /// </summary>
        /// <param name="target">The target camera state to lerp towards.</param>
        /// <param name="positionLerpPct">The percentage to lerp the position by.</param>
        /// <param name="rotationLerpPct">The percentage to lerp the rotation by.</param>
        public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
        {
            yaw = Mathf.Lerp(yaw, target.yaw, rotationLerpPct);
            pitch = Mathf.Lerp(pitch, target.pitch, rotationLerpPct);
            roll = Mathf.Lerp(roll, target.roll, rotationLerpPct);

            x = Mathf.Lerp(x, target.x, positionLerpPct);
            y = Mathf.Lerp(y, target.y, positionLerpPct);
            z = Mathf.Lerp(z, target.z, positionLerpPct);
        }

        /// <summary>
        /// Updates a Transform to match the camera state.
        /// </summary>
        /// <param name="t">The Transform to update.</param>
        public void UpdateTransform(Transform t)
        {
            t.eulerAngles = new Vector3(pitch, yaw, roll);
            t.position = new Vector3(x, y, z);
        }
    }
}