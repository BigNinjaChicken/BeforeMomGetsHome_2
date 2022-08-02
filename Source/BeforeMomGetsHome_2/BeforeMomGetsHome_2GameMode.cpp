// Copyright Epic Games, Inc. All Rights Reserved.

#include "BeforeMomGetsHome_2GameMode.h"
#include "BeforeMomGetsHome_2Character.h"
#include "UObject/ConstructorHelpers.h"

ABeforeMomGetsHome_2GameMode::ABeforeMomGetsHome_2GameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
