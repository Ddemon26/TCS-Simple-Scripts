using System;
using System.Collections.Generic;
using UnityEngine;

namespace TCS.SimpleScripts {
    public class ObjectPoolBehaviour : MonoBehaviour, IDisposable {
        [SerializeField] GameObject m_prefab;
        [SerializeField] int m_poolSize = 10;
        [SerializeField] List<GameObject> m_pooledObjects = new();

        void Awake() {
            for (var i = 0; i < m_poolSize; i++) {
                var obj = Instantiate(m_prefab, transform);
                obj.SetActive(false);
                m_pooledObjects.Add(obj);
            }
        }

        public GameObject GetPooledObject() {
            foreach (var obj in m_pooledObjects) {
                if (!obj.activeInHierarchy) {
                    return obj;
                }
            }

            return null;
        }

        void OnDestroy() => Dispose();

        public void Dispose() {
            foreach (var obj in m_pooledObjects) {
                Destroy(obj);
            }
            
            m_pooledObjects.Clear();
            m_prefab = null;
            m_poolSize = default;
        }
    }
}