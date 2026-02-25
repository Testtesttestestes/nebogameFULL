using System;
using Gameplay.SmallGames.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.SmallGames;
using UnityEngine;

namespace Gameplay.SmallGames.View
{
	// Token: 0x02000514 RID: 1300
	[Token(Token = "0x2000514")]
	public class LastJackpotsView : MonoBehaviour
	{
		// Token: 0x06001EF8 RID: 7928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF8")]
		[Address(RVA = "0x705F", Offset = "0x705F", VA = "0x705F")]
		public void SetJackpot(SlotMachineType type, in SmallGamesModel.JackpotInfo jackpot, Dictionaries dict)
		{
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF9")]
		[Address(RVA = "0x7060", Offset = "0x7060", VA = "0x7060")]
		public LastJackpotsView()
		{
		}

		// Token: 0x040010C4 RID: 4292
		[Token(Token = "0x40010C4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private JackpotInfoView _diamondJackpot;

		// Token: 0x040010C5 RID: 4293
		[Token(Token = "0x40010C5")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private JackpotInfoView _onyxJackpot;
	}
}
