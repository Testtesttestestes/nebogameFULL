using System;
using AssetContent.Loaders;
using Core;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace AssetContent
{
	// Token: 0x02000E2E RID: 3630
	[Token(Token = "0x2000E2E")]
	[RequireComponent(typeof(GameRawImageLoader))]
	public class GameRawImage : RawImageWithGrayscale, IGameAssetContent
	{
		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x060058E6 RID: 22758 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060058E7 RID: 22759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700121C")]
		public string AssetId
		{
			[Token(Token = "0x60058E6")]
			[Address(RVA = "0xA64E", Offset = "0xA64E", VA = "0xA64E", Slot = "68")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058E7")]
			[Address(RVA = "0x1BE9", Offset = "0x1BE9", VA = "0x1BE9", Slot = "69")]
			set
			{
			}
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x060058E8 RID: 22760 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060058E9 RID: 22761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700121D")]
		public string AssetPath
		{
			[Token(Token = "0x60058E8")]
			[Address(RVA = "0xA64F", Offset = "0xA64F", VA = "0xA64F", Slot = "70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058E9")]
			[Address(RVA = "0xA650", Offset = "0xA650", VA = "0xA650")]
			set
			{
			}
		}

		// Token: 0x060058EA RID: 22762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058EA")]
		[Address(RVA = "0xA651", Offset = "0xA651", VA = "0xA651")]
		private void ValidateLoader()
		{
		}

		// Token: 0x060058EB RID: 22763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058EB")]
		[Address(RVA = "0xA652", Offset = "0xA652", VA = "0xA652")]
		public GameRawImage()
		{
		}

		// Token: 0x0400300B RID: 12299
		[Token(Token = "0x400300B")]
		[FieldOffset(Offset = "0x98")]
		private GameRawImageLoader _gameRawImageLoader;
	}
}
