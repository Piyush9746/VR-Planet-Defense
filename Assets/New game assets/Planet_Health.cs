using UnityEngine;
using UnityEngine.UI;

public class Planet_Health : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public Slider slider;

    void Start()
    {
        currentHealth = maxHealth;
        slider.value = maxHealth;
    }


    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        slider.value = currentHealth;


        if (currentHealth <= 0)
        {
            Die();
        }
    }


    private void Die()
    {

        Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rock"))
        {
            ApplyDamage asteroid = other.GetComponent<ApplyDamage>();
            if (asteroid != null)
            {
                TakeDamage(asteroid.damage);
            }
        }
    }
}
