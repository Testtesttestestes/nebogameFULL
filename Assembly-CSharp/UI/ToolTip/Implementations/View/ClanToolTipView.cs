using System;
using Gameplay.UserInfo.View;
using Gameplay.UserInterface.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x02000143 RID: 323
	[Token(Token = "0x2000143")]
	public class ClanToolTipView : BaseToolTip<ClanData>
	{
		// Token: 0x060009A5 RID: 2469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x5D0D", Offset = "0x5D0D", VA = "0x5D0D", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x5D0E", Offset = "0x5D0E", VA = "0x5D0E")]
		public ClanToolTipView()
		{
		}

		// Token: 0x040003A3 RID: 931
		[Token(Token = "0x40003A3")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/ClanToolTipView";

		// Token: 0x040003A4 RID: 932
		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040003A5 RID: 933
		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ClanLeagueBannerView _clanLeagueBannerView;

		// Token: 0x040003A6 RID: 934
		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CultView _cult;

		// Token: 0x040003A7 RID: 935
		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _ratingPointsTableTitle;

		// Token: 0x040003A8 RID: 936
		[Token(Token = "0x40003A8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TitlePlaceIconValueBackground _ratingPontRowPrefab;

		// Token: 0x040003A9 RID: 937
		[Token(Token = "0x40003A9")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Transform _ratingPointsContainer;

		// Token: 0x040003AA RID: 938
		[Token(Token = "0x40003AA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TitleIconValueBackground _totalMembersNum;

		// Token: 0x040003AB RID: 939
		[Token(Token = "0x40003AB")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TitleIconValueBackground _generalMembersNum;

		// Token: 0x040003AC RID: 940
		[Token(Token = "0x40003AC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TitleIconValueBackground _legendMembersNum;

		// Token: 0x040003AD RID: 941
		[Token(Token = "0x40003AD")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _restrictionsCount;

		// Token: 0x040003AE RID: 942
		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject[] _restrictionsObjects;
	}
}
