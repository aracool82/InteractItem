using UnityEngine;

namespace _Project14_15.Scripts
{
    [RequireComponent(typeof(Rigidbody), typeof(BoxCollider), typeof(ItemCollector))]
    
    public class Character : MonoBehaviour
    {
        [SerializeField] private Item _item;
        
        [Range(100f,500f)]
        [SerializeField] private float _health;
        
        [Range(5f,10f)]
        [SerializeField] private float _speed;

        [SerializeField] private Transform _alignmentTransform;

        private bool _canUsedItem;
        
        public void Move(Vector3 direction)
        {
            transform.position += direction * (_speed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(direction);
        }

        public void AddHealth(float health)
        {
            if(health < 0)
                Debug.LogError("Can`t add negative health");
            
            _health += health;
        }

        public void AddSpeed(float speed)
        {
            if (speed < 0)
                Debug.LogError("Can`t add negative speed");
            
             _speed += speed;
        }

        private void AlignmentItem(Item item)
        {
            item.GetComponent<Collider>().enabled = false;
            item.transform.SetParent(transform);
            item.transform.position = _alignmentTransform.position ;
        }
    }
}