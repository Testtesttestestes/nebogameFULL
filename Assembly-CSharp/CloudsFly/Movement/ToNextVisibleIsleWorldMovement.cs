using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly.Movement
{
	// Token: 0x02001325 RID: 4901
	[Token(Token = "0x2001325")]
	public class ToNextVisibleIsleWorldMovement : AbstractWorldMovement
	{
		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x06007442 RID: 29762 RVA: 0x00014EC8 File Offset: 0x000130C8
		[Token(Token = "0x1700176E")]
		public override WorldMovementTypes Type
		{
			[Token(Token = "0x6007442")]
			[Address(RVA = "0xBE10", Offset = "0xBE10", VA = "0xBE10", Slot = "5")]
			get
			{
				return (WorldMovementTypes)0;
			}
		}

		// Token: 0x06007443 RID: 29763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007443")]
		[Address(RVA = "0xBE11", Offset = "0xBE11", VA = "0xBE11", Slot = "6")]
		public override void Move(Vector3 target, Camera camera, Action callback)
		{
		}

		// Token: 0x06007444 RID: 29764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007444")]
		[Address(RVA = "0xBE12", Offset = "0xBE12", VA = "0xBE12", Slot = "8")]
		public override void Dispose()
		{
		}

		// Token: 0x06007445 RID: 29765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007445")]
		[Address(RVA = "0xBE13", Offset = "0xBE13", VA = "0xBE13")]
		public ToNextVisibleIsleWorldMovement()
		{
		}

		// Token: 0x04003CDA RID: 15578
		[Token(Token = "0x4003CDA")]
		[FieldOffset(Offset = "0xC")]
		private Camera _camera;
	}
}
