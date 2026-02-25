using System;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x020009FD RID: 2557
	[Token(Token = "0x20009FD")]
	public class ClanRatingsGroup : MonoBehaviour
	{
		// Token: 0x06003CE4 RID: 15588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE4")]
		[Address(RVA = "0x8BA4", Offset = "0x8BA4", VA = "0x8BA4")]
		public void Init(Dictionaries dict)
		{
		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE5")]
		[Address(RVA = "0x8BA5", Offset = "0x8BA5", VA = "0x8BA5")]
		public void UpdateRatings(Dictionaries dict, ClanInfo info)
		{
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE6")]
		[Address(RVA = "0x8BA6", Offset = "0x8BA6", VA = "0x8BA6")]
		public ClanRatingsGroup()
		{
		}

		// Token: 0x040021C5 RID: 8645
		[Token(Token = "0x40021C5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TitleIconValueBackground _rowPrefab;

		// Token: 0x040021C6 RID: 8646
		[Token(Token = "0x40021C6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x040021C7 RID: 8647
		[Token(Token = "0x40021C7")]
		[FieldOffset(Offset = "0x18")]
		private TitleIconValueBackground[] _ratingRows;
	}
}
