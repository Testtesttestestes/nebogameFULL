using System;
using Core.Data.Tournaments;
using Gameplay.BlitzTournament.View;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004AD RID: 1197
	[Token(Token = "0x20004AD")]
	public class TournamentListElement : TournamentListElementBase<TournamentData>
	{
		// Token: 0x06001C47 RID: 7239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C47")]
		[Address(RVA = "0x6DC6", Offset = "0x6DC6", VA = "0x6DC6", Slot = "9")]
		public override void UpdateView()
		{
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C48")]
		[Address(RVA = "0x6DC7", Offset = "0x6DC7", VA = "0x6DC7")]
		public TournamentListElement()
		{
		}

		// Token: 0x04000F59 RID: 3929
		[Token(Token = "0x4000F59")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _statusText;

		// Token: 0x04000F5A RID: 3930
		[Token(Token = "0x4000F5A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private BacktimeViewUGUI _timer;
	}
}
