using UnityEngine;
namespace TCS.SimpleScripts.Manipulators {
    [AddComponentMenu("TCS/SimpleScripts/Manipulators/Scale Lerper")]
    public class ScaleLerper : MonoBehaviour {
        [SerializeField] Vector3 m_targetScale = Vector3.one;
        [SerializeField] float m_duration = 1f;
        [SerializeField] AnimationCurve m_curve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
        [SerializeField] bool m_loopScaling;

        Vector3 m_initialScale;
        float m_elapsedTime;
        bool m_scalingUp = true;

        void Awake() => m_initialScale = transform.localScale;

        void OnEnable() {
            m_elapsedTime = 0f;
            transform.localScale = m_initialScale;
        }

        void Update() {
            if (m_elapsedTime < m_duration) {
                m_elapsedTime += Time.deltaTime;
                float t = Mathf.Clamp01(m_elapsedTime / m_duration);
                float scaleValue = m_curve.Evaluate(t);
                transform.localScale = Vector3.LerpUnclamped(m_initialScale, m_targetScale, scaleValue);
            }
            else if (m_loopScaling) {
                m_elapsedTime = 0f;
                ToggleScalingDirection();
            }
        }

        void ToggleScalingDirection() {
            m_scalingUp = !m_scalingUp;
            (m_initialScale, m_targetScale) = (m_targetScale, m_initialScale);
        }
    }
}