using UnityEngine;

namespace _Project14_15.Scripts
{
    public abstract class Item : MonoBehaviour
    {
        public abstract void Use(Character character);
        
        protected abstract void StartEffect();
        
        protected void DeleteItem()
            => Destroy(gameObject);

    }
}