using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly.Movement
{
	// Token: 0x02001316 RID: 4886
	[Token(Token = "0x2001316")]
	public class ToFarIsleWorldMovement : AbstractWorldMovement
	{
		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x06007415 RID: 29717 RVA: 0x00014DD8 File Offset: 0x00012FD8
		[Token(Token = "0x17001764")]
		public override WorldMovementTypes Type
		{
			[Token(Token = "0x6007415")]
			[Address(RVA = "0xBDE3", Offset = "0xBDE3", VA = "0xBDE3", Slot = "5")]
			get
			{
				return (WorldMovementTypes)0;
			}
		}

		// Token: 0x06007416 RID: 29718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007416")]
		[Address(RVA = "0xBDE4", Offset = "0xBDE4", VA = "0xBDE4", Slot = "6")]
		public override void Move(Vector3 target, Camera camera, Action callback)
		{
		}

		// Token: 0x06007417 RID: 29719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007417")]
		[Address(RVA = "0xBDE5", Offset = "0xBDE5", VA = "0xBDE5")]
		public ToFarIsleWorldMovement()
		{
		}
	}
}
