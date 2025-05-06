using UnityEngine;

namespace _Project14_15.Scripts
{
    public class Bullet : Item
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _timeToDestroy;

        private Vector3 _direction;
        private bool _canFly;
        private float _timerCounter;

        private void Update()
        {
            if (_canFly == false)
                return;

            _timerCounter += Time.deltaTime;

            if (_timerCounter >= _timeToDestroy)
            {
                ParticleEffect.Stop();
                ParticleEffect.transform.SetParent(null);
                DesroyItem();
            }

            Fly();
        }

        public override void Use(Character character)
        {
            if (transform.IsChildOf(character.transform))
            {
                _direction = character.transform.forward;
                
                transform.SetParent(null);
                _canFly = true;
                ParticleEffect.transform.SetParent(transform);
                
                StartEffect(transform.position);
            }
        }

        private void Fly()
            => transform.position += _direction * (_speed * Time.deltaTime);
    }
}