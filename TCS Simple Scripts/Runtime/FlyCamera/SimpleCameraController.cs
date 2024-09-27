using UnityEngine;
#if ENABLE_LEGACY_INPUT_MANAGER

namespace TCS.SimpleScripts
{
    /// <summary>
    /// A simple camera controller for moving and rotating the camera using keyboard and mouse input.
    /// </summary>
    public class SimpleCameraController : MonoBehaviour
    {
        /// <summary>
        /// Gets or sets the keys used for horizontal movement.
        /// </summary>
        [Header("Movement Settings"), Tooltip("The keys used for horizontal movement.")]
        [SerializeField] MoveAxis Horizontal = new(KeyCode.D, KeyCode.A);

        /// <summary>
        /// Gets or sets the keys used for vertical movement.
        /// </summary>
        [Tooltip("The keys used for vertical movement.")]
        [SerializeField] MoveAxis Vertical = new(KeyCode.W, KeyCode.S);

        /// <summary>
        /// Gets or sets the keys used for moving up and down.
        /// </summary>
        [Tooltip("The keys used for moving up and down.")]
        [SerializeField] MoveAxis UpDown = new(KeyCode.E, KeyCode.Q);

        /// <summary>
        /// Gets or sets the exponential boost factor on translation, controllable by mouse wheel.
        /// </summary>
        [Tooltip("Exponential boost factor on translation, controllable by mouse wheel.")]
        [SerializeField] float Boost = 3.5f;

        /// <summary>
        /// Gets or sets the time it takes to interpolate camera position 99% of the way to the target.
        /// </summary>
        [Tooltip("Time it takes to interpolate camera position 99% of the way to the target."), Range(0.001f, 1f)]
        [SerializeField] float PositionLerpTime = 0.2f;

        /// <summary>
        /// Gets or sets the AnimationCurve for mouse sensitivity. X = Change in mouse position. Y = Multiplicative factor for camera rotation.
        /// </summary>
        [Header("Rotation Settings"), Tooltip("X = Change in mouse position.\nY = Multiplicative factor for camera rotation.")]
        [SerializeField] AnimationCurve MouseSensitivityCurve = new(new Keyframe(0f, 0.5f, 0f, 5f), new Keyframe(1f, 2.5f, 0f, 0f));

        /// <summary>
        /// Gets or sets the time it takes to interpolate camera rotation 99% of the way to the target.
        /// </summary>
        [Tooltip("Time it takes to interpolate camera rotation 99% of the way to the target."), Range(0.001f, 1f)]
        [SerializeField] float RotationLerpTime = 0.01f;

        /// <summary>
        /// Gets or sets a setDialogueManager indicating whether to keep the cursor locked.
        /// </summary>
        [Tooltip("Whether to keep the cursor locked.")]
        public bool KeepCursorLocked
        {
            get { return _keepCursorLocked; }
            set
            {
                _keepCursorLocked = value;
                if (_keepCursorLocked)
                {
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                }
                else
                {
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                }
            }
        }
        [SerializeField] bool _keepCursorLocked = false;

        /// <summary>
        /// Gets or sets a setDialogueManager indicating whether or not to invert our Y axis for mouse input to rotation.
        /// </summary>
        [Tooltip("Whether or not to invert our Y axis for mouse input to rotation.")]
        public bool InvertY = false;

        private CameraState targetCameraState = new();
        private CameraState interpolatingCameraState = new();

        private void OnEnable()
        {
            targetCameraState.SetFromTransform(transform);
            interpolatingCameraState.SetFromTransform(transform);

            if (KeepCursorLocked)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }

        private void Update()
        {
            HandleInput();
            UpdateCameraPosition();
            UpdateCameraRotation();
        }

        private void HandleInput()
        {
            // Right mouse button: lock/unlock cursor
            if (Input.GetMouseButtonDown(1) && !KeepCursorLocked) Cursor.lockState = CursorLockMode.Locked;
            if (Input.GetMouseButtonUp(1) && !KeepCursorLocked)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }

            // Scroll wheel: Adjust boost
            Boost += Input.mouseScrollDelta.y * 0.2f;
        }

        private Vector3 GetInputTranslationDirection()
        {
            // Simplified to directly use the axis values
            return new Vector3(Horizontal, UpDown, Vertical);
        }

        private void UpdateCameraPosition()
        {
            var translation = GetInputTranslationDirection() * Time.deltaTime;

            // Speed up movement when shift key held
            if (Input.GetKey(KeyCode.LeftShift)) translation *= 10.0f;

            // Apply boost
            translation *= Mathf.Pow(2.0f, Boost);

            targetCameraState.Translate(translation);

            // Pre-calculate the exponential values
            float positionExp = Mathf.Exp((Mathf.Log(1f - 0.99f) / PositionLerpTime) * Time.deltaTime);
            float rotationExp = Mathf.Exp((Mathf.Log(1f - 0.99f) / RotationLerpTime) * Time.deltaTime);

            // Interpolate towards the target state
            var positionLerpPct = 1f - positionExp;
            var rotationLerpPct = 1f - rotationExp;
            interpolatingCameraState.LerpTowards(targetCameraState, positionLerpPct, rotationLerpPct);
            interpolatingCameraState.UpdateTransform(transform);
        }

        private void UpdateCameraRotation()
        {
            if (KeepCursorLocked || Input.GetMouseButton(1)) // Right mouse button held or KeepCursorLocked is true
            {
                float mouseX = Input.GetAxis("Mouse X");
                float mouseY = Input.GetAxis("Mouse Y") * (InvertY ? 1 : -1);
                var mouseMovement = new Vector2(mouseX, mouseY);
                var mouseSensitivityFactor = MouseSensitivityCurve.Evaluate(mouseMovement.magnitude);

                targetCameraState.yaw += mouseMovement.x * mouseSensitivityFactor;
                targetCameraState.pitch += mouseMovement.y * mouseSensitivityFactor;
            }
        }

    }
}
#endif