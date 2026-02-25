using System;
using System.Collections.Generic;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Inventory.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Auchan;
using Protocol.Dic;

namespace Gameplay.Auchan.Model
{
	// Token: 0x02000C94 RID: 3220
	[Token(Token = "0x2000C94")]
	public class AuchanModel : AbstractModel
	{
		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x06004E6F RID: 20079 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FE5")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6004E6F")]
			[Address(RVA = "0x9CA0", Offset = "0x9CA0", VA = "0x9CA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004E70 RID: 20080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E70")]
		[Address(RVA = "0x9CA1", Offset = "0x9CA1", VA = "0x9CA1")]
		public AuchanModel(UserData user, IGame game, IDictProvider dictProvider)
		{
		}

		// Token: 0x06004E71 RID: 20081 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		[Token(Token = "0x6004E71")]
		[Address(RVA = "0x9CA2", Offset = "0x9CA2", VA = "0x9CA2")]
		public bool TryGetAuchanArtifact(ulong artId, out AuchanArtifactData artifact)
		{
			return default(bool);
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004E72")]
		[Address(RVA = "0x9CA3", Offset = "0x9CA3", VA = "0x9CA3")]
		public List<InventoryMetaFilterData> GetAllArtikulTypeFilters()
		{
			return null;
		}

		// Token: 0x06004E73 RID: 20083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E73")]
		[Address(RVA = "0x9CA4", Offset = "0x9CA4", VA = "0x9CA4")]
		public void PopulateDictionaries(IEnumerable<AuchanItem> items)
		{
		}

		// Token: 0x04002ADA RID: 10970
		[Token(Token = "0x4002ADA")]
		[FieldOffset(Offset = "0xC")]
		public Dictionary<uint, List<AuchanArtifactData>> ArtifactsByFilterID;

		// Token: 0x04002ADB RID: 10971
		[Token(Token = "0x4002ADB")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<uint, string> CategoryNamesByFilterID;

		// Token: 0x04002ADC RID: 10972
		[Token(Token = "0x4002ADC")]
		[FieldOffset(Offset = "0x14")]
		public readonly IGame Game;

		// Token: 0x04002ADD RID: 10973
		[Token(Token = "0x4002ADD")]
		[FieldOffset(Offset = "0x18")]
		private List<InventoryMetaFilterData> _artikulTypeFiltersCache;

		// Token: 0x04002ADE RID: 10974
		[Token(Token = "0x4002ADE")]
		[FieldOffset(Offset = "0x1C")]
		private readonly IDictProvider _dictProvider;
	}
}
