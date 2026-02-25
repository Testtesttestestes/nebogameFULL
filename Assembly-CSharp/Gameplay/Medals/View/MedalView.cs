using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Medals.View
{
	// Token: 0x020005F8 RID: 1528
	[Token(Token = "0x20005F8")]
	public class MedalView : AbstractDataRenderer<MedalDicWrapper>, IPointerClickHandler, IEventSystemHandler, IToolTipDataProvider
	{
		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06002511 RID: 9489 RVA: 0x000070E0 File Offset: 0x000052E0
		// (set) Token: 0x06002512 RID: 9490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F0")]
		public InteractiveBehavior Mode
		{
			[Token(Token = "0x6002511")]
			[Address(RVA = "0x765B", Offset = "0x765B", VA = "0x765B")]
			[CompilerGenerated]
			get
			{
				return InteractiveBehavior.Default;
			}
			[Token(Token = "0x6002512")]
			[Address(RVA = "0x765C", Offset = "0x765C", VA = "0x765C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06002513 RID: 9491 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006F1")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x6002513")]
			[Address(RVA = "0x765D", Offset = "0x765D", VA = "0x765D")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002515 RID: 9493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F2")]
		public MedalData MedalData
		{
			[Token(Token = "0x6002514")]
			[Address(RVA = "0x765E", Offset = "0x765E", VA = "0x765E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002515")]
			[Address(RVA = "0x765F", Offset = "0x765F", VA = "0x765F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006F3")]
		private MedalDic MedalDic
		{
			[Token(Token = "0x6002516")]
			[Address(RVA = "0x7660", Offset = "0x7660", VA = "0x7660")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400014D RID: 333
		// (add) Token: 0x06002517 RID: 9495 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002518 RID: 9496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400014D")]
		public event Action<MedalView> ClickEvent
		{
			[Token(Token = "0x6002517")]
			[Address(RVA = "0x7661", Offset = "0x7661", VA = "0x7661")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002518")]
			[Address(RVA = "0x7662", Offset = "0x7662", VA = "0x7662")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06002519 RID: 9497 RVA: 0x000070F8 File Offset: 0x000052F8
		// (set) Token: 0x0600251A RID: 9498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F4")]
		public bool Achieved
		{
			[Token(Token = "0x6002519")]
			[Address(RVA = "0x7663", Offset = "0x7663", VA = "0x7663")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600251A")]
			[Address(RVA = "0x7664", Offset = "0x7664", VA = "0x7664")]
			set
			{
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (set) Token: 0x0600251B RID: 9499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F5")]
		public bool SaleEnabled
		{
			[Token(Token = "0x600251B")]
			[Address(RVA = "0x7665", Offset = "0x7665", VA = "0x7665")]
			set
			{
			}
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600251C")]
		[Address(RVA = "0x1C12", Offset = "0x1C12", VA = "0x1C12")]
		private void ValidateRankAndAchievement()
		{
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600251D")]
		[Address(RVA = "0x7666", Offset = "0x7666", VA = "0x7666")]
		private void HandleAchievedChanged(bool fromValue, bool toValue)
		{
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600251E")]
		[Address(RVA = "0x7667", Offset = "0x7667", VA = "0x7667", Slot = "20")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600251F")]
		[Address(RVA = "0x7668", Offset = "0x7668", VA = "0x7668", Slot = "21")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002520")]
		[Address(RVA = "0x7669", Offset = "0x7669", VA = "0x7669", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002521")]
		[Address(RVA = "0x766A", Offset = "0x766A", VA = "0x766A")]
		public MedalView()
		{
		}

		// Token: 0x04001443 RID: 5187
		[Token(Token = "0x4001443")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected GameRawImage _icon;

		// Token: 0x04001444 RID: 5188
		[Token(Token = "0x4001444")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected GameRawImage _bg;

		// Token: 0x04001445 RID: 5189
		[Token(Token = "0x4001445")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected RawImageWithGrayscale _rankBg;

		// Token: 0x04001446 RID: 5190
		[Token(Token = "0x4001446")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected TextMeshProUGUI _rankLabel;

		// Token: 0x04001447 RID: 5191
		[Token(Token = "0x4001447")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected Texture _rankBgTexture;

		// Token: 0x04001448 RID: 5192
		[Token(Token = "0x4001448")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Texture _noRankBgTexture;

		// Token: 0x04001449 RID: 5193
		[Token(Token = "0x4001449")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected GameObject _saleIcon;

		// Token: 0x0400144B RID: 5195
		[Token(Token = "0x400144B")]
		[FieldOffset(Offset = "0x44")]
		private IGuideTarget _guideTarget;

		// Token: 0x0400144E RID: 5198
		[Token(Token = "0x400144E")]
		[FieldOffset(Offset = "0x50")]
		private bool _achieved;
	}
}
