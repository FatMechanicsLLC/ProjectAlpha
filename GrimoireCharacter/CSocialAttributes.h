#pragma once

//**************************************************************************************************
//
//	Author: Matthew Altman
//	Date:	10/21/2017
//
//	Object for encapsulating character social attributes
//
//**************************************************************************************************

#include "pch.h"
#include "Common.h"

class CCharacter;

typedef enum _eMaritalStatus
{
	eMaritalStatus_Illegal,

	eMaritalStatus_Single,
	eMaritalStatus_Married,
	eMaritalStatus_Divorced,
	eMaritalStatus_Polygamist,

	eMartialStatus_Max
} eMaritalStatus;

typedef enum _eSocialRank
{
	eSocialRank_Illegal,

	eSocialRank_Slave,
	eSocialRank_Servant,
	eSocialRank_Laboror,
	eSocialRank_Farmer,
	eSocialRank_Military,
	eSocialRank_Aristocrat,
	eSocialRank_HighWealth,
	eSocialRank_Noble,
	eSocialRank_Prince,
	eSocialRank_King,

	eSocialRank_Max
} eSocialRank;

typedef enum _eSocialStatus
{
	eSocialStatus_Illegal,

	eSocialStatus_Respected,
	eSocialStatus_Criminal,
	eSocialStatus_Celebrity,
	eSocialStatus_SportsLegend,
	eSocialStatus_Pariah,

	eSocialStatus_Max
} eSocialStatus;

typedef enum _eReligion
{
	eReligion_Illegal,

	eReligion_None,
	eReligion_Agnostic,
	
	eReligion_Max
} eReligion;

class CSocialAttributes
{
	friend CCharacter;

private:
	eMaritalStatus	m_eMaritalStatus;
	eSocialRank		m_eParentsRank;
	eSocialRank		m_eSiblingsRank;
	eSocialStatus	m_eSocialStatus;
	eReligion		m_eReligion;

	int				m_iSiblings;
	int				m_iHeirs;

	int				m_Residence;

protected:

public:
	CSocialAttributes() {}
	virtual ~CSocialAttributes() {}

};