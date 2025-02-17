using UnityEngine;

namespace TCS.SimpleScripts.Manipulators {
    [AddComponentMenu("TCS/SimpleScripts/Manipulators/Simple Translate Object")]
    public class SimpleTranslateObject : MonoBehaviour {
        public Vector3 m_endPoint;
        public GameObject m_endPointObject;
        public float m_moveSpeed = 5f;
        public bool m_usePingPong;
        public bool m_reverseAtStart;
        public bool m_moveOnStart = true;
        public bool m_localSpace;

        bool m_isMoving;
        bool m_movingTowardsEnd;
        Vector3 m_startPoint;

        void Start() {
            m_startPoint = transform.position;
            m_movingTowardsEnd = !m_reverseAtStart;
            if (m_moveOnStart) StartMoving();
        }

        void Update() {
            if (!m_isMoving) return;
            if (m_usePingPong)
                PingPongMove();
            else
                LinearMove();
        }

        void LinearMove() {
            var targetPosition = GetTargetPosition();
            transform.position = Vector3.MoveTowards
            (
                transform.position, targetPosition, m_moveSpeed * Time.deltaTime
            );

            if (!HasReachedTarget(transform.position, targetPosition)) return;
            if (m_reverseAtStart)
                m_movingTowardsEnd = !m_movingTowardsEnd;
            else
                m_isMoving = false;
        }

        void PingPongMove() {
            float pingPongFactor = Mathf.PingPong(Time.time * (m_moveSpeed / 2), 1f);
            transform.position = Vector3.Lerp(m_startPoint, GetTargetPosition(), pingPongFactor);
        }

        Vector3 GetTargetPosition() => m_startPoint + m_endPoint;
        bool HasReachedTarget(Vector3 currentPosition, Vector3 targetPosition) => Vector3.Distance(currentPosition, targetPosition) < 0.001f;
        public void StartMoving() => m_isMoving = true;
        public void StopMoving() => m_isMoving = false;
        public void ResetPosition() => transform.position = m_startPoint;
        public void SetEndPoint(Vector3 end) => m_endPoint = end;
        public void SetEndPointObject(GameObject endObject) => m_endPointObject = endObject;
    }
}