using UnrealBuildTool;

public class HeroesFromGaulTarget : TargetRules
{
	public HeroesFromGaulTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("HeroesFromGaul");
	}
}
