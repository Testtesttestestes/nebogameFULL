using System;
using Core.Data;
using Gameplay.Clans.Office.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.ClanOverviewTab
{
	// Token: 0x02000A34 RID: 2612
	[Token(Token = "0x2000A34")]
	public class ClanOverview : MonoBehaviourWithStates<ClanInfoWindow.State>
	{
		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06003DDA RID: 15834 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C58")]
		public ClanConfig ClanConfig
		{
			[Token(Token = "0x6003DDA")]
			[Address(RVA = "0x8C99", Offset = "0x8C99", VA = "0x8C99")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06003DDB RID: 15835 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C59")]
		public Button ZigguratButton
		{
			[Token(Token = "0x6003DDB")]
			[Address(RVA = "0x8C9A", Offset = "0x8C9A", VA = "0x8C9A")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DDC")]
		[Address(RVA = "0x8C9B", Offset = "0x8C9B", VA = "0x8C9B")]
		public void Init(ClanOfficeData clanIsleData, UserData user, Dictionaries dict)
		{
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DDD")]
		[Address(RVA = "0x8C9C", Offset = "0x8C9C", VA = "0x8C9C")]
		public ClanOverview()
		{
		}

		// Token: 0x040022AD RID: 8877
		[Token(Token = "0x40022AD")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ClanConfig _config;

		// Token: 0x040022AE RID: 8878
		[Token(Token = "0x40022AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClanInfoBox _infoBox;

		// Token: 0x040022AF RID: 8879
		[Token(Token = "0x40022AF")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _zigguratButton;
	}
}
