using System;
using Core.Data;
using Gameplay.World.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Buttons;
using UI.Elements.ProgressBars;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Windows.Buildings
{
	// Token: 0x020002A9 RID: 681
	[Token(Token = "0x20002A9")]
	public class BuildingInfoAccelerateView : MonoBehaviour
	{
		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000244")]
		public Button CancelButton
		{
			[Token(Token = "0x6001002")]
			[Address(RVA = "0x620C", Offset = "0x620C", VA = "0x620C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000245")]
		public Button AccelerateButton
		{
			[Token(Token = "0x6001003")]
			[Address(RVA = "0x620D", Offset = "0x620D", VA = "0x620D")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001004")]
		[Address(RVA = "0x620E", Offset = "0x620E", VA = "0x620E")]
		public void SetData(BaseBuildingData buildingData, UserData ownerUserData, UserData loggedUser)
		{
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001005")]
		[Address(RVA = "0x620F", Offset = "0x620F", VA = "0x620F")]
		public BuildingInfoAccelerateView()
		{
		}

		// Token: 0x04000827 RID: 2087
		[Token(Token = "0x4000827")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _titleLabel;

		// Token: 0x04000828 RID: 2088
		[Token(Token = "0x4000828")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _descLabel;

		// Token: 0x04000829 RID: 2089
		[Token(Token = "0x4000829")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ButtonWithCost _accelerateButton;

		// Token: 0x0400082A RID: 2090
		[Token(Token = "0x400082A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _cancelButton;

		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x400082B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ProgressBarWithTimer _upgradeProgress;

		// Token: 0x0400082C RID: 2092
		[Token(Token = "0x400082C")]
		[FieldOffset(Offset = "0x24")]
		private BaseBuildingData _buildingData;
	}
}
