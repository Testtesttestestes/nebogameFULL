using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly.Movement
{
	// Token: 0x02001321 RID: 4897
	[Token(Token = "0x2001321")]
	public class ToIsleAfterLevelChangesInstant : AbstractWorldMovement
	{
		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x06007436 RID: 29750 RVA: 0x00014E80 File Offset: 0x00013080
		[Token(Token = "0x1700176B")]
		public override WorldMovementTypes Type
		{
			[Token(Token = "0x6007436")]
			[Address(RVA = "0xBE04", Offset = "0xBE04", VA = "0xBE04", Slot = "5")]
			get
			{
				return (WorldMovementTypes)0;
			}
		}

		// Token: 0x06007437 RID: 29751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007437")]
		[Address(RVA = "0xBE05", Offset = "0xBE05", VA = "0xBE05", Slot = "6")]
		public override void Move(Vector3 target, Camera camera, Action callback)
		{
		}

		// Token: 0x06007438 RID: 29752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007438")]
		[Address(RVA = "0xBE06", Offset = "0xBE06", VA = "0xBE06")]
		public ToIsleAfterLevelChangesInstant()
		{
		}
	}
}
