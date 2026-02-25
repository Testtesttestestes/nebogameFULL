using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly.Movement
{
	// Token: 0x02001324 RID: 4900
	[Token(Token = "0x2001324")]
	public class ToLevelInstant : AbstractWorldMovement
	{
		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x0600743F RID: 29759 RVA: 0x00014EB0 File Offset: 0x000130B0
		[Token(Token = "0x1700176D")]
		public override WorldMovementTypes Type
		{
			[Token(Token = "0x600743F")]
			[Address(RVA = "0xBE0D", Offset = "0xBE0D", VA = "0xBE0D", Slot = "5")]
			get
			{
				return (WorldMovementTypes)0;
			}
		}

		// Token: 0x06007440 RID: 29760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007440")]
		[Address(RVA = "0xBE0E", Offset = "0xBE0E", VA = "0xBE0E", Slot = "6")]
		public override void Move(Vector3 target, Camera camera, Action callback)
		{
		}

		// Token: 0x06007441 RID: 29761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007441")]
		[Address(RVA = "0xBE0F", Offset = "0xBE0F", VA = "0xBE0F")]
		public ToLevelInstant()
		{
		}
	}
}
