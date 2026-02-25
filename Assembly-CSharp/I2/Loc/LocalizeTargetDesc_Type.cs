using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200138B RID: 5003
	[Token(Token = "0x200138B")]
	public class LocalizeTargetDesc_Type<T, G> : LocalizeTargetDesc<G> where T : UnityEngine.Object where G : LocalizeTarget<T>
	{
		// Token: 0x06007709 RID: 30473 RVA: 0x00015900 File Offset: 0x00013B00
		[Token(Token = "0x6007709")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		// Token: 0x0600770A RID: 30474 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600770A")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		// Token: 0x0600770B RID: 30475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600770B")]
		public LocalizeTargetDesc_Type()
		{
		}
	}
}
