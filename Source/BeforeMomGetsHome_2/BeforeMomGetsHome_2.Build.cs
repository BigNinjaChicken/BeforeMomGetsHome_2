// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class BeforeMomGetsHome_2 : ModuleRules
{
	public BeforeMomGetsHome_2(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
