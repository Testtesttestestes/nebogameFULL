using System;
using AssetContent.Loaders;
using Core;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace AssetContent
{
	// Token: 0x02000E2D RID: 3629
	[Token(Token = "0x2000E2D")]
	[RequireComponent(typeof(GameImageLoader))]
	public class GameImage : ImageWithGrayscale, IGameAssetContent
	{
		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x060058E0 RID: 22752 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060058E1 RID: 22753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700121A")]
		public string AssetId
		{
			[Token(Token = "0x60058E0")]
			[Address(RVA = "0xA648", Offset = "0xA648", VA = "0xA648", Slot = "92")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058E1")]
			[Address(RVA = "0xA649", Offset = "0xA649", VA = "0xA649", Slot = "93")]
			set
			{
			}
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x060058E2 RID: 22754 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060058E3 RID: 22755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700121B")]
		public string AssetPath
		{
			[Token(Token = "0x60058E2")]
			[Address(RVA = "0xA64A", Offset = "0xA64A", VA = "0xA64A", Slot = "94")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058E3")]
			[Address(RVA = "0xA64B", Offset = "0xA64B", VA = "0xA64B")]
			set
			{
			}
		}

		// Token: 0x060058E4 RID: 22756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058E4")]
		[Address(RVA = "0xA64C", Offset = "0xA64C", VA = "0xA64C")]
		private void ValidateLoader()
		{
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058E5")]
		[Address(RVA = "0xA64D", Offset = "0xA64D", VA = "0xA64D")]
		public GameImage()
		{
		}

		// Token: 0x0400300A RID: 12298
		[Token(Token = "0x400300A")]
		[FieldOffset(Offset = "0xB4")]
		private GameImageLoader _gameImageLoader;
	}
}
