using System;
using Core.Data;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Dic;
using UI;
using UI.Requirements;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.VacanciesTab
{
	// Token: 0x02000A04 RID: 2564
	[Token(Token = "0x2000A04")]
	public class ClanVacancyInfoBox : MonoBehaviourWithStates<ClanVacancyInfoBox.State>
	{
		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06003CF6 RID: 15606 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C06")]
		public Button InfoButton
		{
			[Token(Token = "0x6003CF6")]
			[Address(RVA = "0x8BB6", Offset = "0x8BB6", VA = "0x8BB6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06003CF7 RID: 15607 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C07")]
		public Button RequestButton
		{
			[Token(Token = "0x6003CF7")]
			[Address(RVA = "0x8BB7", Offset = "0x8BB7", VA = "0x8BB7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06003CF8 RID: 15608 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C08")]
		public Button WithdrawButton
		{
			[Token(Token = "0x6003CF8")]
			[Address(RVA = "0x8BB8", Offset = "0x8BB8", VA = "0x8BB8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF9")]
		[Address(RVA = "0x8BB9", Offset = "0x8BB9", VA = "0x8BB9")]
		public void UpdateData(ClanInRatingListElement.ClanInRatingListElementArgs args, Dictionaries dict, UserData user, string honorAssetId)
		{
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CFA")]
		[Address(RVA = "0x8BBA", Offset = "0x8BBA", VA = "0x8BBA")]
		public ClanVacancyInfoBox()
		{
		}

		// Token: 0x040021D5 RID: 8661
		[Token(Token = "0x40021D5")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ClanTitle _title;

		// Token: 0x040021D6 RID: 8662
		[Token(Token = "0x40021D6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClanLeagueBaseInfoView _leagueBaseInfo;

		// Token: 0x040021D7 RID: 8663
		[Token(Token = "0x40021D7")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TitleIconValueBackground _membersCount;

		// Token: 0x040021D8 RID: 8664
		[Token(Token = "0x40021D8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RequirementsView _requirements;

		// Token: 0x040021D9 RID: 8665
		[Token(Token = "0x40021D9")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _infoButton;

		// Token: 0x040021DA RID: 8666
		[Token(Token = "0x40021DA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _requestButton;

		// Token: 0x040021DB RID: 8667
		[Token(Token = "0x40021DB")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _withdrawButton;

		// Token: 0x02000A05 RID: 2565
		[Token(Token = "0x2000A05")]
		public enum State
		{
			// Token: 0x040021DD RID: 8669
			[Token(Token = "0x40021DD")]
			UNKNOWN_STATE,
			// Token: 0x040021DE RID: 8670
			[Token(Token = "0x40021DE")]
			IDLE,
			// Token: 0x040021DF RID: 8671
			[Token(Token = "0x40021DF")]
			REQUESTED_CLAN
		}
	}
}
