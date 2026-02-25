using System;
using System.Collections;
using System.Collections.Generic;
using Core.Animations;
using Cysharp.Threading.Tasks;
using Gameplay.UserInterface.Control;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Windows;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Gameplay.UserInterface.View.UserGotNewLevel
{
	// Token: 0x020003C9 RID: 969
	[Token(Token = "0x20003C9")]
	public class UserGotNewLevelWindow : ClosableBaseWindow<UserGotNewLevelWindow.UserGotNewLevelWindowArgs>
	{
		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003D8")]
		public override string WindowId
		{
			[Token(Token = "0x60016BA")]
			[Address(RVA = "0x687B", Offset = "0x687B", VA = "0x687B", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x000054C0 File Offset: 0x000036C0
		[Token(Token = "0x170003D9")]
		public override bool IsFullscreenWindow
		{
			[Token(Token = "0x60016BB")]
			[Address(RVA = "0x687C", Offset = "0x687C", VA = "0x687C", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003DA")]
		public TMP_Text LevelValueField
		{
			[Token(Token = "0x60016BC")]
			[Address(RVA = "0x687D", Offset = "0x687D", VA = "0x687D")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003DB")]
		public Button GetRewardButton
		{
			[Token(Token = "0x60016BD")]
			[Address(RVA = "0x687E", Offset = "0x687E", VA = "0x687E")]
			get
			{
				return null;
			}
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016BE")]
		[Address(RVA = "0x687F", Offset = "0x687F", VA = "0x687F", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016BF")]
		[Address(RVA = "0x6880", Offset = "0x6880", VA = "0x6880", Slot = "22")]
		protected override void OnShow(UserGotNewLevelWindow.UserGotNewLevelWindowArgs args)
		{
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60016C0")]
		[Address(RVA = "0x6881", Offset = "0x6881", VA = "0x6881")]
		private IEnumerator StarAnimationRoutine()
		{
			return null;
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60016C1")]
		[Address(RVA = "0x6882", Offset = "0x6882", VA = "0x6882")]
		private IEnumerator ConfettiRoutine()
		{
			return null;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60016C2")]
		[Address(RVA = "0x6883", Offset = "0x6883", VA = "0x6883")]
		private IEnumerator ShowContentRoutine()
		{
			return null;
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60016C3")]
		[Address(RVA = "0x6884", Offset = "0x6884", VA = "0x6884")]
		private IEnumerator ShowGetContentRoutine(UniTaskCompletionSource cts)
		{
			return null;
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C4")]
		[Address(RVA = "0x6885", Offset = "0x6885", VA = "0x6885")]
		public void SetResources(UserGotNewLevelWindow.ResourceRewardData[] values)
		{
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C5")]
		[Address(RVA = "0x6886", Offset = "0x6886", VA = "0x6886")]
		public void ShowContent()
		{
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x000054D8 File Offset: 0x000036D8
		[Token(Token = "0x60016C6")]
		[Address(RVA = "0x1F26", Offset = "0x1F26", VA = "0x1F26")]
		public UniTask ShowGetContent()
		{
			return default(UniTask);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C7")]
		[Address(RVA = "0x6887", Offset = "0x6887", VA = "0x6887")]
		public UserGotNewLevelWindow()
		{
		}

		// Token: 0x04000BFC RID: 3068
		[Token(Token = "0x4000BFC")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/UserInfo/UserGotNewLevelWindow";

		// Token: 0x04000BFD RID: 3069
		[Token(Token = "0x4000BFD")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TMP_Text _levelValueField;

		// Token: 0x04000BFE RID: 3070
		[Token(Token = "0x4000BFE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _getRewardButton;

		// Token: 0x04000BFF RID: 3071
		[Token(Token = "0x4000BFF")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private SimpleIconValue _rewardPrefab;

		// Token: 0x04000C00 RID: 3072
		[Token(Token = "0x4000C00")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _rewardOwner;

		// Token: 0x04000C01 RID: 3073
		[Token(Token = "0x4000C01")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private GameSpineUiAnimation _scrollAnimation;

		// Token: 0x04000C02 RID: 3074
		[Token(Token = "0x4000C02")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameSpineUiAnimation _starAnimation;

		// Token: 0x04000C03 RID: 3075
		[Token(Token = "0x4000C03")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private CanvasGroup _scrollContent;

		// Token: 0x04000C04 RID: 3076
		[Token(Token = "0x4000C04")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ParticleSystem[] _confetti;

		// Token: 0x04000C05 RID: 3077
		[Token(Token = "0x4000C05")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _confettiItemStartDelay;

		// Token: 0x04000C06 RID: 3078
		[Token(Token = "0x4000C06")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _getRewardItemDelay;

		// Token: 0x04000C07 RID: 3079
		[Token(Token = "0x4000C07")]
		[FieldOffset(Offset = "0x64")]
		[FormerlySerializedAs("_scrollAfterScrollClosingDelay")]
		[SerializeField]
		private float _scrollAfterClosingDelay;

		// Token: 0x04000C08 RID: 3080
		[Token(Token = "0x4000C08")]
		public const string ScrollAnimationStateClosed = "01_closed";

		// Token: 0x04000C09 RID: 3081
		[Token(Token = "0x4000C09")]
		public const string ScrollAnimationStateOpening = "02_opening";

		// Token: 0x04000C0A RID: 3082
		[Token(Token = "0x4000C0A")]
		public const string ScrollAnimationStateOpened = "03_opened";

		// Token: 0x04000C0B RID: 3083
		[Token(Token = "0x4000C0B")]
		public const string ScrollAnimationStateClosing = "04_closing";

		// Token: 0x04000C0C RID: 3084
		[Token(Token = "0x4000C0C")]
		[FieldOffset(Offset = "0x68")]
		private List<SimpleIconValue> _rewards;

		// Token: 0x04000C0D RID: 3085
		[Token(Token = "0x4000C0D")]
		[FieldOffset(Offset = "0x6C")]
		private UserGotNewLevelWindowViewMediator _mediator;

		// Token: 0x020003CA RID: 970
		[Token(Token = "0x20003CA")]
		public class UserGotNewLevelWindowArgs : BaseWindowArgs
		{
			// Token: 0x060016C8 RID: 5832 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60016C8")]
			[Address(RVA = "0x6888", Offset = "0x6888", VA = "0x6888")]
			public UserGotNewLevelWindowArgs(UserInterfaceController controller)
			{
			}

			// Token: 0x04000C0E RID: 3086
			[Token(Token = "0x4000C0E")]
			[FieldOffset(Offset = "0x18")]
			public readonly UserInterfaceController UserInterfaceController;
		}

		// Token: 0x020003CB RID: 971
		[Token(Token = "0x20003CB")]
		public class ResourceRewardData
		{
			// Token: 0x060016C9 RID: 5833 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60016C9")]
			[Address(RVA = "0x1F24", Offset = "0x1F24", VA = "0x1F24")]
			public ResourceRewardData(string assetId, double value)
			{
			}

			// Token: 0x04000C0F RID: 3087
			[Token(Token = "0x4000C0F")]
			[FieldOffset(Offset = "0x8")]
			public readonly string AssetId;

			// Token: 0x04000C10 RID: 3088
			[Token(Token = "0x4000C10")]
			[FieldOffset(Offset = "0x10")]
			public readonly double Value;
		}
	}
}
