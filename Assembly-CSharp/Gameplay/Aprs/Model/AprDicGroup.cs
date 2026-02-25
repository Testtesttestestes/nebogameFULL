using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Dict.DictWrappers.Wrappers;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Aprs.Model
{
	// Token: 0x02000D62 RID: 3426
	[Token(Token = "0x2000D62")]
	public class AprDicGroup
	{
		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x060053FC RID: 21500 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001114")]
		public SortedList<uint, MedalDicWrapper> MedalsByCollectionRank
		{
			[Token(Token = "0x60053FC")]
			[Address(RVA = "0xA1B4", Offset = "0xA1B4", VA = "0xA1B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x060053FD RID: 21501 RVA: 0x0000F288 File Offset: 0x0000D488
		[Token(Token = "0x17001115")]
		public uint CategoryId
		{
			[Token(Token = "0x60053FD")]
			[Address(RVA = "0xA1B5", Offset = "0xA1B5", VA = "0xA1B5")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x060053FE RID: 21502 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		// (set) Token: 0x060053FF RID: 21503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001116")]
		public uint CollectionId
		{
			[Token(Token = "0x60053FE")]
			[Address(RVA = "0xA1B6", Offset = "0xA1B6", VA = "0xA1B6")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60053FF")]
			[Address(RVA = "0xA1B7", Offset = "0xA1B7", VA = "0xA1B7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06005400 RID: 21504 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		// (set) Token: 0x06005401 RID: 21505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001117")]
		public bool IsVisible
		{
			[Token(Token = "0x6005400")]
			[Address(RVA = "0xA1B8", Offset = "0xA1B8", VA = "0xA1B8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005401")]
			[Address(RVA = "0xA1B9", Offset = "0xA1B9", VA = "0xA1B9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005402 RID: 21506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005402")]
		[Address(RVA = "0xA1BA", Offset = "0xA1BA", VA = "0xA1BA")]
		public void AddMedal(MedalDicWrapper medal, MedalCategoryDic categoryDic, MedalTypeDic typeDic)
		{
		}

		// Token: 0x06005403 RID: 21507 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005403")]
		[Address(RVA = "0xA1BB", Offset = "0xA1BB", VA = "0xA1BB")]
		public MedalDicWrapper GetMedalDicById(uint medalId)
		{
			return null;
		}

		// Token: 0x06005404 RID: 21508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005404")]
		[Address(RVA = "0x1E3B", Offset = "0x1E3B", VA = "0x1E3B")]
		public AprDicGroup()
		{
		}

		// Token: 0x04002D7E RID: 11646
		[Token(Token = "0x4002D7E")]
		[FieldOffset(Offset = "0x8")]
		private SortedList<uint, MedalDicWrapper> _medalsByCollectionRank;

		// Token: 0x04002D7F RID: 11647
		[Token(Token = "0x4002D7F")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<uint, MedalDicWrapper> _medalsById;

		// Token: 0x04002D80 RID: 11648
		[Token(Token = "0x4002D80")]
		[FieldOffset(Offset = "0x10")]
		private MedalCategoryDic _medalCategoryDic;
	}
}
