using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly.Movement
{
	// Token: 0x02001319 RID: 4889
	[Token(Token = "0x2001319")]
	public class ToHomeInitialWorldMovement : AbstractWorldMovement
	{
		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x0600741D RID: 29725 RVA: 0x00014E08 File Offset: 0x00013008
		[Token(Token = "0x17001766")]
		public override WorldMovementTypes Type
		{
			[Token(Token = "0x600741D")]
			[Address(RVA = "0xBDEB", Offset = "0xBDEB", VA = "0xBDEB", Slot = "5")]
			get
			{
				return (WorldMovementTypes)0;
			}
		}

		// Token: 0x0600741E RID: 29726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600741E")]
		[Address(RVA = "0xBDEC", Offset = "0xBDEC", VA = "0xBDEC", Slot = "6")]
		public override void Move(Vector3 target, Camera camera, Action callback)
		{
		}

		// Token: 0x0600741F RID: 29727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600741F")]
		[Address(RVA = "0xBDED", Offset = "0xBDED", VA = "0xBDED")]
		public ToHomeInitialWorldMovement()
		{
		}
	}
}
