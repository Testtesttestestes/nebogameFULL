using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UI.Elements.RightPanel.TitledList.Elements.UpgradeRequirements;

namespace UI.Elements.RightPanel.TitledList.Elements
{
	// Token: 0x02000211 RID: 529
	[Token(Token = "0x2000211")]
	public class UpgradeRequirementsTitledListElementArgs : BaseTitledListElementArgs
	{
		// Token: 0x06000D4F RID: 3407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4F")]
		[Address(RVA = "0x6032", Offset = "0x6032", VA = "0x6032")]
		public UpgradeRequirementsTitledListElementArgs(List<UpgradeRequirementElementArgs> upgradeRequirement)
		{
		}

		// Token: 0x04000695 RID: 1685
		[Token(Token = "0x4000695")]
		[FieldOffset(Offset = "0x8")]
		public List<UpgradeRequirementElementArgs> upgradeRequirement;
	}
}
