



//// macro to convert the string to "wide" format
//// <NOTE>because CW has an issue with whitespaces in MACROS
//// 3 #'s are used intentionally, 1 to display as a string literal
//// and the other 2 to concatenate out any whitespace
//#define StringResource(_string_)	L###_string_

#undef ADD_RACE_TYPES

#if defined(INCLUDE_AS_ENUM)
#define ADD_RACE_TYPES(id,str_val) id,
#elif defined(INCLUDE_AS_STRING)
#define ADD_RACE_TYPES(id,str_val) str_val,
#else
#error	To use this include file, first define INCLUDE_AS_ENUM or INCLUDE_AS_STRING to include the strings as enums or string constants.
#endif

ADD_RACE_TYPES(eHuman, "Human")
ADD_RACE_TYPES(eElf, "Elf")
ADD_RACE_TYPES(eHalfElf, "Half Elf")
ADD_RACE_TYPES(eDwarf, "Dwarf")
ADD_RACE_TYPES(eHobbit, "Hobbit")
ADD_RACE_TYPES(eAmazon, "Amazon")
ADD_RACE_TYPES(eOrc, "Orc")
ADD_RACE_TYPES(eHalfOrc, "Half Orc")
ADD_RACE_TYPES(eGoblin, "Goblin")
ADD_RACE_TYPES(eKobold, "Kobold")
ADD_RACE_TYPES(eHobGoblin, "Hobgoblin")
ADD_RACE_TYPES(eGnoll, "Gnoll")
ADD_RACE_TYPES(eTroll, "Troll")
ADD_RACE_TYPES(eLesserGiant, "Lesser Giant")
ADD_RACE_TYPES(eGreaterGiant, "Greater Giant")
ADD_RACE_TYPES(eDragon, "Dragon")
ADD_RACE_TYPES(eBalrog, "Balrog")
ADD_RACE_TYPES(eLesserDemon, "Lesser Demon")
ADD_RACE_TYPES(eGreaterDemon, "Greater Demon")
ADD_RACE_TYPES(eDemiGods, "Demi God")
ADD_RACE_TYPES(eMerman, "Mermen")
ADD_RACE_TYPES(eMerMaid, "Mermaid")
ADD_RACE_TYPES(eOgre, "Ogre")
ADD_RACE_TYPES(eTitan, "Titan")
ADD_RACE_TYPES(eCentaur, "Centaur")
ADD_RACE_TYPES(eCaveMan, "Caveman")
ADD_RACE_TYPES(eGargoyle, "Gargoyle")
ADD_RACE_TYPES(eFury, "Fury")
ADD_RACE_TYPES(eNixie, "Nixie")
ADD_RACE_TYPES(eFeline, "Feline")
ADD_RACE_TYPES(eCanine, "Canine")
ADD_RACE_TYPES(eMammal, "Mammal")
ADD_RACE_TYPES(eAvian, "Avian")
ADD_RACE_TYPES(ePescoids, "Pescoids")
ADD_RACE_TYPES(eSpiders, "Spiders")
ADD_RACE_TYPES(eInsects, "Insects")
ADD_RACE_TYPES(eExotics, "Exotics")
ADD_RACE_TYPES(eOther, "Other")



