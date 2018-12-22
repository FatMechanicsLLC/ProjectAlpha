#pragma once

//**************************************************************************************************
//
//	Author: Matthew Altman
//	Date:	10/21/2017
//
//	Object for encapsulating character magic attributes
//
//**************************************************************************************************

#include "pch.h"
#include "Common.h"

class CCharacter;

class CMagicAttributes
{
	friend CCharacter;

private:
	int		m_iMana;
	int		m_iManaRegenRate;

protected:
	void	SetMana(int _iMana) { m_iMana = _iMana; }
	void	SetManaRegenRate(int _iManaRegenRate) { m_iManaRegenRate = _iManaRegenRate; }

public:
	CMagicAttributes() {}
	virtual ~CMagicAttributes() {}
};