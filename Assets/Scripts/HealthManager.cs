using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageSource
{
    int Damage { get; }
}

public interface IDamageSink
{
    void TakeDamage(IDamageSource src);
}

public class HealthManager : MonoBehaviour, IDamageSink
{
    [SerializeField] private int maxHP;
    private int curHP;

    public float NormalizedHealth => (float)curHP / (float)maxHP;

    public void TakeDamage(IDamageSource src)
    {
        curHP -= src.Damage;
        if (curHP < 0) curHP = 0;
    }

    // Start is called before the first frame update
    void Awake()
    {
        curHP = maxHP;
    }
}
