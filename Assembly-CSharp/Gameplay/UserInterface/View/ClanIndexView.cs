using System;
using Gameplay.Clans.Office.View;
using Gameplay.Isles.Clan;
using Il2CppDummyDll;
using UI;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.UserInterface.View
{
	// Token: 0x020003BA RID: 954
	[Token(Token = "0x20003BA")]
	public class ClanIndexView : AbstractDataRenderer<ClanIsle>, IToolTipDataProvider
	{
		// Token: 0x06001663 RID: 5731 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001663")]
		[Address(RVA = "0x6824", Offset = "0x6824", VA = "0x6824", Slot = "20")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001664")]
		[Address(RVA = "0x6825", Offset = "0x6825", VA = "0x6825", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001665")]
		[Address(RVA = "0x6826", Offset = "0x6826", VA = "0x6826")]
		public ClanIndexView()
		{
		}

		// Token: 0x04000BBD RID: 3005
		[Token(Token = "0x4000BBD")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ClanNickCultIndexView _nickCultIndexView;

		// Token: 0x04000BBE RID: 3006
		[Token(Token = "0x4000BBE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ClanLeagueBannerView _clanLeagueBannerView;

		// Token: 0x04000BBF RID: 3007
		[Token(Token = "0x4000BBF")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ToolTip _toolTip;

		// Token: 0x04000BC0 RID: 3008
		[Token(Token = "0x4000BC0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ClanCursesIndicator _restrictionsIndicator;
	}
}
