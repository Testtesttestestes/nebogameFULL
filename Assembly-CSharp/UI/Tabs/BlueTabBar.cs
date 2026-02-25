using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace UI.Tabs
{
	// Token: 0x02000176 RID: 374
	[Token(Token = "0x2000176")]
	public class BlueTabBar : TabBar
	{
		// Token: 0x06000A7C RID: 2684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x5DCE", Offset = "0x5DCE", VA = "0x5DCE", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x5DCF", Offset = "0x5DCF", VA = "0x5DCF", Slot = "5")]
		protected override void ResetView()
		{
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x5DD0", Offset = "0x5DD0", VA = "0x5DD0", Slot = "6")]
		protected override void HandleSelected()
		{
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x5DD1", Offset = "0x5DD1", VA = "0x5DD1")]
		private void ShowInitialAnimation(RectTransform size)
		{
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x5DD2", Offset = "0x5DD2", VA = "0x5DD2")]
		private void AdjustParticlesSettings(RectTransform size)
		{
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x5DD3", Offset = "0x5DD3", VA = "0x5DD3")]
		public BlueTabBar()
		{
		}

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		private const float PARTICLES_PER_PIXEL = 0.25f;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		private const float DURATION = 0.4f;

		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _selector;

		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ParticleSystem _selectorParticles;

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform _selectorRectTransform;

		// Token: 0x04000499 RID: 1177
		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x54")]
		private TweenContainer _tweenContainer;

		// Token: 0x0400049A RID: 1178
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x58")]
		private bool _initialAnimationShown;
	}
}
