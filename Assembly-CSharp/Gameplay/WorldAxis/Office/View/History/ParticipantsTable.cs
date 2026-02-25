using System;
using System.Collections.Generic;
using Gameplay.WorldAxis.Office.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.History
{
	// Token: 0x02000318 RID: 792
	[Token(Token = "0x2000318")]
	public class ParticipantsTable : MonoBehaviour
	{
		// Token: 0x0600124D RID: 4685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124D")]
		[Address(RVA = "0x6447", Offset = "0x6447", VA = "0x6447")]
		public void Init(IList<HistoryModel.Participant> participants, int maxPlayers)
		{
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124E")]
		[Address(RVA = "0x6448", Offset = "0x6448", VA = "0x6448")]
		public ParticipantsTable()
		{
		}

		// Token: 0x040009C1 RID: 2497
		[Token(Token = "0x40009C1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x040009C2 RID: 2498
		[Token(Token = "0x40009C2")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ParticipantRow _rowPrefab;

		// Token: 0x040009C3 RID: 2499
		[Token(Token = "0x40009C3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _fightersText;
	}
}
