// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class OnlineSubsystemEOS : ModuleRules
{
	public OnlineSubsystemEOS(ReadOnlyTargetRules Target) : base(Target)
	{
		PrivateDefinitions.Add("ONLINESUBSYSTEMEOS_PACKAGE=1");

		PublicDependencyModuleNames.AddRange(
			new string[] {
				"OnlineSubsystemUtils",
				"EOSSDK"
			}
		);

		PrivateDependencyModuleNames.AddRange(
			new string[] {
				"Core",
				"CoreOnline",
				"CoreUObject",
				"Engine",
				"EOSShared",
				"EOSVoiceChat",
				"Json",
				"OnlineSubsystem",
				"Sockets",
				"SocketSubsystemEOS",
				"VoiceChat",
				"NetCore"
			}
		);

		PrivateDefinitions.Add("USE_XBL_XSTS_TOKEN=" + (bUseXblXstsToken ? "1" : "0"));
		PrivateDefinitions.Add("USE_PSN_ID_TOKEN=" + (bUsePsnIdToken ? "1" : "0"));
		PrivateDefinitions.Add("ADD_USER_LOGIN_INFO=" + (bAddUserLoginInfo ? "1" : "0"));

		// Temp fix, add Private folder to PublicIncludePaths in 5.0.1 so OnlineSubsystemEOS.h is includeable. Fixed properly in 5.1.
		PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Private"));
	}

	protected virtual bool bUseXblXstsToken { get { return false; } }
	protected virtual bool bUsePsnIdToken { get { return false; } }
	protected virtual bool bAddUserLoginInfo { get { return false; } }
}
