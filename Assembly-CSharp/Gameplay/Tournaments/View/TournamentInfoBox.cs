using System;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements;
using UnityEngine;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004AB RID: 1195
	[Token(Token = "0x20004AB")]
	public class TournamentInfoBox : MonoBehaviourWithStates<TournamentInfoBox.State>
	{
		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004FF")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6001C3D")]
			[Address(RVA = "0x6DBC", Offset = "0x6DBC", VA = "0x6DBC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001C3E RID: 7230 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000500")]
		public TextMeshProUGUI Description
		{
			[Token(Token = "0x6001C3E")]
			[Address(RVA = "0x6DBD", Offset = "0x6DBD", VA = "0x6DBD")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000501")]
		public TextMeshProUGUI Status
		{
			[Token(Token = "0x6001C3F")]
			[Address(RVA = "0x6DBE", Offset = "0x6DBE", VA = "0x6DBE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000502")]
		public TextMeshProUGUI Annotation
		{
			[Token(Token = "0x6001C40")]
			[Address(RVA = "0x6DBF", Offset = "0x6DBF", VA = "0x6DBF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000503")]
		public UserViewWithNickname WinnerView
		{
			[Token(Token = "0x6001C41")]
			[Address(RVA = "0x6DC0", Offset = "0x6DC0", VA = "0x6DC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000504")]
		public TournamentBank Bank
		{
			[Token(Token = "0x6001C42")]
			[Address(RVA = "0x6DC1", Offset = "0x6DC1", VA = "0x6DC1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000505")]
		public BetControlView BetControlView
		{
			[Token(Token = "0x6001C43")]
			[Address(RVA = "0x6DC2", Offset = "0x6DC2", VA = "0x6DC2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000506")]
		public MultilineTextList MultilineInfo
		{
			[Token(Token = "0x6001C44")]
			[Address(RVA = "0x6DC3", Offset = "0x6DC3", VA = "0x6DC3")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C45")]
		[Address(RVA = "0x6DC4", Offset = "0x6DC4", VA = "0x6DC4")]
		public void SetParticipantsCount(uint count)
		{
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C46")]
		[Address(RVA = "0x6DC5", Offset = "0x6DC5", VA = "0x6DC5")]
		public TournamentInfoBox()
		{
		}

		// Token: 0x04000F47 RID: 3911
		[Token(Token = "0x4000F47")]
		private const string LOCALIZATION_PARTICIPANTS = "TOURNAMENTS/PARTICIPANTS";

		// Token: 0x04000F48 RID: 3912
		[Token(Token = "0x4000F48")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000F49 RID: 3913
		[Token(Token = "0x4000F49")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04000F4A RID: 3914
		[Token(Token = "0x4000F4A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _status;

		// Token: 0x04000F4B RID: 3915
		[Token(Token = "0x4000F4B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _annotation;

		// Token: 0x04000F4C RID: 3916
		[Token(Token = "0x4000F4C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private UserViewWithNickname _winnerView;

		// Token: 0x04000F4D RID: 3917
		[Token(Token = "0x4000F4D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TournamentBank _bank;

		// Token: 0x04000F4E RID: 3918
		[Token(Token = "0x4000F4E")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _participantsCount;

		// Token: 0x04000F4F RID: 3919
		[Token(Token = "0x4000F4F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BetControlView _betControlView;

		// Token: 0x04000F50 RID: 3920
		[Token(Token = "0x4000F50")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private MultilineTextList _textList;

		// Token: 0x020004AC RID: 1196
		[Token(Token = "0x20004AC")]
		public enum State
		{
			// Token: 0x04000F52 RID: 3922
			[Token(Token = "0x4000F52")]
			NO_TOURNAMENT,
			// Token: 0x04000F53 RID: 3923
			[Token(Token = "0x4000F53")]
			COLLECT_BETS,
			// Token: 0x04000F54 RID: 3924
			[Token(Token = "0x4000F54")]
			DO_BETS,
			// Token: 0x04000F55 RID: 3925
			[Token(Token = "0x4000F55")]
			BATTLE,
			// Token: 0x04000F56 RID: 3926
			[Token(Token = "0x4000F56")]
			WAITING,
			// Token: 0x04000F57 RID: 3927
			[Token(Token = "0x4000F57")]
			FINISHED,
			// Token: 0x04000F58 RID: 3928
			[Token(Token = "0x4000F58")]
			CANCELED
		}
	}
}
