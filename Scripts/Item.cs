using UnityEngine;

namespace _Project14_15.Scripts
{
    public abstract class Item : MonoBehaviour
    {
        [SerializeField]
        protected ParticleSystem ParticleEffect;
        
        public abstract void Use(Character character);
        
        protected  void StartEffect(Vector3 position)
        {
            ParticleEffect.transform.position = position;
            ParticleEffect.Play();
        }
        
        protected void DesroyItem()
            => Destroy(gameObject);

    }
}