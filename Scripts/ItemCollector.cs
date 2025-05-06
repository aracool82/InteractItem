using UnityEngine;

namespace _Project14_15.Scripts
{
    public class ItemCollector : MonoBehaviour
    {
        [SerializeField] private Character _character;
        
        private void OnCollisionEnter(Collision other)
        {
            if (other.collider.TryGetComponent(out Item item))
                if(_character.CanTakeItem())
                    _character.TakeItem(item);
        }
    }
}