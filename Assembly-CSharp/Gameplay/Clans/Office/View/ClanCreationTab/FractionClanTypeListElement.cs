using System;
using System.Collections.Generic;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Clans.Office.View.ClanCreationTab
{
	// Token: 0x02000A40 RID: 2624
	[Token(Token = "0x2000A40")]
	public class FractionClanTypeListElement : ClanTypeListElement
	{
		// Token: 0x06003E1C RID: 15900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E1C")]
		[Address(RVA = "0x8CDB", Offset = "0x8CDB", VA = "0x8CDB")]
		public void Init(ClanCultDic dic, List<CultDic> cultDics)
		{
		}

		// Token: 0x06003E1D RID: 15901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E1D")]
		[Address(RVA = "0x8CDC", Offset = "0x8CDC", VA = "0x8CDC")]
		public FractionClanTypeListElement()
		{
		}

		// Token: 0x040022E2 RID: 8930
		[Token(Token = "0x40022E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameImage[] _cultIcons;
	}
}
