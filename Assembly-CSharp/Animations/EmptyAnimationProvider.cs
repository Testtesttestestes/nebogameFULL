using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Animations
{
	// Token: 0x0200132F RID: 4911
	[Token(Token = "0x200132F")]
	public class EmptyAnimationProvider : IAnimationProvider
	{
		// Token: 0x0600745F RID: 29791 RVA: 0x00014F58 File Offset: 0x00013158
		[Token(Token = "0x600745F")]
		[Address(RVA = "0xBE2B", Offset = "0xBE2B", VA = "0xBE2B", Slot = "4")]
		public bool TryStartAnimation(Transform target, out float duration)
		{
			return default(bool);
		}

		// Token: 0x06007460 RID: 29792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007460")]
		[Address(RVA = "0xBE2C", Offset = "0xBE2C", VA = "0xBE2C")]
		public EmptyAnimationProvider()
		{
		}
	}
}
