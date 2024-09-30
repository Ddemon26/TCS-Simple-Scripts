using UnityEngine;
#if ENABLE_LEGACY_INPUT_MANAGER

namespace TCS.SimpleScripts.FlyCamera {
    /// <summary>
    /// A simple camera controller for moving and rotating the camera using keyboard and mouse input.
    /// </summary>
    public class SimpleCameraController : MonoBehaviour {
        /// <summary>
        /// Gets or sets the keys used for horizontal movement.
        /// </summary>
        [Header("Movement Settings"), Tooltip("The keys used for horizontal movement.")]
        [SerializeField] MoveAxis m_horizontal = new(KeyCode.D, KeyCode.A);

        /// <summary>
        /// Gets or sets the keys used for vertical movement.
        /// </summary>
        [Tooltip("The keys used for vertical movement.")]
        [SerializeField] MoveAxis m_vertical = new(KeyCode.W, KeyCode.S);

        /// <summary>
        /// Gets or sets the keys used for moving up and down.
        /// </summary>
        [Tooltip("The keys used for moving up and down.")]
        [SerializeField] MoveAxis m_upDown = new(KeyCode.E, KeyCode.Q);

        /// <summary>
        /// Gets or sets the exponential boost factor on translation, controllable by mouse wheel.
        /// </summary>
        [Tooltip("Exponential boost factor on translation, controllable by mouse wheel.")]
        [SerializeField] float m_boost = 3.5f;

        /// <summary>
        /// Gets or sets the time it takes to interpolate camera position 99% of the way to the target.
        /// </summary>
        [Tooltip("Time it takes to interpolate camera position 99% of the way to the target."), Range(0.001f, 1f)]
        [SerializeField] float m_positionLerpTime = 0.2f;

        /// <summary>
        /// Gets or sets the AnimationCurve for mouse sensitivity. X = Change in mouse position. Y = Multiplicative factor for camera rotation.
        /// </summary>
        [Header("Rotation Settings"), Tooltip("X = Change in mouse position.\nY = Multiplicative factor for camera rotation.")]
        [SerializeField] AnimationCurve m_mouseSensitivityCurve = new(new Keyframe(0f, 0.5f, 0f, 5f), new Keyframe(1f, 2.5f, 0f, 0f));

        /// <summary>
        /// Gets or sets the time it takes to interpolate camera rotation 99% of the way to the target.
        /// </summary>
        [Tooltip("Time it takes to interpolate camera rotation 99% of the way to the target."), Range(0.001f, 1f)]
        [SerializeField] float m_rotationLerpTime = 0.01f;

        /// <summary>
        /// Gets or sets a setDialogueManager indicating whether to keep the cursor locked.
        /// </summary>
        [Tooltip("Whether to keep the cursor locked.")]
        public bool KeepCursorLocked {
            get => m_keepCursorLocked;
            set {
                m_keepCursorLocked = value;
                if (m_keepCursorLocked) {
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                }
                else {
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                }
            }
        }
        [SerializeField] bool m_keepCursorLocked = false;

        /// <summary>
        /// Gets or sets a setDialogueManager indicating whether or not to invert our Y axis for mouse input to rotation.
        /// </summary>
        [Tooltip("Whether or not to invert our Y axis for mouse input to rotation.")]
        public bool m_invertY = false;

        readonly CameraState m_targetCameraState = new();
        readonly CameraState m_interpolatingCameraState = new();

        void OnEnable() {
            m_targetCameraState.SetFromTransform(transform);
            m_interpolatingCameraState.SetFromTransform(transform);

            if (!KeepCursorLocked) return;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        void Update() {
            HandleInput();
            UpdateCameraPosition();
            UpdateCameraRotation();
        }

        void HandleInput() {
            // Right mouse button: lock/unlock cursor
            if (Input.GetMouseButtonDown(1) && !KeepCursorLocked) Cursor.lockState = CursorLockMode.Locked;
            if (Input.GetMouseButtonUp(1) && !KeepCursorLocked) {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }

            // Scroll wheel: Adjust boost
            m_boost += Input.mouseScrollDelta.y * 0.2f;
        }

        Vector3 GetInputTranslationDirection() => new(m_horizontal, m_upDown, m_vertical);

        void UpdateCameraPosition() {
            var translation = GetInputTranslationDirection() * Time.deltaTime;

            // Speed up movement when shift key held
            if (Input.GetKey(KeyCode.LeftShift)) translation *= 10.0f;

            // Apply boost
            translation *= Mathf.Pow(2.0f, m_boost);

            m_targetCameraState.Translate(translation);

            // Pre-calculate the exponential values
            float positionExp = Mathf.Exp((Mathf.Log(1f - 0.99f) / m_positionLerpTime) * Time.deltaTime);
            float rotationExp = Mathf.Exp((Mathf.Log(1f - 0.99f) / m_rotationLerpTime) * Time.deltaTime);

            // Interpolate towards the target state
            float positionLerpPct = 1f - positionExp;
            float rotationLerpPct = 1f - rotationExp;
            m_interpolatingCameraState.LerpTowards(m_targetCameraState, positionLerpPct, rotationLerpPct);
            m_interpolatingCameraState.UpdateTransform(transform);
        }

        void UpdateCameraRotation() {
            if (!KeepCursorLocked && !Input.GetMouseButton(1)) return; // Right mouse button held or KeepCursorLocked is true
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y") * (m_invertY ? 1 : -1);
            var mouseMovement = new Vector2(mouseX, mouseY);
            float mouseSensitivityFactor = m_mouseSensitivityCurve.Evaluate(mouseMovement.magnitude);

            m_targetCameraState.Yaw += mouseMovement.x * mouseSensitivityFactor;
            m_targetCameraState.Pitch += mouseMovement.y * mouseSensitivityFactor;
        }
    }
}
#endif