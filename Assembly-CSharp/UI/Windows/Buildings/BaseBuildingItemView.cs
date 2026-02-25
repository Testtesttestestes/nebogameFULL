using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Core.Data;
using Gameplay.Discounts.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UI.Elements.Counters;
using UI.Elements.ProgressBars;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Windows.Buildings
{
	// Token: 0x020002A1 RID: 673
	[Token(Token = "0x20002A1")]
	public abstract class BaseBuildingItemView : MonoBehaviour, IDiscountTarget
	{
		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700023A")]
		public DiscountTargets[] DiscountTargets
		{
			[Token(Token = "0x6000FCF")]
			[Address(RVA = "0x61E3", Offset = "0x61E3", VA = "0x61E3", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x61E4", Offset = "0x61E4", VA = "0x61E4", Slot = "5")]
		public void Setup(IEnumerable<IDiscountArgs> value)
		{
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x00004530 File Offset: 0x00002730
		// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023B")]
		public bool DiscountWidgetEnabled
		{
			[Token(Token = "0x6000FD1")]
			[Address(RVA = "0x61E5", Offset = "0x61E5", VA = "0x61E5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FD2")]
			[Address(RVA = "0x61E6", Offset = "0x61E6", VA = "0x61E6")]
			set
			{
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x00004548 File Offset: 0x00002748
		// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023C")]
		public uint BuildingTypeId
		{
			[Token(Token = "0x6000FD3")]
			[Address(RVA = "0x61E7", Offset = "0x61E7", VA = "0x61E7")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000FD4")]
			[Address(RVA = "0x61E8", Offset = "0x61E8", VA = "0x61E8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700023D")]
		public Price Price
		{
			[Token(Token = "0x6000FD5")]
			[Address(RVA = "0x61E9", Offset = "0x61E9", VA = "0x61E9")]
			get
			{
				return null;
			}
		}

		// Token: 0x140000FE RID: 254
		// (add) Token: 0x06000FD6 RID: 4054 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000FD7 RID: 4055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000FE")]
		public event Action<BaseBuildingData> ActionButtonClickedEvent
		{
			[Token(Token = "0x6000FD6")]
			[Address(RVA = "0x61EA", Offset = "0x61EA", VA = "0x61EA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000FD7")]
			[Address(RVA = "0x61EB", Offset = "0x61EB", VA = "0x61EB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000FF RID: 255
		// (add) Token: 0x06000FD8 RID: 4056 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000FD9 RID: 4057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000FF")]
		public event Action<BaseBuildingData> ClickedEvent
		{
			[Token(Token = "0x6000FD8")]
			[Address(RVA = "0x61EC", Offset = "0x61EC", VA = "0x61EC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000FD9")]
			[Address(RVA = "0x61ED", Offset = "0x61ED", VA = "0x61ED")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDA")]
		[Address(RVA = "0x61EE", Offset = "0x61EE", VA = "0x61EE")]
		private void Awake()
		{
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDB")]
		[Address(RVA = "0x61EF", Offset = "0x61EF", VA = "0x61EF")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDC")]
		[Address(RVA = "0x61F0", Offset = "0x61F0", VA = "0x61F0")]
		public void SetData(BaseBuildingData userBuildingData, UserData ownerUserData, UserData ownUserData)
		{
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0x61F1", Offset = "0x61F1", VA = "0x61F1", Slot = "6")]
		public virtual void UpdateView(BaseBuildingData userBuildingData)
		{
		}

		// Token: 0x06000FDE RID: 4062
		[Token(Token = "0x6000FDE")]
		protected abstract void HandleActionButton(UserData ownerUserData, UserData loggedUser);

		// Token: 0x06000FDF RID: 4063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDF")]
		[Address(RVA = "0x61F2", Offset = "0x61F2", VA = "0x61F2")]
		protected BaseBuildingItemView()
		{
		}

		// Token: 0x04000808 RID: 2056
		[Token(Token = "0x4000808")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private DiscountTargets[] _discountTargets;

		// Token: 0x04000809 RID: 2057
		[Token(Token = "0x4000809")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected ProgressBarWithTimer _upgradeProgress;

		// Token: 0x0400080A RID: 2058
		[Token(Token = "0x400080A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Button _openBuildingButton;

		// Token: 0x0400080B RID: 2059
		[Token(Token = "0x400080B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected Button _actionButton;

		// Token: 0x0400080C RID: 2060
		[Token(Token = "0x400080C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected TextMeshProUGUI _title;

		// Token: 0x0400080D RID: 2061
		[Token(Token = "0x400080D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected LevelCounter _levelCounter;

		// Token: 0x0400080E RID: 2062
		[Token(Token = "0x400080E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected GameRawImageLoader _miniature;

		// Token: 0x0400080F RID: 2063
		[Token(Token = "0x400080F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected Price _price;

		// Token: 0x04000810 RID: 2064
		[Token(Token = "0x4000810")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform _discountWidget;

		// Token: 0x04000811 RID: 2065
		[Token(Token = "0x4000811")]
		[FieldOffset(Offset = "0x34")]
		private bool _discountWidgetEnabled;

		// Token: 0x04000813 RID: 2067
		[Token(Token = "0x4000813")]
		[FieldOffset(Offset = "0x3C")]
		protected BaseBuildingData _buildingData;
	}
}
