using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Core.Materials;
using DG.Tweening;
using Gameplay.Isles.User.Controller;
using Gameplay.Tutorial.Guide.Model.Data;
using Gameplay.Tutorial.Guide.View;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;
using Utils;
using Utils.Trackers;

namespace Gameplay.Isles.User.View.Monster
{
	// Token: 0x02000D22 RID: 3362
	[Token(Token = "0x2000D22")]
	public class IsleMonsterView : BaseIsleMonsterView, IToolTipDataProvider, IPointerClickHandler, IEventSystemHandler, IBoundsProvider, IGuideTargetResolveEventProvider, IAlpha
	{
		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x06005228 RID: 21032 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010B6")]
		public MonsterOnIsleAvatarAnimation AvatarAnimation
		{
			[Token(Token = "0x6005228")]
			[Address(RVA = "0x9FFF", Offset = "0x9FFF", VA = "0x9FFF")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x06005229 RID: 21033 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010B7")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x6005229")]
			[Address(RVA = "0xA000", Offset = "0xA000", VA = "0xA000")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x0600522A RID: 21034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010B8")]
		public AsyncLoadableContentTracker Tracker
		{
			[Token(Token = "0x600522A")]
			[Address(RVA = "0xA001", Offset = "0xA001", VA = "0xA001")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x0600522B RID: 21035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010B9")]
		public ToolTip ToolTip
		{
			[Token(Token = "0x600522B")]
			[Address(RVA = "0xA002", Offset = "0xA002", VA = "0xA002")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x0600522C RID: 21036 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
		[Token(Token = "0x170010BA")]
		public Bounds Bounds
		{
			[Token(Token = "0x600522C")]
			[Address(RVA = "0xA003", Offset = "0xA003", VA = "0xA003", Slot = "14")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x140001F5 RID: 501
		// (add) Token: 0x0600522D RID: 21037 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600522E RID: 21038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001F5")]
		public new event Action ClickEvent
		{
			[Token(Token = "0x600522D")]
			[Address(RVA = "0xA004", Offset = "0xA004", VA = "0xA004")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600522E")]
			[Address(RVA = "0xA005", Offset = "0xA005", VA = "0xA005")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001F6 RID: 502
		// (add) Token: 0x0600522F RID: 21039 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005230 RID: 21040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001F6")]
		public event Action<IGuideTargetResolveEventProvider> ResolveEvent
		{
			[Token(Token = "0x600522F")]
			[Address(RVA = "0xA006", Offset = "0xA006", VA = "0xA006", Slot = "15")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005230")]
			[Address(RVA = "0xA007", Offset = "0xA007", VA = "0xA007", Slot = "16")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170010BB RID: 4283
		// (set) Token: 0x06005231 RID: 21041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010BB")]
		public BackTime Backtime
		{
			[Token(Token = "0x6005231")]
			[Address(RVA = "0xA008", Offset = "0xA008", VA = "0xA008")]
			set
			{
			}
		}

		// Token: 0x06005232 RID: 21042 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005232")]
		[Address(RVA = "0xA009", Offset = "0xA009", VA = "0xA009")]
		private IEnumerator TimerRoutine(float backtime)
		{
			return null;
		}

		// Token: 0x06005233 RID: 21043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005233")]
		[Address(RVA = "0xA00A", Offset = "0xA00A", VA = "0xA00A")]
		public void Show()
		{
		}

		// Token: 0x06005234 RID: 21044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005234")]
		[Address(RVA = "0xA00B", Offset = "0xA00B", VA = "0xA00B")]
		public void Hide()
		{
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005235")]
		[Address(RVA = "0xA00C", Offset = "0xA00C", VA = "0xA00C")]
		public void SetState(IsleMonsterView.State state)
		{
		}

		// Token: 0x06005236 RID: 21046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005236")]
		[Address(RVA = "0xA00D", Offset = "0xA00D", VA = "0xA00D", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		}

		// Token: 0x06005237 RID: 21047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005237")]
		[Address(RVA = "0xA00E", Offset = "0xA00E", VA = "0xA00E")]
		public void Init(UserIsle isle)
		{
		}

		// Token: 0x06005238 RID: 21048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005238")]
		[Address(RVA = "0xA00F", Offset = "0xA00F", VA = "0xA00F")]
		private void FadeIn()
		{
		}

		// Token: 0x06005239 RID: 21049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005239")]
		[Address(RVA = "0xA010", Offset = "0xA010", VA = "0xA010")]
		public void Deinit()
		{
		}

		// Token: 0x0600523A RID: 21050 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600523A")]
		[Address(RVA = "0xA011", Offset = "0xA011", VA = "0xA011", Slot = "12")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600523B")]
		[Address(RVA = "0xA012", Offset = "0xA012", VA = "0xA012", Slot = "13")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x0600523C RID: 21052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600523C")]
		[Address(RVA = "0xA013", Offset = "0xA013", VA = "0xA013", Slot = "18")]
		public void SetAlpha(float value)
		{
		}

		// Token: 0x0600523D RID: 21053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600523D")]
		[Address(RVA = "0xA014", Offset = "0xA014", VA = "0xA014")]
		public IsleMonsterView()
		{
		}

		// Token: 0x0600523E RID: 21054 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600523E")]
		[Address(RVA = "0xA015", Offset = "0xA015", VA = "0xA015", Slot = "17")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04002CAE RID: 11438
		[Token(Token = "0x4002CAE")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private SpriteRenderer _cloudPlatform;

		// Token: 0x04002CAF RID: 11439
		[Token(Token = "0x4002CAF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshPro _backtimeView;

		// Token: 0x04002CB0 RID: 11440
		[Token(Token = "0x4002CB0")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ToolTip _toolTip;

		// Token: 0x04002CB1 RID: 11441
		[Token(Token = "0x4002CB1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AsyncLoadableContentTracker _tracker;

		// Token: 0x04002CB2 RID: 11442
		[Token(Token = "0x4002CB2")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private MonsterOnIsleAvatarAnimation _avatarAnimation;

		// Token: 0x04002CB3 RID: 11443
		[Token(Token = "0x4002CB3")]
		[FieldOffset(Offset = "0x40")]
		private IGuideTarget _guideTarget;

		// Token: 0x04002CB4 RID: 11444
		[Token(Token = "0x4002CB4")]
		[FieldOffset(Offset = "0x44")]
		private IsleMonsterViewMediator _mediator;

		// Token: 0x04002CB5 RID: 11445
		[Token(Token = "0x4002CB5")]
		[FieldOffset(Offset = "0x48")]
		private Tween _fadeTween;

		// Token: 0x04002CB6 RID: 11446
		[Token(Token = "0x4002CB6")]
		[FieldOffset(Offset = "0x4C")]
		private Coroutine _timerRoutine;

		// Token: 0x02000D23 RID: 3363
		[Token(Token = "0x2000D23")]
		public enum State
		{
			// Token: 0x04002CBA RID: 11450
			[Token(Token = "0x4002CBA")]
			Idle = 1,
			// Token: 0x04002CBB RID: 11451
			[Token(Token = "0x4002CBB")]
			Splash
		}
	}
}
