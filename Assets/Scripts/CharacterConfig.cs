using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterType
{
    UNEQUIPED = 0,
    INFANTERY = 1,
    GUNNER = 2,
    SCOUT = 3,
    SNIPER = 4,
}

public class CharacterConfig : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterType characterType;
    public GameObject headUnequiped;
    public GameObject headInfantery;
    public GameObject headGunner;
    public GameObject headScout;
    public GameObject headSniper;
    public GameObject bodyUnequiped;
    public GameObject bodyInfantery;
    public GameObject bodyGunner;
    public GameObject bodyScout;
    public GameObject bodySniper;
    public GameObject gunUnequiped;
    public GameObject gunInfantery;
    public GameObject gunGunner;
    public GameObject gunScout;
    public GameObject gunSniper;

    public bool hasWeapon;

    private Outline outline;

    void Start()
    {
        outline = GetComponent<Outline>();

    
    }
    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        headUnequiped.SetActive(characterType == CharacterType.UNEQUIPED);
        bodyUnequiped.SetActive(characterType == CharacterType.UNEQUIPED);

        headInfantery.SetActive(characterType == CharacterType.INFANTERY);
        bodyInfantery.SetActive(characterType == CharacterType.INFANTERY);

        headGunner.SetActive(characterType == CharacterType.GUNNER);
        bodyGunner.SetActive(characterType == CharacterType.GUNNER);

        headScout.SetActive(characterType == CharacterType.SCOUT);
        bodyScout.SetActive(characterType == CharacterType.SCOUT);

        headSniper.SetActive(characterType == CharacterType.SNIPER);
        bodySniper.SetActive(characterType == CharacterType.SNIPER);

        gunUnequiped.SetActive(characterType == CharacterType.UNEQUIPED && hasWeapon);
        gunInfantery.SetActive(characterType == CharacterType.INFANTERY && hasWeapon);
        gunGunner.SetActive(characterType == CharacterType.GUNNER && hasWeapon);
        gunScout.SetActive(characterType == CharacterType.SCOUT && hasWeapon);
        gunSniper.SetActive(characterType == CharacterType.SNIPER && hasWeapon);
    }
}
