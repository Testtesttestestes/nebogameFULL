using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly.Movement
{
	// Token: 0x0200131B RID: 4891
	[Token(Token = "0x200131B")]
	public class ToHomeInitialWorldMovementInstant : AbstractWorldMovement
	{
		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x06007424 RID: 29732 RVA: 0x00014E20 File Offset: 0x00013020
		[Token(Token = "0x17001767")]
		public override WorldMovementTypes Type
		{
			[Token(Token = "0x6007424")]
			[Address(RVA = "0xBDF2", Offset = "0xBDF2", VA = "0xBDF2", Slot = "5")]
			get
			{
				return (WorldMovementTypes)0;
			}
		}

		// Token: 0x06007425 RID: 29733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007425")]
		[Address(RVA = "0xBDF3", Offset = "0xBDF3", VA = "0xBDF3", Slot = "6")]
		public override void Move(Vector3 target, Camera camera, Action callback)
		{
		}

		// Token: 0x06007426 RID: 29734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007426")]
		[Address(RVA = "0xBDF4", Offset = "0xBDF4", VA = "0xBDF4")]
		public ToHomeInitialWorldMovementInstant()
		{
		}
	}
}
