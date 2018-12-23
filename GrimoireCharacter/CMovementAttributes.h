#pragma once


//**************************************************************************************************
//
//	Author: Matthew Altman
//	Date:	12/21/2018
//
//	Object for encapsulating character movement attributes
//
//**************************************************************************************************

#include "pch.h"
#include "Common.h"

class CCharacter;

class CMovementAttributes
{
private:
	float	m_fBaseMovementRate;
	float	m_fMovementRate;
	float	m_fMovementRateModifier;

protected:

	void	SetMovementRate(float _fRate) { m_fMovementRate = _fRate;  }
	void	SetMovementRateModifier(float _fRate) { m_fMovementRateModifier = _fRate; }
	void	SetBaseMovementRate(float _fRate) { m_fBaseMovementRate = _fRate; }

public:
	CMovementAttributes() {}
	virtual ~CMovementAttributes() {}

	float	GetBaseMovementRate() const { return m_fBaseMovementRate; }
	float	GetMovementRate() const { return m_fMovementRate; }
	float	GetMovementRateModifier() const { return m_fMovementRateModifier; }
};

