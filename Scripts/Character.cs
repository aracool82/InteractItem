using UnityEngine;

namespace _Project14_15.Scripts
{
    [RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
    public class Character : MonoBehaviour
    {
        [SerializeField] private Item _item;
        [SerializeField] private float _health;
        [SerializeField] private float _speed;

        [SerializeField] private Transform _alignmentTransform;

        private void OnCollisionEnter(Collision other)
        {
            if (other.collider.TryGetComponent(out Item item))
                if (CanTakeItem())
                    TakeItem(item);
        }

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

        private void TakeItem(Item item)
        {
            _item = item;
            AlignmentItem(item);
        }

        private void AlignmentItem(Item item)
        {
            item.GetComponent<Collider>().enabled = false;
            item.transform.SetParent(transform);

            float offsetZ = item.transform.localScale.z / 2;
            Vector3 offsetVector = new Vector3(0, 0, offsetZ);

            item.transform.position = _alignmentTransform.position + offsetVector;
            item.transform.rotation = _alignmentTransform.rotation;
        }

        private bool CanTakeItem()
            => _item == null;
    }
}