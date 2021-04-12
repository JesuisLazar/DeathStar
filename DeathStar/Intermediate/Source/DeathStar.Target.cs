using UnrealBuildTool;

public class DeathStarTarget : TargetRules
{
	public DeathStarTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("DeathStar");
	}
}
