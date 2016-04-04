//
//  Created by Robert Segal on 2016-04-04.
//  Copyright (c) 2016 Get Set Games Inc. All rights reserved.
//

namespace UnrealBuildTool.Rules
{
	public class Fyber : ModuleRules
	{
		public Fyber(TargetInfo Target)
		{
			PublicIncludePaths.AddRange(
				new string[] {
					// ... add public include paths required here ...
				}
				);

			PrivateIncludePaths.AddRange(
				new string[] {
					"Developer/Fyber/Private",
					// ... add other private include paths required here ...
				}
				);

			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
					"Engine"
					// ... add other public dependencies that you statically link with here ...
				}
				);

			PrivateDependencyModuleNames.AddRange(
				new string[]
				{
					// ... add private dependencies that you statically link with here ...
				}
				);

			DynamicallyLoadedModuleNames.AddRange(
				new string[]
				{
					// ... add any modules that your module loads dynamically here ...
				}
				);
				
			PrivateIncludePathModuleNames.AddRange(
			new string[] {
				"Settings"
			}
			);


			if (Target.Platform == UnrealTargetPlatform.IOS) {

				PublicAdditionalLibraries.Add("libFyberSDK-8.2.1.a");

				PublicFrameworks.AddRange( 
					new string[] 
					{ 
						"StoreKit",
						"Foundation",
						"CoreGraphics",
						"UIKit"
					}
				);
			}
			else if(Target.Platform == UnrealTargetPlatform.Android)
			{
				string PluginPath = Utils.MakePathRelativeTo(ModuleDirectory, BuildConfiguration.RelativeEnginePath);
				AdditionalPropertiesForReceipt.Add(new ReceiptProperty("AndroidPlugin", Path.Combine(PluginPath, "Fyber_APL.xml")));
			}
		}
	}
}