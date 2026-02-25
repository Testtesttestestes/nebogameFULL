using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly.Movement
{
	// Token: 0x0200131E RID: 4894
	[Token(Token = "0x200131E")]
	public class ToHomeWorldMovementInstant : AbstractWorldMovement
	{
		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x0600742D RID: 29741 RVA: 0x00014E50 File Offset: 0x00013050
		[Token(Token = "0x17001769")]
		public override WorldMovementTypes Type
		{
			[Token(Token = "0x600742D")]
			[Address(RVA = "0xBDFB", Offset = "0xBDFB", VA = "0xBDFB", Slot = "5")]
			get
			{
				return (WorldMovementTypes)0;
			}
		}

		// Token: 0x0600742E RID: 29742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600742E")]
		[Address(RVA = "0xBDFC", Offset = "0xBDFC", VA = "0xBDFC", Slot = "6")]
		public override void Move(Vector3 target, Camera camera, Action callback)
		{
		}

		// Token: 0x0600742F RID: 29743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600742F")]
		[Address(RVA = "0xBDFD", Offset = "0xBDFD", VA = "0xBDFD")]
		public ToHomeWorldMovementInstant()
		{
		}
	}
}
