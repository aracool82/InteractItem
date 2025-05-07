using UnityEngine;

namespace _Project14_15.Scripts
{
    public class ItemHolder : MonoBehaviour
    {
        [SerializeField] private Character _character;
        
        private Item _item;
        
        public bool IsEmpty => _item == null;
        
        public bool TryAdd(Item item)
        {
            if (item == null)
            {
                Debug.LogError("Can not Add. Item is null");
                return false;
            }
            
            _item = item;
            return true;
        }

        public void Use()
        {
            //_item.Use(_character.gameObject);
            _item = null;
        }
    }
}