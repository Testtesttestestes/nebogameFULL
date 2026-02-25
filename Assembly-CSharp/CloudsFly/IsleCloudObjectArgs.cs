using System;
using Gameplay.Isles.Base;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x020012ED RID: 4845
	[Token(Token = "0x20012ED")]
	public class IsleCloudObjectArgs : WorldObjectArgs
	{
		// Token: 0x06007358 RID: 29528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007358")]
		[Address(RVA = "0xBD61", Offset = "0xBD61", VA = "0xBD61")]
		public IsleCloudObjectArgs(Vector3 position, IIsle isle)
		{
		}

		// Token: 0x04003C5E RID: 15454
		[Token(Token = "0x4003C5E")]
		[FieldOffset(Offset = "0x18")]
		public readonly IIsle Isle;
	}
}
