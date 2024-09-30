using Sirenix.OdinInspector;
using UnityEngine;
namespace TCS.SimpleScripts.Manipulators {
    /// <summary>
    /// This class allows a GameObject with a CharacterController to push Rigidbodies.
    /// </summary>
    [RequireComponent(typeof(CharacterController))]
    [AddComponentMenu("TCS/SimpleScripts/Manipulators/Simple Rigidbody Push")]
    public class SimpleRigidBodyPush : MonoBehaviour {
        [Tooltip("Layers that can be pushed.")]
        [SerializeField] LayerMask m_pushLayers;

        [Tooltip("Strength of the push force.")]
        [SerializeField, Range(0.5f, 5f)] public float m_strength = 1.1f;

        [Tooltip("Indicates whether the GameObject can push other Rigidbodies.")]
        [ShowInInspector] public bool CanPush { get; private set; } = true;

        /// <summary>
        /// Sets the setDialogueManager indicating whether the GameObject can push other Rigidbodies.
        /// </summary>
        /// <param name="value">True if the GameObject can push other Rigidbodies, false otherwise.</param>
        public void SetCanPush(bool value) => CanPush = value;

        /// <summary>
        /// Called when the controller hits a collider while performing a Move.
        /// </summary>
        /// <param name="hit">Information about the collision.</param>
        void OnControllerColliderHit(ControllerColliderHit hit) {
            if (CanPush) PushRigidBodies(hit);
        }

        /// <summary>
        /// Applies a force to push the Rigidbody if it is valid.
        /// </summary>
        /// <param name="hit">Information about the collision.</param>
        void PushRigidBodies(ControllerColliderHit hit) {
            if (!IsValidRigidBody(hit.collider.attachedRigidbody, hit.moveDirection.y, m_pushLayers.value))
                return;

            var pushDir = CalculatePushDirection(hit.moveDirection);
            hit.collider.attachedRigidbody.AddForce(pushDir * m_strength, ForceMode.Impulse);
        }

        /// <summary>
        /// Checks if the Rigidbody can be pushed.
        /// </summary>
        /// <param name="body">The Rigidbody to check.</param>
        /// <param name="moveDirectionY">The y component of the move direction.</param>
        /// <param name="pushLayers">The layers that can be pushed.</param>
        /// <returns>True if the Rigidbody can be pushed, false otherwise.</returns>
        static bool IsValidRigidBody(Rigidbody body, float moveDirectionY, LayerMask pushLayers) {
            if (body == null || body.isKinematic)
                return false;

            int bodyLayerMask = 1 << body.gameObject.layer;
            if ((bodyLayerMask & pushLayers) == 0)
                return false;

            return !(moveDirectionY < -0.3f);
        }

        /// <summary>
        /// Calculates the direction to push the Rigidbody.
        /// </summary>
        /// <param name="moveDirection">The move direction of the controller.</param>
        /// <returns>The direction to push the Rigidbody.</returns>
        static Vector3 CalculatePushDirection(Vector3 moveDirection) => new Vector3(moveDirection.x, 0.0f, moveDirection.z);
    }
}