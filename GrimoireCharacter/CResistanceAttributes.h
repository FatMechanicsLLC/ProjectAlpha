#pragma once


#pragma once

//**************************************************************************************************
//
//	Author: Matthew Altman
//	Date:	12/21/2018
//
//	Object for encapsulating character resistance attributes
//
//**************************************************************************************************

#include "pch.h"
#include "Common.h"

class CCharacter;


class CResistanceAttributes
{
	friend CCharacter;

private:
	int		m_iFire;
	int		m_iCold;
	int		m_iAcid;
	int		m_iMagic;

protected:

	// Set Methods
	inline void	SetFireResistance(int _iResi) { m_iFire = _iResi; }
	inline void	SetColdResistance(int _iResi) { m_iCold = _iResi; }
	inline void	SetMagicResistance(int _iResi) { m_iMagic = _iResi; }
	inline void	SetAcidResistance(int _iResi) { m_iAcid = _iResi; }

	// Generic Methods
	void	SetResistanceAttribute(eResistance _eResist, int _iVal);
	int		GetResistanceAttribute(eResistance _eResist);

	// Get Methods
	inline int		GetFireResistance() { return m_iFire; }
	inline int		GetColdResistance() { return m_iCold; }
	inline int		GetMagicResistance() { return m_iMagic; }
	inline int		GetAcidResistance() { return m_iAcid; }

public:
	CResistanceAttributes() {}
	virtual ~CResistanceAttributes() {}
};

void CResistanceAttributes::SetResistanceAttribute(eResistance _eResist, int _iVal)
{
	switch (_eResist) {
	case eResistanceFire:
		SetFireResistance(_iVal);
		break;
	case eResistanecCold:
		SetColdResistance(_iVal);
		break;
	case eResistanceAcid:
		SetAcidResistance(_iVal);
		break;
	case eResistanceMagic:
		SetMagicResistance(_iVal);
		break;
	default:
		break;
	}
}

int CResistanceAttributes::GetResistanceAttribute(eResistance _eResist)
{
	switch (_eResist) {
	case eResistanceFire:
		return GetFireResistance();
		break;
	case eResistanecCold:
		return GetColdResistance();
		break;
	case eResistanceAcid:
		return GetAcidResistance();
		break;
	case eResistanceMagic:
		return GetMagicResistance();
	default:
		assert(0 && "Unknown Type");
		break;
	}

	return -1;
}