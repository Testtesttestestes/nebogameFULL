using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.ResourceBar.View
{
	// Token: 0x0200054C RID: 1356
	[Token(Token = "0x200054C")]
	public class ResourceBarDeltaView : ResourceBarIconValueView
	{
		// Token: 0x0600208E RID: 8334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208E")]
		[Address(RVA = "0x71F3", Offset = "0x71F3", VA = "0x71F3")]
		public void ShowAnimation(ResourceBarItemView.ResourceDeltaData deltaData, float duration, Action<ResourceBarDeltaView> completeCallback)
		{
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208F")]
		[Address(RVA = "0x71F4", Offset = "0x71F4", VA = "0x71F4")]
		private void SetupCloud()
		{
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002090")]
		[Address(RVA = "0x71F5", Offset = "0x71F5", VA = "0x71F5")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002091")]
		[Address(RVA = "0x71F6", Offset = "0x71F6", VA = "0x71F6")]
		public void Reset()
		{
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002092")]
		[Address(RVA = "0x71F7", Offset = "0x71F7", VA = "0x71F7")]
		public ResourceBarDeltaView()
		{
		}

		// Token: 0x040011C1 RID: 4545
		[Token(Token = "0x40011C1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040011C2 RID: 4546
		[Token(Token = "0x40011C2")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Image _cloud;

		// Token: 0x040011C3 RID: 4547
		[Token(Token = "0x40011C3")]
		[FieldOffset(Offset = "0x38")]
		private ResourceBarItemView.ResourceDeltaData _deltaData;

		// Token: 0x040011C4 RID: 4548
		[Token(Token = "0x40011C4")]
		[FieldOffset(Offset = "0x3C")]
		private TweenContainer _tweenContainer;
	}
}
