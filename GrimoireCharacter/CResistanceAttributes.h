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
	void	SetFireResistance(int _iResi) { m_iFire = _iResi; }
	void	SetColdResistance(int _iResi) { m_iCold = _iResi; }
	void	SetMagicResistance(int _iResi) { m_iMagic = _iResi; }
	void	SetAcidResistance(int _iResi) { m_iAcid = _iResi; }

	void	SetResistanceAttribute(eResistance _eResist, int _iVal);

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