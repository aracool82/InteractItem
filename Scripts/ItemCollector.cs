using UnityEngine;

namespace _Project14_15.Scripts
{
    public class ItemCollector : MonoBehaviour
    {
        [SerializeField] private ItemHolder _itemHolder;
        
        private void OnCollisionEnter(Collision other)
        {
            // if (other.collider.TryGetComponent(out Item item))
            //     if(_itemHolder.IsEmpty)
            //         if(_itemHolder.TryAdd(item))
                        
        }
    }
}