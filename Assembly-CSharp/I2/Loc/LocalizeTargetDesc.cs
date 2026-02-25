using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x0200138A RID: 5002
	[Token(Token = "0x200138A")]
	public abstract class LocalizeTargetDesc<T> : ILocalizeTargetDescriptor where T : ILocalizeTarget
	{
		// Token: 0x06007706 RID: 30470 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007706")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		// Token: 0x06007707 RID: 30471 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007707")]
		public override Type GetTargetType()
		{
			return null;
		}

		// Token: 0x06007708 RID: 30472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007708")]
		protected LocalizeTargetDesc()
		{
		}
	}
}
