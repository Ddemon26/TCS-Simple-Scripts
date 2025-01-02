using System.Collections.Generic;
using UnityEngine;
namespace TCS.SimpleScripts.Manipulators {
    [AddComponentMenu("TCS/SimpleScripts/Manipulators/Effect Cycler")]
    public class EffectCycler : MonoBehaviour {
        [SerializeField] List<GameObject> m_listOfEffects;
        
        [Header("Loop length in seconds")]
        [SerializeField] float m_loopTimeLength = 5f;
        
        float m_timeOfLastInstantiate;
        GameObject m_instantiatedEffect;
        int m_effectIndex;
        
        void Start() {
            m_instantiatedEffect = Instantiate(m_listOfEffects[m_effectIndex], transform.position, transform.rotation);
            m_effectIndex++;
            m_timeOfLastInstantiate = Time.time;
        }
        
        void Update() {
            if (!(Time.time >= m_timeOfLastInstantiate + m_loopTimeLength)) return;
            
            Destroy(m_instantiatedEffect);
            m_instantiatedEffect = Instantiate(m_listOfEffects[m_effectIndex], transform.position, transform.rotation);
            m_timeOfLastInstantiate = Time.time;
            if (m_effectIndex < m_listOfEffects.Count - 1) {
                m_effectIndex++;
            }
            else {
                m_effectIndex = 0;
            }
        }
    }
}