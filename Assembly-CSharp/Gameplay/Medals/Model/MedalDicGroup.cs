using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Dict.DictWrappers.Wrappers;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Medals.Model
{
	// Token: 0x020005FF RID: 1535
	[Token(Token = "0x20005FF")]
	public class MedalDicGroup
	{
		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006FD")]
		public SortedList<uint, MedalDicWrapper> MedalsByRank
		{
			[Token(Token = "0x6002542")]
			[Address(RVA = "0x768B", Offset = "0x768B", VA = "0x768B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06002543 RID: 9539 RVA: 0x00007140 File Offset: 0x00005340
		[Token(Token = "0x170006FE")]
		public bool HasRanks
		{
			[Token(Token = "0x6002543")]
			[Address(RVA = "0x768C", Offset = "0x768C", VA = "0x768C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06002544 RID: 9540 RVA: 0x00007158 File Offset: 0x00005358
		[Token(Token = "0x170006FF")]
		public uint CategoryId
		{
			[Token(Token = "0x6002544")]
			[Address(RVA = "0x768D", Offset = "0x768D", VA = "0x768D")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06002545 RID: 9541 RVA: 0x00007170 File Offset: 0x00005370
		[Token(Token = "0x17000700")]
		public uint TypeId
		{
			[Token(Token = "0x6002545")]
			[Address(RVA = "0x768E", Offset = "0x768E", VA = "0x768E")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06002546 RID: 9542 RVA: 0x00007188 File Offset: 0x00005388
		// (set) Token: 0x06002547 RID: 9543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000701")]
		public uint GroupId
		{
			[Token(Token = "0x6002546")]
			[Address(RVA = "0x768F", Offset = "0x768F", VA = "0x768F")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002547")]
			[Address(RVA = "0x7690", Offset = "0x7690", VA = "0x7690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06002548 RID: 9544 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000702")]
		public MedalCategoryDic MedalCategoryDic
		{
			[Token(Token = "0x6002548")]
			[Address(RVA = "0x7691", Offset = "0x7691", VA = "0x7691")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000703")]
		public MedalTypeDic MedalTypeDic
		{
			[Token(Token = "0x6002549")]
			[Address(RVA = "0x7692", Offset = "0x7692", VA = "0x7692")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600254A RID: 9546 RVA: 0x000071A0 File Offset: 0x000053A0
		// (set) Token: 0x0600254B RID: 9547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000704")]
		public bool IsVisible
		{
			[Token(Token = "0x600254A")]
			[Address(RVA = "0x7693", Offset = "0x7693", VA = "0x7693")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600254B")]
			[Address(RVA = "0x7694", Offset = "0x7694", VA = "0x7694")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600254C")]
		[Address(RVA = "0x1BF3", Offset = "0x1BF3", VA = "0x1BF3")]
		public void AddMedal(MedalDicWrapper medal, MedalCategoryDic categoryDic, MedalTypeDic typeDic)
		{
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600254D")]
		[Address(RVA = "0x7695", Offset = "0x7695", VA = "0x7695")]
		public MedalDicWrapper GetMedalDicById(uint medalId)
		{
			return null;
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600254E")]
		[Address(RVA = "0x1BF2", Offset = "0x1BF2", VA = "0x1BF2")]
		public MedalDicGroup()
		{
		}

		// Token: 0x04001469 RID: 5225
		[Token(Token = "0x4001469")]
		[FieldOffset(Offset = "0x8")]
		private SortedList<uint, MedalDicWrapper> _medalsByRank;

		// Token: 0x0400146A RID: 5226
		[Token(Token = "0x400146A")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<uint, MedalDicWrapper> _medalsById;

		// Token: 0x0400146C RID: 5228
		[Token(Token = "0x400146C")]
		[FieldOffset(Offset = "0x14")]
		private MedalCategoryDic _medalCategoryDic;

		// Token: 0x0400146E RID: 5230
		[Token(Token = "0x400146E")]
		[FieldOffset(Offset = "0x1C")]
		private MedalTypeDic _medalTypeDic;
	}
}
