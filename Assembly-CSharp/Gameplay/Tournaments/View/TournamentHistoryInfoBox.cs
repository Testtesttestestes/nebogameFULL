using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004A7 RID: 1191
	[Token(Token = "0x20004A7")]
	public class TournamentHistoryInfoBox : MonoBehaviour
	{
		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F3")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6001C25")]
			[Address(RVA = "0x6DA4", Offset = "0x6DA4", VA = "0x6DA4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F4")]
		public UserViewWithNickname WinnerView
		{
			[Token(Token = "0x6001C26")]
			[Address(RVA = "0x6DA5", Offset = "0x6DA5", VA = "0x6DA5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F5")]
		public TournamentBank Bank
		{
			[Token(Token = "0x6001C27")]
			[Address(RVA = "0x6DA6", Offset = "0x6DA6", VA = "0x6DA6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C28")]
		[Address(RVA = "0x6DA7", Offset = "0x6DA7", VA = "0x6DA7")]
		public void SetGladiatorsAndViewersCount(int fightersCount, long viewersCount)
		{
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C29")]
		[Address(RVA = "0x6DA8", Offset = "0x6DA8", VA = "0x6DA8")]
		public TournamentHistoryInfoBox()
		{
		}

		// Token: 0x04000F33 RID: 3891
		[Token(Token = "0x4000F33")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000F34 RID: 3892
		[Token(Token = "0x4000F34")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private UserViewWithNickname _winnerView;

		// Token: 0x04000F35 RID: 3893
		[Token(Token = "0x4000F35")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TournamentBank _bank;

		// Token: 0x04000F36 RID: 3894
		[Token(Token = "0x4000F36")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _gladiatorsCountLine;

		// Token: 0x04000F37 RID: 3895
		[Token(Token = "0x4000F37")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _viewersCountLine;
	}
}
