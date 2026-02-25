using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Tutorial.Guide.View.Outline
{
	// Token: 0x0200046D RID: 1133
	[Token(Token = "0x200046D")]
	[Serializable]
	public class PulseAnimation
	{
		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004AE")]
		public Image[] Images
		{
			[Token(Token = "0x6001AE3")]
			[Address(RVA = "0x6C6D", Offset = "0x6C6D", VA = "0x6C6D")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE4")]
		[Address(RVA = "0x6C6E", Offset = "0x6C6E", VA = "0x6C6E")]
		public void Play()
		{
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE5")]
		[Address(RVA = "0x6C6F", Offset = "0x6C6F", VA = "0x6C6F")]
		public void Stop()
		{
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE6")]
		[Address(RVA = "0x6C70", Offset = "0x6C70", VA = "0x6C70")]
		public PulseAnimation()
		{
		}

		// Token: 0x04000E76 RID: 3702
		[Token(Token = "0x4000E76")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private Image[] _images;

		// Token: 0x04000E77 RID: 3703
		[Token(Token = "0x4000E77")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private Vector2 _sizeOffset;

		// Token: 0x04000E78 RID: 3704
		[Token(Token = "0x4000E78")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _interval;

		// Token: 0x04000E79 RID: 3705
		[Token(Token = "0x4000E79")]
		[FieldOffset(Offset = "0x18")]
		private TweenContainer _tweenContainer;
	}
}
