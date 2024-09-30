using UnityEngine;
namespace TCS.SimpleScripts.FlyCamera {
    /// <summary>
    /// Represents the state of a camera in 3D space.
    /// </summary>
    internal class CameraState {
        /// <summary>
        /// The yaw of the camera (rotation around the y-axis).
        /// </summary>
        public float Yaw;

        /// <summary>
        /// The pitch of the camera (rotation around the x-axis).
        /// </summary>
        public float Pitch;

        /// <summary>
        /// The roll of the camera (rotation around the z-axis).
        /// </summary>
        public float Roll;

        /// <summary>
        /// The x position of the camera.
        /// </summary>
        public float X;

        /// <summary>
        /// The y position of the camera.
        /// </summary>
        public float Y;

        /// <summary>
        /// The z position of the camera.
        /// </summary>
        public float Z;

        /// <summary>
        /// Sets the state from a Transform.
        /// </summary>
        /// <param name="t">The Transform to set the state from.</param>
        public void SetFromTransform(Transform t) {
            Pitch = t.eulerAngles.x;
            Yaw = t.eulerAngles.y;
            Roll = t.eulerAngles.z;
            X = t.position.x;
            Y = t.position.y;
            Z = t.position.z;
        }

        /// <summary>
        /// Translates the camera state by a Vector3.
        /// </summary>
        /// <param name="translation">The Vector3 to translate the camera state by.</param>
        public void Translate(Vector3 translation) {
            var rotatedTranslation = Quaternion.Euler(Pitch, Yaw, Roll) * translation;

            X += rotatedTranslation.x;
            Y += rotatedTranslation.y;
            Z += rotatedTranslation.z;
        }

        /// <summary>
        /// Lerps the camera state towards a target state.
        /// </summary>
        /// <param name="target">The target camera state to lerp towards.</param>
        /// <param name="positionLerpPct">The percentage to lerp the position by.</param>
        /// <param name="rotationLerpPct">The percentage to lerp the rotation by.</param>
        public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct) {
            Yaw = Mathf.Lerp(Yaw, target.Yaw, rotationLerpPct);
            Pitch = Mathf.Lerp(Pitch, target.Pitch, rotationLerpPct);
            Roll = Mathf.Lerp(Roll, target.Roll, rotationLerpPct);

            X = Mathf.Lerp(X, target.X, positionLerpPct);
            Y = Mathf.Lerp(Y, target.Y, positionLerpPct);
            Z = Mathf.Lerp(Z, target.Z, positionLerpPct);
        }

        /// <summary>
        /// Updates a Transform to match the camera state.
        /// </summary>
        /// <param name="t">The Transform to update.</param>
        public void UpdateTransform(Transform t) {
            t.eulerAngles = new Vector3(Pitch, Yaw, Roll);
            t.position = new Vector3(X, Y, Z);
        }
    }
}