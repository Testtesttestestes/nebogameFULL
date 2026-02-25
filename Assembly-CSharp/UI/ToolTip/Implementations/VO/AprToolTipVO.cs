using System;
using Core.Gameplay.Managers.Requirements;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;

namespace UI.ToolTip.Implementations.VO
{
	// Token: 0x02000162 RID: 354
	[Token(Token = "0x2000162")]
	public class AprToolTipVO
	{
		// Token: 0x060009F8 RID: 2552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x5D58", Offset = "0x5D58", VA = "0x5D58")]
		public AprToolTipVO()
		{
		}

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x8")]
		public AprData AprData;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0xC")]
		public RequirementsInfoProvider RequirementsInfoProvider;
	}
}
