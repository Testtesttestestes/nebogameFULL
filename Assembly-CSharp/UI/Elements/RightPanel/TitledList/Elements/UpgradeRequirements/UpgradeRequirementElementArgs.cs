using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Elements.RightPanel.TitledList.Elements.UpgradeRequirements
{
	// Token: 0x02000213 RID: 531
	[Token(Token = "0x2000213")]
	public class UpgradeRequirementElementArgs
	{
		// Token: 0x06000D52 RID: 3410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x6035", Offset = "0x6035", VA = "0x6035")]
		public UpgradeRequirementElementArgs(Sprite collected, string requirement)
		{
		}

		// Token: 0x04000698 RID: 1688
		[Token(Token = "0x4000698")]
		[FieldOffset(Offset = "0x8")]
		public Sprite collected;

		// Token: 0x04000699 RID: 1689
		[Token(Token = "0x4000699")]
		[FieldOffset(Offset = "0xC")]
		public string requirement;
	}
}
