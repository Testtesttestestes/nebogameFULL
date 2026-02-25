using System;
using Gameplay.UserInfo.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x020009F7 RID: 2551
	[Token(Token = "0x20009F7")]
	public class ClanLeagueBaseInfoView : MonoBehaviour
	{
		// Token: 0x06003CD3 RID: 15571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CD3")]
		[Address(RVA = "0x8B96", Offset = "0x8B96", VA = "0x8B96")]
		private void Awake()
		{
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CD4")]
		[Address(RVA = "0x8B97", Offset = "0x8B97", VA = "0x8B97")]
		public void UpdateInfo(ClanData data, string honorAssetId)
		{
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CD5")]
		[Address(RVA = "0x8B98", Offset = "0x8B98", VA = "0x8B98")]
		public ClanLeagueBaseInfoView()
		{
		}

		// Token: 0x040021B1 RID: 8625
		[Token(Token = "0x40021B1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TitleIconValueBackground _leagueName;

		// Token: 0x040021B2 RID: 8626
		[Token(Token = "0x40021B2")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TitleIconValueBackground _honor;

		// Token: 0x040021B3 RID: 8627
		[Token(Token = "0x40021B3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TitleIconValueBackground _place;
	}
}
