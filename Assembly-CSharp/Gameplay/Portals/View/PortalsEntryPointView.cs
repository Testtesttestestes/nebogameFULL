using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CloudsFly;
using Core.Animations;
using Core.Events.Scopes;
using Core.Materials;
using DG.Tweening;
using Gameplay.Isles.User;
using Gameplay.Portals.Controller;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using Utils;

namespace Gameplay.Portals.View
{
	// Token: 0x020005AF RID: 1455
	[Token(Token = "0x20005AF")]
	public class PortalsEntryPointView : BaseWorldObjectRenderer, IDisposable, IPointerClickHandler, IEventSystemHandler, IAlpha
	{
		// Token: 0x1400014B RID: 331
		// (add) Token: 0x060022E0 RID: 8928 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060022E1 RID: 8929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400014B")]
		public event Action ClickEvent
		{
			[Token(Token = "0x60022E0")]
			[Address(RVA = "0x7434", Offset = "0x7434", VA = "0x7434")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60022E1")]
			[Address(RVA = "0x7435", Offset = "0x7435", VA = "0x7435")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E2")]
		[Address(RVA = "0x7436", Offset = "0x7436", VA = "0x7436")]
		private void Awake()
		{
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E3")]
		[Address(RVA = "0x7437", Offset = "0x7437", VA = "0x7437")]
		private void RestartAnimation([Optional] SettingsScope.SettingsEventArgs settingsEventArgs)
		{
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E4")]
		[Address(RVA = "0x7438", Offset = "0x7438", VA = "0x7438", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E5")]
		[Address(RVA = "0x7439", Offset = "0x7439", VA = "0x7439", Slot = "11")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E6")]
		[Address(RVA = "0x743A", Offset = "0x743A", VA = "0x743A")]
		public void Show()
		{
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E7")]
		[Address(RVA = "0x743B", Offset = "0x743B", VA = "0x743B")]
		public void Hide()
		{
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E8")]
		[Address(RVA = "0x743C", Offset = "0x743C", VA = "0x743C")]
		public void SetBackTimer(BackTime backTime)
		{
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E9")]
		[Address(RVA = "0x743D", Offset = "0x743D", VA = "0x743D", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EA")]
		[Address(RVA = "0x743E", Offset = "0x743E", VA = "0x743E", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EB")]
		[Address(RVA = "0x743F", Offset = "0x743F", VA = "0x743F")]
		public void Init(UserIsle isle)
		{
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EC")]
		[Address(RVA = "0x7440", Offset = "0x7440", VA = "0x7440")]
		private void FadeIn()
		{
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022ED")]
		[Address(RVA = "0x7441", Offset = "0x7441", VA = "0x7441")]
		public void Deinit()
		{
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EE")]
		[Address(RVA = "0x7442", Offset = "0x7442", VA = "0x7442", Slot = "12")]
		public void SetAlpha(float value)
		{
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EF")]
		[Address(RVA = "0x7443", Offset = "0x7443", VA = "0x7443")]
		private void OnDestroy()
		{
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60022F0")]
		[Address(RVA = "0x7444", Offset = "0x7444", VA = "0x7444")]
		private string FormatBackTime(float value)
		{
			return null;
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F1")]
		[Address(RVA = "0x7445", Offset = "0x7445", VA = "0x7445")]
		public PortalsEntryPointView()
		{
		}

		// Token: 0x04001305 RID: 4869
		[Token(Token = "0x4001305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameSpineAnimation _portalAnimation;

		// Token: 0x04001306 RID: 4870
		[Token(Token = "0x4001306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BacktimeView _endTimer;

		// Token: 0x04001307 RID: 4871
		[Token(Token = "0x4001307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private SpriteRenderer _cloud;

		// Token: 0x04001309 RID: 4873
		[Token(Token = "0x4001309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Tween _fadeTween;

		// Token: 0x0400130A RID: 4874
		[Token(Token = "0x400130A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IslePortalsEntryPointMediator _mediator;
	}
}
