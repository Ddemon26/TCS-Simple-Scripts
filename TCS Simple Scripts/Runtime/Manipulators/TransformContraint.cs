using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
namespace TentCitySoftware.utilities {
    [ExecuteAlways]
    [AddComponentMenu("TCS/SimpleScripts/Manipulators/Transform Contraint")]
    public class TransformContraint : MonoBehaviour {
        [Tooltip("The transform that will be constrained to the pivot transform.")]
        public Transform m_pivot;
        [Header("Constraints")]
        public Transform m_constraintA;
        public Transform m_constraintB;

        [Range(0f, 1f)]
        public float m_blendContraints = 0f;
        [Header("Blend Controls")]
        [Range(0f, 1f)]
        public float m_blendTotal = 0f;
        [Range(0f, 1f)]
        public float m_blendPosition = 0f;
        [Range(0f, 1f)]
        public float m_blendRotation = 0f;
        [Range(0f, 1f)]
        public float m_blendScale = 0f;

        Vector3 m_positionWs;
        Quaternion m_rotation;
        Vector3 m_scale = Vector3.one;

        public float m_dampening = 0.1f;
        Vector3 m_posVel;
        Quaternion m_rotVel;

        void OnEnable() {
            RenderPipelineManager.beginContextRendering += BeginFrame;
            RenderPipelineManager.endContextRendering += EndFrame;
        }

        void OnDisable() {
            RenderPipelineManager.beginContextRendering -= BeginFrame;
            RenderPipelineManager.endContextRendering -= EndFrame;
        }

        void Update() {
            // If we are in playmode we want to update the constraint every frame
            if (Application.isPlaying)
                UpdateConstraint();
        }

        /// <summary>
        /// When out of playmode we want ot still update the position of the Transform but not commit to it since
        /// it will dirty the scene with changes to the transforms position.
        /// </summary>
        /// <param name="context">Rendering Context, this is unused in this context</param>
        /// <param name="cameras">List of cameras, this is unused in this context</param>
        void BeginFrame(ScriptableRenderContext context, List<Camera> cameras) {
            if (!Application.isPlaying) {
                var transform1 = transform;
                m_positionWs = transform1.position;
                m_rotation = transform1.rotation;
                m_scale = transform1.localScale;
            }

            UpdateConstraint();
        }

        /// <summary>
        /// At the end of the frame, when not in Playmode we want to revert the transform back to its original state,
        /// doing this will not dirty the scene with changes to the transforms position.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="cameras"></param>
        void EndFrame(ScriptableRenderContext context, List<Camera> cameras) {
            if (Application.isPlaying) return;
            m_pivot.SetPositionAndRotation(m_positionWs, m_rotation);
            m_pivot.localScale = m_scale;
        }

        /// <summary>
        /// Updates the constraint transform based on the blend values between the two constraints.
        /// </summary>
        void UpdateConstraint() {
            if (!m_constraintA || !m_constraintB) return;

            var targetPosition = Vector3.Lerp(m_constraintA.position, m_constraintB.position, m_blendContraints);
            var targetRotation = Quaternion.Lerp(m_constraintA.rotation, m_constraintB.rotation, m_blendContraints);
            var targetScale = Vector3.Lerp(m_constraintA.lossyScale, m_constraintB.lossyScale, m_blendContraints);

            var pos = Vector3.Lerp(transform.position, targetPosition, m_blendTotal * m_blendPosition);
            var rot = Quaternion.Lerp(transform.rotation, targetRotation, m_blendTotal * m_blendRotation);

            m_pivot.SetPositionAndRotation
            (
                pos,
                rot
            );
            m_pivot.localScale = Vector3.Lerp(transform.localScale, targetScale, m_blendTotal * m_blendScale);
        }
    }
}