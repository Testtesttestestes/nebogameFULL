using System;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;

namespace Core.Animations
{
	// Token: 0x02001278 RID: 4728
	[Token(Token = "0x2001278")]
	public class AlphaSpineUI : IDisposable
	{
		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x0600702B RID: 28715 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016E2")]
		private SkeletonGraphic SkeletonGraphic
		{
			[Token(Token = "0x600702B")]
			[Address(RVA = "0xBA70", Offset = "0xBA70", VA = "0xBA70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x0600702C RID: 28716 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016E3")]
		private Material CachedMaterial
		{
			[Token(Token = "0x600702C")]
			[Address(RVA = "0xBA71", Offset = "0xBA71", VA = "0xBA71")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600702D RID: 28717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600702D")]
		[Address(RVA = "0xBA72", Offset = "0xBA72", VA = "0xBA72")]
		public AlphaSpineUI(ISkeletonGraphicProvider skeletonGraphicProvider)
		{
		}

		// Token: 0x0600702E RID: 28718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600702E")]
		[Address(RVA = "0xBA73", Offset = "0xBA73", VA = "0xBA73")]
		public void SetAlpha(float value)
		{
		}

		// Token: 0x0600702F RID: 28719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600702F")]
		[Address(RVA = "0xBA74", Offset = "0xBA74", VA = "0xBA74", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04003A88 RID: 14984
		[Token(Token = "0x4003A88")]
		[FieldOffset(Offset = "0x8")]
		private float _alpha;

		// Token: 0x04003A89 RID: 14985
		[Token(Token = "0x4003A89")]
		[FieldOffset(Offset = "0xC")]
		private Material _cachedMaterial;

		// Token: 0x04003A8A RID: 14986
		[Token(Token = "0x4003A8A")]
		[FieldOffset(Offset = "0x10")]
		private ISkeletonGraphicProvider _skeletonGraphicProvider;
	}
}
