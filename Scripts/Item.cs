using UnityEngine;

namespace _Project14_15.Scripts
{
    public abstract class Item : MonoBehaviour
    {
        [SerializeField]
        protected ParticleSystem _particleEffect;
        
        public abstract void Use(Character character);
        
        protected  void StartEffect(Vector3 position)
        {
            _particleEffect.transform.position = position;
            _particleEffect.Play();
        }
        
        protected void DesroyItem()
            => Destroy(gameObject);

    }
}