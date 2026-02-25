using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Discounts.Model;
using Gameplay.Discounts.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UI.Requirements;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Windows.Buildings
{
	// Token: 0x020002AA RID: 682
	[Token(Token = "0x20002AA")]
	public class BuildingInfoBuildView : MonoBehaviourWithStates<BuildingInfoBuildView.BuildingInfoBuildViewStates>, IDiscountTarget
	{
		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000246")]
		public Button BuildButton
		{
			[Token(Token = "0x6001006")]
			[Address(RVA = "0x6210", Offset = "0x6210", VA = "0x6210")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001007")]
		[Address(RVA = "0x6211", Offset = "0x6211", VA = "0x6211")]
		public void SetData(BaseBuildingData buildingData, UserData ownerUserData, UserData ownUserData)
		{
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001009 RID: 4105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000247")]
		public DiscountTargets[] DiscountTargets
		{
			[Token(Token = "0x6001008")]
			[Address(RVA = "0x6212", Offset = "0x6212", VA = "0x6212", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001009")]
			[Address(RVA = "0x6213", Offset = "0x6213", VA = "0x6213")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100A")]
		[Address(RVA = "0x6214", Offset = "0x6214", VA = "0x6214", Slot = "6")]
		public void Setup(IEnumerable<IDiscountArgs> value)
		{
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100B")]
		[Address(RVA = "0x6215", Offset = "0x6215", VA = "0x6215")]
		public BuildingInfoBuildView()
		{
		}

		// Token: 0x0400082D RID: 2093
		[Token(Token = "0x400082D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _titleLabel;

		// Token: 0x0400082E RID: 2094
		[Token(Token = "0x400082E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _upgradeTextLabel;

		// Token: 0x0400082F RID: 2095
		[Token(Token = "0x400082F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _buildButton;

		// Token: 0x04000830 RID: 2096
		[Token(Token = "0x4000830")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _durationLabel;

		// Token: 0x04000831 RID: 2097
		[Token(Token = "0x4000831")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x04000832 RID: 2098
		[Token(Token = "0x4000832")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DiscountInfoTitledListElement _discountInfo;

		// Token: 0x04000833 RID: 2099
		[Token(Token = "0x4000833")]
		[FieldOffset(Offset = "0x34")]
		private BaseBuildingData _buildingData;

		// Token: 0x020002AB RID: 683
		[Token(Token = "0x20002AB")]
		public enum BuildingInfoBuildViewStates
		{
			// Token: 0x04000836 RID: 2102
			[Token(Token = "0x4000836")]
			Default,
			// Token: 0x04000837 RID: 2103
			[Token(Token = "0x4000837")]
			Sale
		}
	}
}
