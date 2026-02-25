using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly.Movement
{
	// Token: 0x02001327 RID: 4903
	[Token(Token = "0x2001327")]
	public class ToNextVisibleIsleWorldMovementInstant : AbstractWorldMovement
	{
		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x06007448 RID: 29768 RVA: 0x00014EE0 File Offset: 0x000130E0
		[Token(Token = "0x1700176F")]
		public override WorldMovementTypes Type
		{
			[Token(Token = "0x6007448")]
			[Address(RVA = "0xBE16", Offset = "0xBE16", VA = "0xBE16", Slot = "5")]
			get
			{
				return (WorldMovementTypes)0;
			}
		}

		// Token: 0x06007449 RID: 29769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007449")]
		[Address(RVA = "0xBE17", Offset = "0xBE17", VA = "0xBE17", Slot = "6")]
		public override void Move(Vector3 target, Camera camera, Action callback)
		{
		}

		// Token: 0x0600744A RID: 29770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600744A")]
		[Address(RVA = "0xBE18", Offset = "0xBE18", VA = "0xBE18")]
		public ToNextVisibleIsleWorldMovementInstant()
		{
		}
	}
}
