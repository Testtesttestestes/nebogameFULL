using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Clans.Office.View.ClanWarsTab.ClanWarsHistoryTab;
using Il2CppDummyDll;
using MVC;
using Protocol.ClanWar;
using Protocol.Dic;

namespace Gameplay.Clans.Office.Model.ClanWars
{
	// Token: 0x02000A5B RID: 2651
	[Token(Token = "0x2000A5B")]
	public class ClanWarsHistoryModel : AbstractModel
	{
		// Token: 0x06003EC6 RID: 16070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EC6")]
		[Address(RVA = "0x8D82", Offset = "0x8D82", VA = "0x8D82")]
		public ClanWarsHistoryModel(UserData user, Dictionaries dict)
		{
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06003EC7 RID: 16071 RVA: 0x0000C600 File Offset: 0x0000A800
		[Token(Token = "0x17000C97")]
		public uint LastWarId
		{
			[Token(Token = "0x6003EC7")]
			[Address(RVA = "0x8D83", Offset = "0x8D83", VA = "0x8D83")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003EC8")]
		[Address(RVA = "0x8D84", Offset = "0x8D84", VA = "0x8D84")]
		public IList<ClanWarHistoryListElement.ClanWarHistoryListElementArgs> GetLastPage()
		{
			return null;
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EC9")]
		[Address(RVA = "0x8D85", Offset = "0x8D85", VA = "0x8D85")]
		public void CreateHistoryList(IList<ProtoGetWarsHistoryAns.Types.WarHistoryRecord> history)
		{
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ECA")]
		[Address(RVA = "0x8D86", Offset = "0x8D86", VA = "0x8D86")]
		public void AddHistoryList(IList<ProtoGetWarsHistoryAns.Types.WarHistoryRecord> history)
		{
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003ECB")]
		[Address(RVA = "0x8D87", Offset = "0x8D87", VA = "0x8D87")]
		private ClanWarHistoryListElement.ClanWarHistoryListElementArgs ConstructArgs(ProtoGetWarsHistoryAns.Types.WarHistoryRecord warRecord)
		{
			return null;
		}

		// Token: 0x04002352 RID: 9042
		[Token(Token = "0x4002352")]
		[FieldOffset(Offset = "0xC")]
		public readonly Dictionaries Dict;

		// Token: 0x04002353 RID: 9043
		[Token(Token = "0x4002353")]
		[FieldOffset(Offset = "0x10")]
		public readonly string HonorAssetId;

		// Token: 0x04002354 RID: 9044
		[Token(Token = "0x4002354")]
		[FieldOffset(Offset = "0x14")]
		public readonly List<IList<ClanWarHistoryListElement.ClanWarHistoryListElementArgs>> HistoryArgsPagesStack;

		// Token: 0x04002355 RID: 9045
		[Token(Token = "0x4002355")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<uint, ClanWarResultDic> _resultDics;
	}
}
