using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Gameplay.Discounts.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UI.Elements.Buttons;
using UI.Elements.Counters;
using UI.Elements.ProgressBars;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Windows.Buildings
{
	// Token: 0x020002A2 RID: 674
	[Token(Token = "0x20002A2")]
	public abstract class BaseBuildingItemView2 : MonoBehaviour, IDiscountTarget
	{
		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700023E")]
		public DiscountTargets[] DiscountTargets
		{
			[Token(Token = "0x6000FE2")]
			[Address(RVA = "0x61F5", Offset = "0x61F5", VA = "0x61F5", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE3")]
		[Address(RVA = "0x61F6", Offset = "0x61F6", VA = "0x61F6", Slot = "5")]
		public void Setup(IEnumerable<IDiscountArgs> value)
		{
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00004560 File Offset: 0x00002760
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023F")]
		public bool DiscountWidgetEnabled
		{
			[Token(Token = "0x6000FE4")]
			[Address(RVA = "0x61F7", Offset = "0x61F7", VA = "0x61F7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FE5")]
			[Address(RVA = "0x61F8", Offset = "0x61F8", VA = "0x61F8")]
			set
			{
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x00004578 File Offset: 0x00002778
		// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000240")]
		public uint BuildingTypeId
		{
			[Token(Token = "0x6000FE6")]
			[Address(RVA = "0x61F9", Offset = "0x61F9", VA = "0x61F9")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000FE7")]
			[Address(RVA = "0x61FA", Offset = "0x61FA", VA = "0x61FA")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x14000100 RID: 256
		// (add) Token: 0x06000FE8 RID: 4072 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000FE9 RID: 4073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000100")]
		public event Action<BaseBuildingData> ActionButtonClickedEvent
		{
			[Token(Token = "0x6000FE8")]
			[Address(RVA = "0x61FB", Offset = "0x61FB", VA = "0x61FB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000FE9")]
			[Address(RVA = "0x61FC", Offset = "0x61FC", VA = "0x61FC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000101 RID: 257
		// (add) Token: 0x06000FEA RID: 4074 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000FEB RID: 4075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000101")]
		public event Action<BaseBuildingData> ClickedEvent
		{
			[Token(Token = "0x6000FEA")]
			[Address(RVA = "0x61FD", Offset = "0x61FD", VA = "0x61FD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000FEB")]
			[Address(RVA = "0x61FE", Offset = "0x61FE", VA = "0x61FE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FEC")]
		[Address(RVA = "0x61FF", Offset = "0x61FF", VA = "0x61FF")]
		private void Start()
		{
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FED")]
		[Address(RVA = "0x6200", Offset = "0x6200", VA = "0x6200")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FEE")]
		[Address(RVA = "0x6201", Offset = "0x6201", VA = "0x6201")]
		private void OpenBuilding()
		{
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FEF")]
		[Address(RVA = "0x6202", Offset = "0x6202", VA = "0x6202")]
		private void ActionButtonClickedEventHandler()
		{
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0x6203", Offset = "0x6203", VA = "0x6203")]
		public void Init(BaseBuildingData userBuildingData, UserData ownerUserData, UserData loggedUser)
		{
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF1")]
		[Address(RVA = "0x6204", Offset = "0x6204", VA = "0x6204", Slot = "6")]
		public virtual void UpdateView(BaseBuildingData userBuildingData, UserData ownerUserData, UserData loggedUser)
		{
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF2")]
		[Address(RVA = "0x6205", Offset = "0x6205", VA = "0x6205", Slot = "7")]
		protected virtual void HandleMidLevelState(UserData ownerUserData, UserData loggedUser)
		{
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF3")]
		[Address(RVA = "0x6206", Offset = "0x6206", VA = "0x6206", Slot = "8")]
		protected virtual void HandleMaxLevelState(UserData ownerUserData, UserData loggedUser)
		{
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF4")]
		[Address(RVA = "0x6207", Offset = "0x6207", VA = "0x6207", Slot = "9")]
		protected virtual void HandleZeroLevelState(UserData ownerUserData, UserData loggedUser)
		{
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF5")]
		[Address(RVA = "0x6208", Offset = "0x6208", VA = "0x6208", Slot = "10")]
		protected virtual void HandleUpgradingState(UserData ownerUserData, UserData loggedUser)
		{
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF6")]
		[Address(RVA = "0x6209", Offset = "0x6209", VA = "0x6209")]
		protected BaseBuildingItemView2()
		{
		}

		// Token: 0x04000816 RID: 2070
		[Token(Token = "0x4000816")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private DiscountTargets[] _discountTargets;

		// Token: 0x04000817 RID: 2071
		[Token(Token = "0x4000817")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected ProgressBarWithTimer _upgradeProgress;

		// Token: 0x04000818 RID: 2072
		[Token(Token = "0x4000818")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Button _openBuildingButton;

		// Token: 0x04000819 RID: 2073
		[Token(Token = "0x4000819")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected TextMeshProUGUI _title;

		// Token: 0x0400081A RID: 2074
		[Token(Token = "0x400081A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected LevelCounter _levelCounter;

		// Token: 0x0400081B RID: 2075
		[Token(Token = "0x400081B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected GameImage _miniature;

		// Token: 0x0400081C RID: 2076
		[Token(Token = "0x400081C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected BuildButtonWithStates _actionButton;

		// Token: 0x0400081D RID: 2077
		[Token(Token = "0x400081D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected GameObject _discountWidget;

		// Token: 0x0400081E RID: 2078
		[Token(Token = "0x400081E")]
		[FieldOffset(Offset = "0x30")]
		private bool _discountWidgetEnabled;

		// Token: 0x0400081F RID: 2079
		[Token(Token = "0x400081F")]
		[FieldOffset(Offset = "0x34")]
		protected BaseBuildingData _buildingData;
	}
}
