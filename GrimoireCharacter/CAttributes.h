#pragma once

//**************************************************************************************************
//
//	Author: Matthew Altman
//	Date:	10/21/2017
//
//	Object for encapsulating character core attributes
//
//**************************************************************************************************

#include "pch.h"
#include "Common.h"

class CCharacter;

class CAttributes
{
	friend CCharacter;

private:
	int			m_iStrength;
	int			m_iConstitution;
	int			m_iAgility;
	int			m_iDexterity;
	int			m_iIntelligence;
	int			m_iWisdom;
	int			m_iCharisma;
	int			m_iStamina;
	int			m_iEgo;
	int			m_iLuck;
	int			m_iSwimming;

protected:
	void		SetStrength(int _iStr)		{ m_iStrength = _iStr; }
	void		SetConstitution(int _iCon)	{ m_iConstitution = _iCon; }
	void		SetAgility(int _iAgi)		{ m_iAgility = _iAgi; }
	void		SetDexterity(int _iDex)		{ m_iDexterity = _iDex; }
	void		SetIntelligence(int _iInt)	{ m_iIntelligence = _iInt; }
	void		SetWisdom(int _iWis)		{ m_iWisdom = _iWis; }
	void		SetCharisma(int _iCha)		{ m_iCharisma = _iCha; }
	void		SetStamina(int _iStamina)	{ m_iStamina = _iStamina; }
	void		SetEgo(int _iEgo)			{ m_iEgo = _iEgo; }
	void		SetLuck(int _iLuck)			{ m_iLuck = _iLuck; }
	void		SetSwimming(int _iSwimming) { m_iSwimming = _iSwimming; }

public:
	CAttributes();
	virtual ~CAttributes() {}

	int			GetStrength()		const { return m_iStrength; }
	int			GetConstitution()	const { return m_iConstitution; }
	int			GetAgility()		const { return m_iAgility; }
	int			GetDexterity()		const { return m_iDexterity; }
	int			GetIntelligence()	const { return m_iIntelligence; }
	int			GetWisdom()			const { return m_iWisdom; }
	int			GetCharisma()		const { return m_iCharisma; }
	int			GetStamina()		const { return m_iStamina; }
	int			GetEgo()			const { return m_iEgo; }
	int			GetLuck()			const { return m_iLuck; }
	int			GetSwimming()		const { return m_iSwimming; }
};

CAttributes::CAttributes() :
	m_iStrength(-1),
	m_iConstitution(-1),
	m_iAgility(-1),
	m_iDexterity(-1),
	m_iIntelligence(-1),
	m_iWisdom(-1),
	m_iCharisma(-1),
	m_iStamina(-1),
	m_iEgo(-1),
	m_iLuck(-1),
	m_iSwimming(-1)
{

}
