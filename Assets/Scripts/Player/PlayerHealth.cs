using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour, IDamage
{
    float LastDamageTime = 0;
    [SerializeField]
    int health;
    float DamageInterValTimer =0;
    [SerializeField]
    float DamageInterVal;
    [SerializeField]
    TextMeshProUGUI HealthText;
    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    AudioClip[] audioClips;
    [SerializeField]
    float DamageSpriteAlpha1;
    [SerializeField]
    float DamageSpriteAlpha2;
    bool useDamageSpriteAlpha1 = true;
    [SerializeField]
    float DamageSpriteAlphaFlipTime;
    float DamageSpriteAlphaFlipTimer = 0;
    [SerializeField]
    SpriteRenderer spriteRenderer;
    [SerializeField]
    GameObject PlayerCorpsePrefab;

    private void Start()
    {
        HealthText.text = $"Health:{health}";
    }

    public void Damage(int damage)
    {
        if (DamageInterValTimer <= 0)
        {
            DamageInterValTimer = DamageInterVal;
            health -= damage;
            HealthText.text = $"Health:{health}";
            if (health <= 0)
            {
                GameObject playerCorpse = Instantiate(PlayerCorpsePrefab, transform.position, Quaternion.identity);
                playerCorpse.GetComponent<PlayerCorpse>().SetStartValues(spriteRenderer.transform.rotation);
                gameObject.SetActive(false);
            }
            else
            {
                int randomIndex = Random.Range(0, audioClips.Length);
                audioSource.PlayOneShot(audioClips[randomIndex]);
            }
            Debug.LogWarning("Damage");
            LastDamageTime = Time.time;
        }

    }

    public bool IsDead()
    {
        throw new System.NotImplementedException();
    }

    public bool SetCombo(int combo)
    {
        throw new System.NotImplementedException();
    }
    private void Update()
    {
        if (DamageInterValTimer > 0)
        {
            DamageInterValTimer -= Time.deltaTime;
            DamageSpriteAlphaFlipTimer -= Time.deltaTime;
            if (DamageSpriteAlphaFlipTimer <= 0)
            {
                DamageSpriteAlphaFlipTimer = DamageSpriteAlphaFlipTime;
                Color tempColor = spriteRenderer.color;
                tempColor.r = 5;
                useDamageSpriteAlpha1 = !useDamageSpriteAlpha1;
                tempColor.a = useDamageSpriteAlpha1 ? DamageSpriteAlpha1 : DamageSpriteAlpha2;
                spriteRenderer.color = tempColor;
            }
        }
        else if (DamageInterValTimer <= 0 && spriteRenderer.color.a != 1)
        {
            Color tempColor = spriteRenderer.color;
            tempColor.a = 1;
            tempColor.r = 1;
            spriteRenderer.color = tempColor;

        }
    }
}
