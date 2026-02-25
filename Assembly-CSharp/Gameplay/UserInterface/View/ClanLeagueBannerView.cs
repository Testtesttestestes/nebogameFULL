using System;
using AssetContent;
using AssetContent.Loaders;
using Gameplay.World.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.UserInterface.View
{
	// Token: 0x020003BB RID: 955
	[Token(Token = "0x20003BB")]
	public class ClanLeagueBannerView : MonoBehaviour
	{
		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001667 RID: 5735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BB")]
		public ClanData ClanData
		{
			[Token(Token = "0x6001666")]
			[Address(RVA = "0x6827", Offset = "0x6827", VA = "0x6827")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001667")]
			[Address(RVA = "0x6828", Offset = "0x6828", VA = "0x6828")]
			set
			{
			}
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001668")]
		[Address(RVA = "0x6829", Offset = "0x6829", VA = "0x6829")]
		private void HandleClanDataChanged()
		{
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001669")]
		[Address(RVA = "0x682A", Offset = "0x682A", VA = "0x682A")]
		public ClanLeagueBannerView()
		{
		}

		// Token: 0x04000BC1 RID: 3009
		[Token(Token = "0x4000BC1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAssetViewRawImage _bg;

		// Token: 0x04000BC2 RID: 3010
		[Token(Token = "0x4000BC2")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameAssetViewRawImage _icon;

		// Token: 0x04000BC3 RID: 3011
		[Token(Token = "0x4000BC3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImageLoader _decor;

		// Token: 0x04000BC4 RID: 3012
		[Token(Token = "0x4000BC4")]
		[FieldOffset(Offset = "0x1C")]
		private ClanData _clanData;
	}
}
