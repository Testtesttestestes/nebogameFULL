using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02001388 RID: 5000
	[Token(Token = "0x2001388")]
	public abstract class LocalizeTarget<T> : ILocalizeTarget where T : UnityEngine.Object
	{
		// Token: 0x06007700 RID: 30464 RVA: 0x000158E8 File Offset: 0x00013AE8
		[Token(Token = "0x6007700")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		// Token: 0x06007701 RID: 30465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007701")]
		protected LocalizeTarget()
		{
		}

		// Token: 0x04003E47 RID: 15943
		[Token(Token = "0x4003E47")]
		[FieldOffset(Offset = "0x0")]
		public T mTarget;
	}
}
