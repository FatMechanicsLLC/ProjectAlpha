#pragma once

//**************************************************************************************************
//
//	Author: Matthew Altman
//	Date:	10/21/2017
//
//	Object for encapsulating character wealth attributes
//
//**************************************************************************************************

#include "pch.h"
#include "Common.h"

class CCharacter;

class CWealth
{
	friend CCharacter;

private:
	int		m_iPlatinum;
	int		m_iGold;
	int		m_iSilver;
	int		m_iCopper;

protected:
	void	SetPlatinum(int _iPlat) { m_iPlatinum = _iPlat; }
	void	SetGold(int _iGold) { m_iGold = _iGold; }
	void	SetSilver(int _iSilver) { m_iSilver = _iSilver; }
	void	SetCopper(int _iCop) { m_iCopper = _iCop; }

public:
	CWealth();
	virtual ~CWealth() {}

	int		GetPlatinum()	const { return m_iPlatinum; }
	int		GetGold()		const { return m_iGold; }
	int		GetSilver()		const { return m_iSilver; }
	int		GetCopper()		const { return m_iCopper; }
};

CWealth::CWealth() :
	m_iPlatinum(-1),
	m_iGold(-1),
	m_iSilver(-1),
	m_iCopper(-1)
{

}