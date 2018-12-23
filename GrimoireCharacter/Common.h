#pragma once

typedef enum _eClassTypes
{
	eClassTypeIllegal = -1,

	eThief,
	eSlayer,
	eTechno,
	eCourtesan,
	eAssassin,
	eAlchemist,
	eRuneWeaver,
	eSaint,
	eOutlaw,
	eWarrior,
	eCleric,
	eMonk,
	eMage,
	eIllusionist,
	eBard,
	eDruid,
	eRanger,
	eBarbarian,
	eMedicineMan,
	ePsychic,
	eHighwayMan,
	eNinja,
	eTrader,
	eSlaver,
	eSage,
	eWitchHunter,
	ePaladin,

	eNormal,

	eClassTypeMax
}eClassType;


typedef enum _eGenders
{
	eGenderIllegal = -1,

	eGenderMale,
	eGenderFemale,
	eGenderBoth,
	eGenderOther,

	eGenderMax
}eGender;


typedef enum _eRaces
{
	eRaceIllegal = -1,

	eHuman,
	eElf,
	eHalfElf,
	eDwarf,
	eHobbit,
	eAmazon,
	eOrc,
	eHalfOrc,
	eGoblin,
	eKobold,
	eHobGoblin,
	eGnoll,
	eTroll,
	eLesserGiant,
	eGreaterGiant,
	eDragon,
	eBalrog,
	eLesserDemon,
	eGreaterDemon,
	eDemiGods,
	eMerman,
	eMerMaid,
	eOgre,
	eTitan,
	eCentaur,
	eCaveMan,
	eGargoyle,
	eFury,
	eNixie,
	eFeline,
	eCanine,
	eMammal,
	eAvian,
	ePescoids,
	eSpiders,
	eInsects,
	eExotics,
	eOther,

	eRaceMax
}eRace;

typedef enum _eLanguages
{
	eLang_Illegal = -1,

	eLang_Common,
	eLang_Human,
	eLang_Elvish,
	eLang_Dwarfish,
	eLang_Orcish,
	eLang_Giant,
	eLang_Dragon,
	eLang_Troll,
	eLang_Undead,

	eLan_Max
} eLanguages;

typedef enum _eAlignments
{
	eAlignmentIllegal = -1,

	eLawfulGood,
	eLawfulModerate,
	eLawfulSelectively,
	eLawfulEvil,
	eNeutralGood,
	eNeutralTrue,
	eNeutralMarginaly,
	eNeutralEvil,
	eChaoticGood,
	eChaoticTrue,
	eChaoticEvil,
	eAmmoral,
	eAmmoralEvil,
	eInsane,

	eAlignmentMax
}eAlignment;

typedef enum _eResistance
{
	eResistanceIllegal = -1,

	eResistanceFire,
	eResistanecCold,
	eResistanceAcid,
	eResistanceMagic,

	eResistanceMax
} eResistance;


