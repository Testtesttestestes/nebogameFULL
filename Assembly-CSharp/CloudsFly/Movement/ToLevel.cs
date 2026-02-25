using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly.Movement
{
	// Token: 0x02001322 RID: 4898
	[Token(Token = "0x2001322")]
	public class ToLevel : AbstractWorldMovement
	{
		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x06007439 RID: 29753 RVA: 0x00014E98 File Offset: 0x00013098
		[Token(Token = "0x1700176C")]
		public override WorldMovementTypes Type
		{
			[Token(Token = "0x6007439")]
			[Address(RVA = "0xBE07", Offset = "0xBE07", VA = "0xBE07", Slot = "5")]
			get
			{
				return (WorldMovementTypes)0;
			}
		}

		// Token: 0x0600743A RID: 29754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600743A")]
		[Address(RVA = "0xBE08", Offset = "0xBE08", VA = "0xBE08", Slot = "6")]
		public override void Move(Vector3 target, Camera camera, Action callback)
		{
		}

		// Token: 0x0600743B RID: 29755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600743B")]
		[Address(RVA = "0xBE09", Offset = "0xBE09", VA = "0xBE09", Slot = "8")]
		public override void Dispose()
		{
		}

		// Token: 0x0600743C RID: 29756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600743C")]
		[Address(RVA = "0xBE0A", Offset = "0xBE0A", VA = "0xBE0A")]
		public ToLevel()
		{
		}

		// Token: 0x04003CD8 RID: 15576
		[Token(Token = "0x4003CD8")]
		[FieldOffset(Offset = "0xC")]
		private Camera _camera;
	}
}
