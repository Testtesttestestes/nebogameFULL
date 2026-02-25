using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Core.Gameplay.Managers.Inventory;
using Gameplay.Accounts.Model;
using Gameplay.Horde.Model.Data;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.World;

namespace Gameplay.Horde.Model
{
	// Token: 0x020006FF RID: 1791
	[Token(Token = "0x20006FF")]
	public class HordeModel : AbstractModel
	{
		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06002ADD RID: 10973 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002ADE RID: 10974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000824")]
		public HordeDic Dic
		{
			[Token(Token = "0x6002ADD")]
			[Address(RVA = "0x7B78", Offset = "0x7B78", VA = "0x7B78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002ADE")]
			[Address(RVA = "0x7B79", Offset = "0x7B79", VA = "0x7B79")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06002ADF RID: 10975 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002AE0 RID: 10976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000825")]
		public HordeMonsterData[] Monsters
		{
			[Token(Token = "0x6002ADF")]
			[Address(RVA = "0x7B7A", Offset = "0x7B7A", VA = "0x7B7A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AE0")]
			[Address(RVA = "0x7B7B", Offset = "0x7B7B", VA = "0x7B7B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06002AE1 RID: 10977 RVA: 0x00008640 File Offset: 0x00006840
		// (set) Token: 0x06002AE2 RID: 10978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000826")]
		public uint MainMonsterId
		{
			[Token(Token = "0x6002AE1")]
			[Address(RVA = "0x7B7C", Offset = "0x7B7C", VA = "0x7B7C")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002AE2")]
			[Address(RVA = "0x7B7D", Offset = "0x7B7D", VA = "0x7B7D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06002AE3 RID: 10979 RVA: 0x00008658 File Offset: 0x00006858
		// (set) Token: 0x06002AE4 RID: 10980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000827")]
		public int CurrentMonsterIndex
		{
			[Token(Token = "0x6002AE3")]
			[Address(RVA = "0x7B7E", Offset = "0x7B7E", VA = "0x7B7E")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002AE4")]
			[Address(RVA = "0x7B7F", Offset = "0x7B7F", VA = "0x7B7F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AE5")]
		[Address(RVA = "0x7B80", Offset = "0x7B80", VA = "0x7B80")]
		public HordeModel(IGame game, IDictProvider dictProviderProvider, InventoryManager userInventory, AccountsModel accounts, UserData user)
		{
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AE6")]
		[Address(RVA = "0x7B81", Offset = "0x7B81", VA = "0x7B81")]
		public void PopulateHordeMonsters(IList<MonsterInfo> monsterInfos)
		{
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AE7")]
		[Address(RVA = "0x7B82", Offset = "0x7B82", VA = "0x7B82")]
		private void PopulateMonstersData(IList<MonsterInfo> monsterInfos, MonsterHordesDic[] monsterDics)
		{
		}

		// Token: 0x0400176F RID: 5999
		[Token(Token = "0x400176F")]
		[FieldOffset(Offset = "0xC")]
		public readonly IGame Game;

		// Token: 0x04001770 RID: 6000
		[Token(Token = "0x4001770")]
		[FieldOffset(Offset = "0x10")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04001771 RID: 6001
		[Token(Token = "0x4001771")]
		[FieldOffset(Offset = "0x14")]
		public readonly AccountsModel Accounts;

		// Token: 0x04001772 RID: 6002
		[Token(Token = "0x4001772")]
		[FieldOffset(Offset = "0x18")]
		public readonly InventoryManager UserInventory;
	}
}
