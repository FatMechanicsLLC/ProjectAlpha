
//// macro to convert the string to "wide" format
//// <NOTE>because CW has an issue with whitespaces in MACROS
//// 3 #'s are used intentionally, 1 to display as a string literal
//// and the other 2 to concatenate out any whitespace
//#define StringResource(_string_)	L###_string_

#undef ADD_CLASS_TYPES

#if defined(INCLUDE_AS_ENUM)
#define ADD_CLASS_TYPES(id,str_val) id,
#elif defined(INCLUDE_AS_STRING)
#define ADD_CLASS_TYPES(id,str_val) str_val,
#else
#error	To use this include file, first define INCLUDE_AS_ENUM or INCLUDE_AS_STRING to include the strings as enums or string constants.
#endif


ADD_CLASS_TYPES(eThief, "Thief")
ADD_CLASS_TYPES(eSlayer, "Slayer")
ADD_CLASS_TYPES(eTechno, "Techno")
ADD_CLASS_TYPES(eCourtesan, "Courtesan")
ADD_CLASS_TYPES(eAssassin, "Assassin")
ADD_CLASS_TYPES(eAlchemist, "Alchemist")
ADD_CLASS_TYPES(eRuneWeaver, "Rune Weaver")
ADD_CLASS_TYPES(eSaint, "Saint")
ADD_CLASS_TYPES(eOutlaw, "Outlaw")
ADD_CLASS_TYPES(eWarrior, "Warrior")
ADD_CLASS_TYPES(eCleric, "Cleric")
ADD_CLASS_TYPES(eMonk, "Monk")
ADD_CLASS_TYPES(eMage, "Mage")
ADD_CLASS_TYPES(eIllusionist, "Illusionist")
ADD_CLASS_TYPES(eBard, "Bard")
ADD_CLASS_TYPES(eDruid, "Druid")
ADD_CLASS_TYPES(eRanger, "Ranger")
ADD_CLASS_TYPES(eBarbarian, "Barbarian")
ADD_CLASS_TYPES(eMedicineMan, "Medicine Man")
ADD_CLASS_TYPES(ePsychic, "Psychic")
ADD_CLASS_TYPES(eHighwayMan, "Highway Man")
ADD_CLASS_TYPES(eNinja, "Ninja")
ADD_CLASS_TYPES(eTrader, "Trader")
ADD_CLASS_TYPES(eSlaver, "Slaver")
ADD_CLASS_TYPES(eSage, "Sage")
ADD_CLASS_TYPES(eWitchHunter, "Witch Hunter")
ADD_CLASS_TYPES(ePaladin, "Paladin")
ADD_CLASS_TYPES(eNormal, "Normal")
