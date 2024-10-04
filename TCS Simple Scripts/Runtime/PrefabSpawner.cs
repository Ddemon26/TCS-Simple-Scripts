using UnityEngine;
namespace TCS.SimpleScripts {
    public class PrefabSpawner : MonoBehaviour {
        [SerializeField] bool m_useLocalPosition;
        [SerializeField] bool m_useLocalRotation;
        [SerializeField] GameObject m_prefab;
        [SerializeField] Vector3 m_customPosition;
        [SerializeField] Quaternion m_customRotation;

        public void Spawn() => Instantiate
            (
                m_prefab, m_useLocalPosition 
                    ? transform.position : m_customPosition, m_useLocalRotation 
                    ? transform.rotation : m_customRotation
            );
    }
}