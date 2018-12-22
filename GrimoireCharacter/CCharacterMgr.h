#pragma once

//**************************************************************************************************
//
//	Author: Matthew Altman
//	Date:	10/21/2017
//
//	Manager class responsible for allocation/deallocation and
//		management of all character object resources.   
//		Provides a common interface for external objects
//		and resources
//
//**************************************************************************************************


//#include "CCharacter.h"
#include <vector>
class CCharacter;

// make this a singleton

class CCharacterMgr
{
private:
	// Singleton Instance
	static CCharacterMgr	m_Instance;

	// Member Variables
	std::vector<CCharacter*> m_Characters;

protected:
	// Singleton: Protect the constructor
	CCharacterMgr() {}

public:
	~CCharacterMgr() {}

	// Singleton Accessor
	static CCharacterMgr* GetInstance();

	// Member Functions
	CCharacter* CreateCharacter();
};

//extern CCharacterMgr* g_pCharacterMgr;