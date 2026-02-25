using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Utils.Fps
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	public class FpsCounter : AbstractFpsCounter
	{
		// Token: 0x0600032E RID: 814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x579C", Offset = "0x579C", VA = "0x579C", Slot = "4")]
		public override void HandleUpdate()
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x579D", Offset = "0x579D", VA = "0x579D", Slot = "5")]
		public override void HandleFpsCalculated(float fps)
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x579E", Offset = "0x579E", VA = "0x579E")]
		public FpsCounter()
		{
		}

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _image;
	}
}
