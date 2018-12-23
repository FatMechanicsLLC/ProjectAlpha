#pragma once

#include "pch.h"
#include "Common.h"
#include "CAttributes.h"
#include "CPhysicalTraits.h"
#include "CWealth.h"
#include "CHealth.h"
#include "CCombatAttributes.h"
#include "CMagicAttributes.h"
#include "CExperience.h"
#include "CSocialAttributes.h"
#include "CResistanceAttributes.h"



class CCharacter
{
private:
	eRace					m_eRace;
	eGender					m_eGender;
	eAlignment				m_eAlignment;
	eClassType				m_eClass;

	CPhysicalTraits			m_PhysicalTraits;
	CAttributes				m_CoreAttributes;
	CWealth					m_Wealth;
	CHealth					m_Health;

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