#pragma once

//**************************************************************************************************
//
//	Author: Matthew Altman
//	Date:	10/21/2017
//
//	Object for encapsulating character Combat attributes
//
//**************************************************************************************************

#include "pch.h"
#include "Common.h"

class CCharacter;

typedef enum _eWeaponClasses
{
	eWeaponClasses_Illegal,

	eWeaponClasses_Piercing,
	eWeaponClasses_Slashing,
	eWeaponClasses_TwoHanded,
	eWeaponClasses_Blunt,
	eWeaponClasses_Ranged,
	eWeaponClasses_Snare,
	eWeaponClasses_Entrap,

	eWeaponClasses_Max
} eWeaponClasses;

class CCombatAttributes
{
	friend CCharacter;

private:
	int				m_iHitDice;

	int				m_iBaseArmorClass;
	int				m_iAdjustedArmorClass;
	int				m_iAdjustedDexterity;

	int				m_iAttack;
	int				m_iDefense;
	int				m_iDamage;

	eWeaponClasses	m_ePrimaryWeaponClass;
	eWeaponClasses	m_eSecondaryWeaponClass;


protected:
	void	SetAttack(int _iAttack)								{ m_iAttack = _iAttack; }
	void	SetDefense(int _iDefense)							{ m_iDefense = _iDefense; }
	void	SetDamage(int _iDamage)								{ m_iDamage = _iDamage; }
	void	SetHitDice(int _iHitDice)							{ m_iHitDice = _iHitDice; }
	void	SetBaseArmorClass(int _iBaseAC)						{ m_iBaseArmorClass = _iBaseAC; }
	void	SetAdjustedArmorClass(int _iAdjustedAC)				{ m_iAdjustedArmorClass = _iAdjustedAC; }
	void	SetAdjustedDexterity(int _iAdjustedDex)				{ m_iAdjustedDexterity = _iAdjustedDex; }

	void	SetPrimaryWeaponClass(eWeaponClasses _eWeapClass)	{ m_ePrimaryWeaponClass = _eWeapClass; }
	void	SetSecondaryWeaponClass(eWeaponClasses _eWeapClass) { m_eSecondaryWeaponClass = _eWeapClass; }

public:
	CCombatAttributes();
	virtual ~CCombatAttributes() {}

	int				GetHitDice() const				{ return m_iHitDice; }
	int				GetAttack() const				{ return m_iAttack; }
	int				GetDefense() const				{ return m_iDefense; }
	int				GetDamage() const	    		{ return m_iDamage; }
	int				GetBaseArmorClass() const		{ return m_iBaseArmorClass; }
	int				GetAdjustedArmorClass() const	{ return m_iAdjustedArmorClass; }
	int				GetAdjustedDexterity() const	{ return m_iAdjustedDexterity; }

	eWeaponClasses	GetPrimaryWeaponClass() const	{ return m_ePrimaryWeaponClass; }
	eWeaponClasses	GetSecondaryWeaponClass() const { return m_eSecondaryWeaponClass; }
};

CCombatAttributes::CCombatAttributes() :
	m_iHitDice(-1),
	m_iBaseArmorClass(-1),
	m_iAdjustedArmorClass(-1),
	m_iAdjustedDexterity(-1),
	m_iAttack(-1),
	m_iDefense(-1),
	m_iDamage(-1),
	m_ePrimaryWeaponClass(eWeaponClasses_Illegal),
	m_eSecondaryWeaponClass(eWeaponClasses_Illegal)
{

}