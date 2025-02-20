using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{

    [Header("Main Audio Source")]

    public AudioSource audioSource;


    [SerializeField] AudioClip touchSFX;
    [SerializeField] AudioClip destroySFX;
    [SerializeField] AudioClip winSFX;
    [SerializeField] AudioClip enemyDeathSFX;
    [SerializeField] AudioClip towerPlacingSFX;
    [SerializeField] AudioClip shootingSFX;
    [SerializeField] AudioClip gernadeSFX;
    [SerializeField] AudioClip coinsCollectionSFX;

    [Header("Shooting Sounds")]

    public AudioClip tower01ShootingSound;
    public AudioClip tower02ShootingSound;
    public AudioClip tower03ShootingSound;
    public AudioClip tower04ShootingSound;


    protected override void Awake()
    {
        base.Awake();
     }

      void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
  
    }

    

    public void PlaySingleShotAudio(AudioClip audioClip, float soundEffect)
    {
        audioSource.PlayOneShot(audioClip,soundEffect);
    }

    public void PlayTouchSoundEffect()
    {
        audioSource.PlayOneShot(touchSFX, 0.8f);
    }

    public void PlayDeathSoundEffect()
    {
        audioSource.PlayOneShot(destroySFX, 1.1f);
    }

    public void PlayTowerPlacingSoundEffect()
    {
        audioSource.PlayOneShot(destroySFX, 1.0f);
    }

    public void PlayWinSoundEffect()
    {
        audioSource.PlayOneShot(destroySFX, 1.0f);
    }

    public void PlayShootingSoundEffect()
    {
        audioSource.PlayOneShot(shootingSFX, 0.6f);
    }
    public void PlayGernadeSoundEffect()
    {
        audioSource.PlayOneShot(gernadeSFX, 1.2f);
    }


    public void PlayCoinsCollectionSoundEffect()
    {
        audioSource.PlayOneShot(coinsCollectionSFX, 2.0f);
    }

    public void PlayBattleWinSoundEffect()
    {
         audioSource.PlayOneShot(winSFX, 2.0f);
    }
}
