using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly.Movement
{
	// Token: 0x02001318 RID: 4888
	[Token(Token = "0x2001318")]
	public class ToFarIsleWorldMovementInstant : AbstractWorldMovement
	{
		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x0600741A RID: 29722 RVA: 0x00014DF0 File Offset: 0x00012FF0
		[Token(Token = "0x17001765")]
		public override WorldMovementTypes Type
		{
			[Token(Token = "0x600741A")]
			[Address(RVA = "0xBDE8", Offset = "0xBDE8", VA = "0xBDE8", Slot = "5")]
			get
			{
				return (WorldMovementTypes)0;
			}
		}

		// Token: 0x0600741B RID: 29723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600741B")]
		[Address(RVA = "0xBDE9", Offset = "0xBDE9", VA = "0xBDE9", Slot = "6")]
		public override void Move(Vector3 target, Camera camera, Action callback)
		{
		}

		// Token: 0x0600741C RID: 29724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600741C")]
		[Address(RVA = "0xBDEA", Offset = "0xBDEA", VA = "0xBDEA")]
		public ToFarIsleWorldMovementInstant()
		{
		}
	}
}
