using UnityEngine;

namespace _Project14_15.Scripts
{
    [RequireComponent(typeof(Rigidbody), typeof(BoxCollider), typeof(ItemCollector))]
    public class Character : MonoBehaviour
    {
        [SerializeField] private Item _item;
        [SerializeField] private float _health;
        [SerializeField] private float _speed;

        [SerializeField] private Transform _alignmentTransform;

        public void Move(Vector3 direction)
        {
            transform.position += direction * (_speed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(direction);
        }

        public void UseItem()
        {
            if (_item == null)
                Debug.Log("can`t use item");
            else
                _item.Use(this);

            _item = null;
        }

        public void AddHealth(float health)
            => _health += health;

        public void AddSpeed(float speed)
        => _speed += speed;

        public void TakeItem(Item item)
        {
            if (item == null)
            {
                Debug.LogError("can`t take item. Item is null");
                return;
            }

            _item = item;
            AlignmentItem(item);
        }

        private void AlignmentItem(Item item)
        {
            item.GetComponent<Collider>().enabled = false;
            item.transform.SetParent(transform);
            item.transform.position = _alignmentTransform.position ;
        }

        public bool CanTakeItem()
            => _item == null;
    }
}