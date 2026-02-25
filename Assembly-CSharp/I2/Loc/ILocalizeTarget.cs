using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02001387 RID: 4999
	[Token(Token = "0x2001387")]
	public abstract class ILocalizeTarget : ScriptableObject
	{
		// Token: 0x060076F7 RID: 30455
		[Token(Token = "0x60076F7")]
		public abstract bool IsValid(Localize cmp);

		// Token: 0x060076F8 RID: 30456
		[Token(Token = "0x60076F8")]
		public abstract void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm);

		// Token: 0x060076F9 RID: 30457
		[Token(Token = "0x60076F9")]
		public abstract void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation);

		// Token: 0x060076FA RID: 30458
		[Token(Token = "0x60076FA")]
		public abstract bool CanUseSecondaryTerm();

		// Token: 0x060076FB RID: 30459
		[Token(Token = "0x60076FB")]
		public abstract bool AllowMainTermToBeRTL();

		// Token: 0x060076FC RID: 30460
		[Token(Token = "0x60076FC")]
		public abstract bool AllowSecondTermToBeRTL();

		// Token: 0x060076FD RID: 30461
		[Token(Token = "0x60076FD")]
		public abstract eTermType GetPrimaryTermType(Localize cmp);

		// Token: 0x060076FE RID: 30462
		[Token(Token = "0x60076FE")]
		public abstract eTermType GetSecondaryTermType(Localize cmp);

		// Token: 0x060076FF RID: 30463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076FF")]
		[Address(RVA = "0xC06B", Offset = "0xC06B", VA = "0xC06B")]
		protected ILocalizeTarget()
		{
		}
	}
}
