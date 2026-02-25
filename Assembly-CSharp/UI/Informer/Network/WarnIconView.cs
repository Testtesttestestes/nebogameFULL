using System;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Informer.Network
{
	// Token: 0x020001DB RID: 475
	[Token(Token = "0x20001DB")]
	public class WarnIconView : MonoBehaviour
	{
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x00003E58 File Offset: 0x00002058
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019C")]
		public float FadeoutDuration
		{
			[Token(Token = "0x6000C5C")]
			[Address(RVA = "0x5F6B", Offset = "0x5F6B", VA = "0x5F6B")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000C5D")]
			[Address(RVA = "0x5F6C", Offset = "0x5F6C", VA = "0x5F6C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x5F6D", Offset = "0x5F6D", VA = "0x5F6D")]
		private void OnEnable()
		{
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x5F6E", Offset = "0x5F6E", VA = "0x5F6E")]
		private void OnDisable()
		{
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x5F6F", Offset = "0x5F6F", VA = "0x5F6F")]
		public void Show(int loops)
		{
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x5F70", Offset = "0x5F70", VA = "0x5F70")]
		public WarnIconView()
		{
		}

		// Token: 0x040005F5 RID: 1525
		[Token(Token = "0x40005F5")]
		[FieldOffset(Offset = "0x14")]
		private TweenerCore<Vector3, Vector3, VectorOptions> _tween;

		// Token: 0x040005F6 RID: 1526
		[Token(Token = "0x40005F6")]
		[FieldOffset(Offset = "0x18")]
		private int _loops;
	}
}
