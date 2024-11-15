using UnityEngine;
using UnityEngine.Animations;

namespace TCS.SimpleScripts.Manipulators {
    [AddComponentMenu("TCS/SimpleScripts/Manipulators/AssignAimConstraint")]
    [RequireComponent(typeof(AimConstraint))]
    public class AssignAimConstraint : MonoBehaviour {
        [Tooltip("The AimConstraint component to be assigned.")]
        [SerializeField] AimConstraint m_aimConstraint;
        [Tooltip("The tag of the camera to be assigned as the source of the AimConstraint.")]
        [SerializeField] string m_cameraTag = "MainCamera";
        
        [SerializeField] bool m_activateAimConstraintOnStart = true;

        // void OnValidate() {
        //     if (m_aimConstraint == null) {
        //         m_aimConstraint = GetComponent<AimConstraint>();
        //     }
        // }

        void Awake() {
            m_aimConstraint = GetComponent<AimConstraint>();
            SetSource();
        }

        void Start() => ActivateAimConstraint(m_activateAimConstraintOnStart);

        void SetSource() {
            if (!m_aimConstraint) return;
            var source = new ConstraintSource
            {
                sourceTransform = GameObject.FindGameObjectWithTag(m_cameraTag).transform,
                weight = 1,
            };

            m_aimConstraint.AddSource(source);
            m_aimConstraint.SetSource(0, source);
        }

        public void ActivateAimConstraint(bool value) {
            if (m_aimConstraint) {
                m_aimConstraint.constraintActive = value;
            }
        }
    }
}