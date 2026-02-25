using System;
using System.Collections.Generic;
using Gameplay.Combat.View.GameField;
using Gameplay.WorldAxis.Office.Model;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.History
{
	// Token: 0x02000310 RID: 784
	[Token(Token = "0x2000310")]
	public class BattleInfoView : MonoBehaviour
	{
		// Token: 0x06001233 RID: 4659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001233")]
		[Address(RVA = "0x642E", Offset = "0x642E", VA = "0x642E")]
		public void Init(HistoryModel.BattleFullInfo info)
		{
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001234")]
		[Address(RVA = "0x642F", Offset = "0x642F", VA = "0x642F")]
		private void AssignDollSprite(IEnumerable<HistoryModel.Participant> list)
		{
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001235")]
		[Address(RVA = "0x1DD6", Offset = "0x1DD6", VA = "0x1DD6")]
		private Sprite GetDollSprite(StonesTypes stoneType)
		{
			return null;
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001236")]
		[Address(RVA = "0x6430", Offset = "0x6430", VA = "0x6430")]
		public BattleInfoView()
		{
		}

		// Token: 0x040009AD RID: 2477
		[Token(Token = "0x40009AD")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BattleHistoryListElement _generalInfo;

		// Token: 0x040009AE RID: 2478
		[Token(Token = "0x40009AE")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ParticipantsTable _leftTable;

		// Token: 0x040009AF RID: 2479
		[Token(Token = "0x40009AF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticipantsTable _rightTable;

		// Token: 0x040009B0 RID: 2480
		[Token(Token = "0x40009B0")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private StoneMono.StoneAppearanceRecord[] _stoneAppearanceRecords;
	}
}
