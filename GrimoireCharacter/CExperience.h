#pragma once

//**************************************************************************************************
//
//	Author: Matthew Altman
//	Date:	10/21/2017
//
//	Object for encapsulating character Experience attributes
//
//**************************************************************************************************

#include "pch.h"
#include "Common.h"

class CCharacter;

class CExperience
{
	friend CCharacter;

private:
	int		m_iExperience;
	int		m_iLevel;

protected:
	void SetExperience(int _iExp)	{ m_iExperience = _iExp; }
	void SetLevel(int _iLevel)		{ m_iLevel = _iLevel; }

public:
	CExperience();
	virtual ~CExperience() {}

	int GetExperience()		const	{ return m_iExperience; }
	int GetLevel()			const	{ return m_iLevel; }
};

CExperience::CExperience() :
	m_iExperience(-1),
	m_iLevel(-1)
{

}