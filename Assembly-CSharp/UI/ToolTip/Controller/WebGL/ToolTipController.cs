using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ToolTip.Controller.WebGL
{
	// Token: 0x0200016C RID: 364
	[Token(Token = "0x200016C")]
	public class ToolTipController : BaseToolTipController
	{
		// Token: 0x06000A26 RID: 2598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x5D7D", Offset = "0x5D7D", VA = "0x5D7D")]
		public ToolTipController(Canvas canvas, RectTransform layer, Vector2 padding)
		{
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x5D7E", Offset = "0x5D7E", VA = "0x5D7E", Slot = "10")]
		public override void Show(IToolTipSource source)
		{
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x5D7F", Offset = "0x5D7F", VA = "0x5D7F", Slot = "12")]
		protected override void GetPointerPosition(out Vector3 position)
		{
		}

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x30")]
		private Tweener _tweener;
	}
}
