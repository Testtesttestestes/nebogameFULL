using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly.Movement
{
	// Token: 0x0200131C RID: 4892
	[Token(Token = "0x200131C")]
	public class ToHomeWorldMovement : AbstractWorldMovement
	{
		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x06007427 RID: 29735 RVA: 0x00014E38 File Offset: 0x00013038
		[Token(Token = "0x17001768")]
		public override WorldMovementTypes Type
		{
			[Token(Token = "0x6007427")]
			[Address(RVA = "0xBDF5", Offset = "0xBDF5", VA = "0xBDF5", Slot = "5")]
			get
			{
				return (WorldMovementTypes)0;
			}
		}

		// Token: 0x06007428 RID: 29736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007428")]
		[Address(RVA = "0xBDF6", Offset = "0xBDF6", VA = "0xBDF6", Slot = "6")]
		public override void Move(Vector3 target, Camera camera, Action callback)
		{
		}

		// Token: 0x06007429 RID: 29737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007429")]
		[Address(RVA = "0xBDF7", Offset = "0xBDF7", VA = "0xBDF7", Slot = "8")]
		public override void Dispose()
		{
		}

		// Token: 0x0600742A RID: 29738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600742A")]
		[Address(RVA = "0xBDF8", Offset = "0xBDF8", VA = "0xBDF8")]
		public ToHomeWorldMovement()
		{
		}

		// Token: 0x04003CD4 RID: 15572
		[Token(Token = "0x4003CD4")]
		[FieldOffset(Offset = "0xC")]
		private Camera _camera;
	}
}
