#pragma once

//**************************************************************************************************
//
//	Author: Matthew Altman
//	Date:	10/21/2017
//
//	Object for encapsulating character Health attributes
//
//**************************************************************************************************

#include "pch.h"
#include "Common.h"

class CCharacter;

class CHealth
{

	friend CCharacter;

private:
	int			m_iHitPoints;
	int			m_iMaxHitPoints;
	int			m_iHitsTaken;
	int			m_iRegenerationRate;

protected:
	void	SetMaxHitPoints(int _iMaxHP)			{ m_iMaxHitPoints = _iMaxHP; }
	void	SetHitPoints(int _iHitPoints)			{ m_iHitPoints = _iHitPoints; }
	void	SetHitsTaken(int _iHitsTaken)			{ m_iHitsTaken = _iHitsTaken; }
	void	SetRegenerationRate(int _iRegenRate)	{ m_iRegenerationRate = _iRegenRate; }
public:
	CHealth();
	virtual ~CHealth() {}

	int GetMaxHitPoints()		const { return m_iMaxHitPoints; }
	int	GetHitPoints()			const { return m_iHitPoints; }
	int GetHitsTaken()			const { return m_iHitsTaken; }
	int GetRegenerationRate()	const { return m_iRegenerationRate; }
};

CHealth::CHealth() :
	m_iHitPoints(-1),
	m_iMaxHitPoints(-1), 
	m_iHitsTaken(-1),
	m_iRegenerationRate(-1)
{

}