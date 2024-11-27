using UnityEngine;
namespace TCS.SimpleScripts.Manipulators {
    [AddComponentMenu("TCS/SimpleScripts/Manipulators/Color Lerper")]
    [RequireComponent(typeof(Renderer))]
    public class ColorLerper : MonoBehaviour {
        [SerializeField] Color m_startColor = Color.white;
        [SerializeField] Color m_endColor = Color.black;
        [SerializeField] float m_duration = 1f;
        [SerializeField] AnimationCurve m_curve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
        [SerializeField] bool m_loopColorLerp;

        Renderer m_objectRenderer;
        float m_elapsedTime;
        bool m_lerpingToEnd = true;

        void Awake() {
            m_objectRenderer = GetComponent<Renderer>();
            m_objectRenderer.material.color = m_startColor;
        }

        void OnEnable() => m_elapsedTime = 0f;

        void Update() {
            if (m_elapsedTime < m_duration) {
                m_elapsedTime += Time.deltaTime;
                float t = Mathf.Clamp01(m_elapsedTime / m_duration);
                float curveValue = m_curve.Evaluate(t);
                m_objectRenderer.material.color = Color.Lerp(m_startColor, m_endColor, curveValue);
            }
            else if (m_loopColorLerp) {
                m_elapsedTime = 0f;
                ToggleLerpDirection();
            }
        }

        void ToggleLerpDirection() {
            m_lerpingToEnd = !m_lerpingToEnd;
            (m_startColor, m_endColor) = (m_endColor, m_startColor);
        }

        public void SetColors(Color newStart, Color newEnd) {
            m_startColor = newStart;
            m_endColor = newEnd;
            m_elapsedTime = 0f; // Reset the lerp
        }
    }
}