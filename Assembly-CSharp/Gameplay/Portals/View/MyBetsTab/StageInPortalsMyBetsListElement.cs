using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Portal;
using TMPro;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.Portals.View.MyBetsTab
{
	// Token: 0x020005CA RID: 1482
	[Token(Token = "0x20005CA")]
	public class StageInPortalsMyBetsListElement : MonoBehaviour
	{
		// Token: 0x06002383 RID: 9091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002383")]
		[Address(RVA = "0x74D5", Offset = "0x74D5", VA = "0x74D5")]
		public void Init(StageInPortalsMyBetsListElement.StageInPortalsMyBetsListElementArgs args)
		{
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002384")]
		[Address(RVA = "0x74D6", Offset = "0x74D6", VA = "0x74D6")]
		public StageInPortalsMyBetsListElement()
		{
		}

		// Token: 0x04001397 RID: 5015
		[Token(Token = "0x4001397")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _stageHeader;

		// Token: 0x04001398 RID: 5016
		[Token(Token = "0x4001398")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _myBetsContainer;

		// Token: 0x04001399 RID: 5017
		[Token(Token = "0x4001399")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PortalsMyBetsListElement _myBetsListElementPrefab;

		// Token: 0x020005CB RID: 1483
		[Token(Token = "0x20005CB")]
		public class StageInPortalsMyBetsListElementArgs : SelectableListElementArgs<StageInPortalsMyBetsListElement>
		{
			// Token: 0x06002385 RID: 9093 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002385")]
			[Address(RVA = "0x74D7", Offset = "0x74D7", VA = "0x74D7")]
			public StageInPortalsMyBetsListElementArgs()
			{
			}

			// Token: 0x0400139A RID: 5018
			[Token(Token = "0x400139A")]
			[FieldOffset(Offset = "0x1C")]
			public int StageNumber;

			// Token: 0x0400139B RID: 5019
			[Token(Token = "0x400139B")]
			[FieldOffset(Offset = "0x20")]
			public List<BetHistoryRow> MyBets;

			// Token: 0x0400139C RID: 5020
			[Token(Token = "0x400139C")]
			[FieldOffset(Offset = "0x24")]
			public Action<ulong> ClickAction;
		}
	}
}
