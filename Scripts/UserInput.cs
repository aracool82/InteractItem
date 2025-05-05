using UnityEngine;

namespace _Project14_15.Scripts
{
    [RequireComponent(typeof(Character))]
    public class UserInput : MonoBehaviour
    {
        private const string HorizontalAxis = "Horizontal";
        private const string VerticalAxis = "Vertical";
        
        [SerializeField] private Character _character;
        [SerializeField] private Vector3 _direction;
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
                _character.UseItem();
            
            float moveX = Input.GetAxisRaw(HorizontalAxis);
            float moveZ = Input.GetAxisRaw(VerticalAxis);
            _direction = new Vector3(moveX, 0, moveZ).normalized;

            if (_direction != Vector3.zero)
                _character.Move(_direction);
        }
    }
}