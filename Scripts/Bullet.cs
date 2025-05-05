using UnityEngine;

namespace _Project14_15.Scripts
{
    public class Bullet : Item
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _timeToDelete;
        [SerializeField] private ParticleSystem _particle;

        private Vector3 _direction;
        private bool _canFly;
        private float _timerCounter;

        private void Update()
        {
            if (_canFly == false)
                return;

            _timerCounter += Time.deltaTime;

            if (_timerCounter >= _timeToDelete)
                DeleteItem();

            Fly();
        }

        public override void Use(Character character)
        {
            if (transform.IsChildOf(character.transform))
            {
                _direction = character.transform.forward;
                transform.SetParent(null);
                _canFly = true;
                StartEffect();
            }
        }

        protected override void StartEffect()
        {
            _particle.transform.position = transform.position;
            _particle.Play();
        }


        private void Fly()
        {
            transform.position += _direction * (_speed * Time.deltaTime);
        }
    }
}