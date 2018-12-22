
#include "pch.h"
#include "CCharacter.h"
#include "CCharacterMgr.h"

CCharacterMgr  CCharacterMgr::m_Instance;

CCharacterMgr* CCharacterMgr::GetInstance()
{
	return &m_Instance;
}

CCharacter* CCharacterMgr::CreateCharacter()
{	
	CCharacter* pCharacter = nullptr;

	pCharacter = new CCharacter;
	if (!pCharacter) {
		assert(0 && "CCharacterMgr::CreateCharacter:  Could not allocate a character");
		return nullptr;
	}
	else {
		m_Characters.push_back(pCharacter);
		return pCharacter;
	}

}