#pragma once

//**************************************************************************************************
//
//	Author: Matthew Altman
//	Date:	10/21/2017
//
//	Object for encapsulating character physical attributes
//
//**************************************************************************************************

#include "pch.h"
#include "Common.h"

class CCharacter;

typedef enum _eEyeColor
{
	eEyeColor_Illegal,

	eEyeColor_Blue,
	eEyeColor_Brown,
	eEyeColor_Red,
	eEyeColor_Green,
	eEyeColor_Black,
	eEyeColor_Yellow,
	eEyeColor_Hazel,
	eEyeColor_Grey,

	eEyeColor_Max
} eEyeColor;

typedef enum _eHairColor
{
	eHairColor_Illegal,

	eHairColor_Black,
	eHairColor_Brown,
	eHairColor_Blonde,
	eHairColor_Blue,
	eHairColor_Green,
	eHairColor_Red,
	eHairColor_Grey,
	eHairColor_Yellow,
	eHairColor_White,

	eHairColor_Max,
} eHairColor;

typedef enum _SkinColor
{
	eSkinColor_Illegal,

	eSkinColor_White,
	eSkinColor_Tan,
	eSkinColor_Black,
	eSkinColor_Blue,
	eSkinColor_Green,
	eSkinColor_Yellow,

	eSkinColor_Max
} eSkinColor;

typedef enum _eSex
{
	eSex_Illegal,

	eSex_Male,
	eSex_Female,
	eSex_Uni,
	eSex_Other,

	eSex_Max
} eSex;

typedef enum _eScars
{
	eScars_Illegal,

	eScars_RightUpperArm,
	eScars_LeftUpperArm,

	eScars_Max
} eScars;

typedef enum _eBirthMarks
{
	eBirthMark_Illegal,

	eBirthMark_CleftLip,
	eBirthMark_Moles,

	eBirthMark_Max
} eBirthMarks;

typedef enum _eHandType
{
	eHandType_Illegal,

	eHandType_Human,
	eHandType_CrabLike,
	eHandType_CanineClawLike,
	eHandType_FelineClawLike,
	eHandType_TentacleLike,
	
	eHandType_Max
} eHandType;

typedef enum _eFootType
{
	eFootType_Illegal,

	eFootType_Human,
	eFootType_Hobbit,
	eFootType_HoofLike,
	eFootType_TentacleLike,

	eFootType_Max
} eFootType;


class CPhysicalTraits
{
	friend CCharacter;

private:

	eSex			m_eSex;

	float			m_fHeight;
	float			m_fMaxHeight;
	float			m_fAdjustedHeight;

	float			m_fWeight;
	float			m_fAdjustedWeight;

	float			m_fAge;
	float			m_fBirthDate;
	float			m_fLifeSpan;

	eEyeColor		m_eEyeColor;
	eSkinColor		m_eSkinColor;
	eHairColor		m_eHairColor;
	eBirthMarks		m_eBirthMark;
	eScars			m_eScars;
	int				m_iHandsCount;
	eHandType		m_eHandType;
	int				m_iFeetCount;
	eFootType		m_eFootType;

	std::wstring	m_PhysicalDescription;

protected:
	void	SetHeight(float _fHeight) { m_fHeight = _fHeight; }
	void	SetWeight(float _fWeight) { m_fWeight = _fWeight; }
	void	SetAge(float _fAge) { m_fAge = _fAge; }
	void	SetBirthDate(float _fBirthDate) { m_fBirthDate = _fBirthDate; }
	void	SetLifeSpan(float _fLifeSpan) { m_fLifeSpan = _fLifeSpan; }

public:
	CPhysicalTraits() {}
	virtual ~CPhysicalTraits() {}

	float	GetHeight() const { return m_fHeight; }
	float	GetWeight()	const { return m_fWeight; }
	float	GetAge() const { return m_fAge; }
	float	GetBirthDate() const { return m_fBirthDate; }
	float	GetLifeSpan() const { return m_fLifeSpan; }
};
