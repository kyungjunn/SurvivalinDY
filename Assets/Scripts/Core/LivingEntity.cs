using UnityEngine;

// IDamageable 인터페이스 상속받은 추상 클래스
public abstract class LivingEntity : MonoBehaviour, IDamageable 
{
    public virtual void TakeDamage()
    {

    }
}
