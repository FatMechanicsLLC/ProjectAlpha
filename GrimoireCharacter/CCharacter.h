#pragma once

#include "pch.h"
#include "Common.h"
#include "CAttributes.h"
#include "CPhysicalAttributes.h"
#include "CWealth.h"
#include "CHealth.h"
#include "CCombatAttributes.h"
#include "CMagicAttributes.h"
#include "CExperience.h"
#include "CSocialAttributes.h"
#include "CResistanceAttributes.h"
#include "CMovementAttributes.h"



class CCharacter
{
private:
	eRace					m_eRace;
	eGender					m_eGender;
	eAlignment				m_eAlignment;
	eClassType				m_eClass;

	CPhysicalAttributes		m_PhysicalTraits;
	CAttributes				m_CoreAttributes;
	CWealth					m_Wealth;
	CHealth					m_Health;
	CMovementAttributes		m_Movement;
	CExperience				m_Experience;
	CMagicAttributes		m_MagicAttributes;
	CCombatAttributes		m_CombatAttributes;
	CResistanceAttributes	m_ResistanceAttributes;

	CSocialAttributes		m_SocialAttributes;

	int			m_iTotalWeight;


protected:
public:
	CCharacter() {}
	~CCharacter() {}
};