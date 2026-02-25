using System;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Collections.View
{
	// Token: 0x020009C8 RID: 2504
	[Token(Token = "0x20009C8")]
	public class CollectionView : MonoBehaviour
	{
		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06003C00 RID: 15360 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		// (set) Token: 0x06003C01 RID: 15361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD6")]
		public bool IgnoreAchieved
		{
			[Token(Token = "0x6003C00")]
			[Address(RVA = "0x8AD1", Offset = "0x8AD1", VA = "0x8AD1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003C01")]
			[Address(RVA = "0x214E", Offset = "0x214E", VA = "0x214E")]
			set
			{
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06003C02 RID: 15362 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003C03 RID: 15363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD7")]
		public CollectionData Data
		{
			[Token(Token = "0x6003C02")]
			[Address(RVA = "0x8AD2", Offset = "0x8AD2", VA = "0x8AD2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C03")]
			[Address(RVA = "0x8AD3", Offset = "0x8AD3", VA = "0x8AD3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003C04 RID: 15364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C04")]
		[Address(RVA = "0x214F", Offset = "0x214F", VA = "0x214F")]
		public void SetInfo(CollectionData data, UserData user, uint rankToShow)
		{
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C05")]
		[Address(RVA = "0x8AD4", Offset = "0x8AD4", VA = "0x8AD4")]
		public CollectionView()
		{
		}

		// Token: 0x0400211D RID: 8477
		[Token(Token = "0x400211D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400211E RID: 8478
		[Token(Token = "0x400211E")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _rank;

		// Token: 0x0400211F RID: 8479
		[Token(Token = "0x400211F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImageLoader _qualityBigBgLoader;

		// Token: 0x04002120 RID: 8480
		[Token(Token = "0x4002120")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected CollectionIconView _collectionIcon;
	}
}
