using System;
using Gameplay.Clans.Office.Model;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Clans.Office.View.ClanOverviewTab
{
	// Token: 0x02000A33 RID: 2611
	[Token(Token = "0x2000A33")]
	public class ClanInfoBox : MonoBehaviour
	{
		// Token: 0x06003DD7 RID: 15831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DD7")]
		[Address(RVA = "0x8C96", Offset = "0x8C96", VA = "0x8C96")]
		public void Init(ClanOfficeData data, Dictionaries dict)
		{
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DD8")]
		[Address(RVA = "0x8C97", Offset = "0x8C97", VA = "0x8C97")]
		private void UpdateMembers(ClanOfficeData data)
		{
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DD9")]
		[Address(RVA = "0x8C98", Offset = "0x8C98", VA = "0x8C98")]
		public ClanInfoBox()
		{
		}

		// Token: 0x040022A7 RID: 8871
		[Token(Token = "0x40022A7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ClanTitle _title;

		// Token: 0x040022A8 RID: 8872
		[Token(Token = "0x40022A8")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ClanRatingsGroup _ratings;

		// Token: 0x040022A9 RID: 8873
		[Token(Token = "0x40022A9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TitleIconValueBackground _totalMembers;

		// Token: 0x040022AA RID: 8874
		[Token(Token = "0x40022AA")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TitleIconValueBackground _generals;

		// Token: 0x040022AB RID: 8875
		[Token(Token = "0x40022AB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TitleIconValueBackground _legends;

		// Token: 0x040022AC RID: 8876
		[Token(Token = "0x40022AC")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TitleIconValueBackground _freeVacancies;
	}
}
