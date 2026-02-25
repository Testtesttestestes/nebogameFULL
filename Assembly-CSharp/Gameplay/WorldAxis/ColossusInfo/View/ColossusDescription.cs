using System;
using Gameplay.WorldAxis.Colossus.Combat.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;

namespace Gameplay.WorldAxis.ColossusInfo.View
{
	// Token: 0x0200031B RID: 795
	[Token(Token = "0x200031B")]
	public class ColossusDescription : MonoBehaviour
	{
		// Token: 0x0600125A RID: 4698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125A")]
		[Address(RVA = "0x6454", Offset = "0x6454", VA = "0x6454")]
		public void Init(ColossusDic dic, IColossusCombatRewards rewards)
		{
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600125B")]
		[Address(RVA = "0x6455", Offset = "0x6455", VA = "0x6455")]
		private string GetColoredValue(double value)
		{
			return null;
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125C")]
		[Address(RVA = "0x6456", Offset = "0x6456", VA = "0x6456")]
		public ColossusDescription()
		{
		}

		// Token: 0x040009CC RID: 2508
		[Token(Token = "0x40009CC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040009CD RID: 2509
		[Token(Token = "0x40009CD")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x040009CE RID: 2510
		[Token(Token = "0x40009CE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _conquestPoints;

		// Token: 0x040009CF RID: 2511
		[Token(Token = "0x40009CF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _winColossusShards;

		// Token: 0x040009D0 RID: 2512
		[Token(Token = "0x40009D0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _loseColossusShards;
	}
}
