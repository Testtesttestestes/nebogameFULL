using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly.Movement
{
	// Token: 0x0200131F RID: 4895
	[Token(Token = "0x200131F")]
	public class ToIsleAfterLevelChanges : AbstractWorldMovement
	{
		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x06007430 RID: 29744 RVA: 0x00014E68 File Offset: 0x00013068
		[Token(Token = "0x1700176A")]
		public override WorldMovementTypes Type
		{
			[Token(Token = "0x6007430")]
			[Address(RVA = "0xBDFE", Offset = "0xBDFE", VA = "0xBDFE", Slot = "5")]
			get
			{
				return (WorldMovementTypes)0;
			}
		}

		// Token: 0x06007431 RID: 29745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007431")]
		[Address(RVA = "0xBDFF", Offset = "0xBDFF", VA = "0xBDFF", Slot = "6")]
		public override void Move(Vector3 target, Camera camera, Action callback)
		{
		}

		// Token: 0x06007432 RID: 29746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007432")]
		[Address(RVA = "0xBE00", Offset = "0xBE00", VA = "0xBE00", Slot = "8")]
		public override void Dispose()
		{
		}

		// Token: 0x06007433 RID: 29747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007433")]
		[Address(RVA = "0xBE01", Offset = "0xBE01", VA = "0xBE01")]
		public ToIsleAfterLevelChanges()
		{
		}

		// Token: 0x04003CD6 RID: 15574
		[Token(Token = "0x4003CD6")]
		[FieldOffset(Offset = "0xC")]
		private Camera _camera;
	}
}
