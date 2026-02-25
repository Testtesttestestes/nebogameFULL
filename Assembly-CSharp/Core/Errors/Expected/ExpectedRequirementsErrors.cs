using System;
using System.Collections.Generic;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using UI.Windows;

namespace Core.Errors.Expected
{
	// Token: 0x0200106C RID: 4204
	[Token(Token = "0x200106C")]
	public class ExpectedRequirementsErrors : ExpectedDefaultError
	{
		// Token: 0x0600626C RID: 25196 RVA: 0x000126C0 File Offset: 0x000108C0
		[Token(Token = "0x600626C")]
		[Address(RVA = "0xAE92", Offset = "0xAE92", VA = "0xAE92", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600626D RID: 25197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600626D")]
		[Address(RVA = "0xAE93", Offset = "0xAE93", VA = "0xAE93")]
		protected void Show(RequirementsWindow.RequirementsWindowArgs windowArgs)
		{
		}

		// Token: 0x0600626E RID: 25198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600626E")]
		[Address(RVA = "0xAE94", Offset = "0xAE94", VA = "0xAE94")]
		public ExpectedRequirementsErrors()
		{
		}

		// Token: 0x0200106D RID: 4205
		[Token(Token = "0x200106D")]
		public class ExpectedRequirementsErrorsArgs
		{
			// Token: 0x0600626F RID: 25199 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600626F")]
			[Address(RVA = "0xAE95", Offset = "0xAE95", VA = "0xAE95")]
			public ExpectedRequirementsErrorsArgs(UserData user, RequirementDic requirements)
			{
			}

			// Token: 0x06006270 RID: 25200 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006270")]
			[Address(RVA = "0xAE96", Offset = "0xAE96", VA = "0xAE96")]
			public ExpectedRequirementsErrorsArgs(UserData user, ResourceSet cost, IList<RestrictionInfo> restrictions, IList<RewardInfo> materials)
			{
			}

			// Token: 0x040034E7 RID: 13543
			[Token(Token = "0x40034E7")]
			[FieldOffset(Offset = "0x8")]
			public UserData User;

			// Token: 0x040034E8 RID: 13544
			[Token(Token = "0x40034E8")]
			[FieldOffset(Offset = "0xC")]
			public ResourceSet Cost;

			// Token: 0x040034E9 RID: 13545
			[Token(Token = "0x40034E9")]
			[FieldOffset(Offset = "0x10")]
			public IList<RestrictionInfo> RestrictionInfos;

			// Token: 0x040034EA RID: 13546
			[Token(Token = "0x40034EA")]
			[FieldOffset(Offset = "0x14")]
			public IList<RewardInfo> Materials;
		}
	}
}
