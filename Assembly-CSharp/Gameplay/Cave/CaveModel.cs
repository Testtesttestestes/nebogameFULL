using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Isles.User;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Dic;

namespace Gameplay.Cave
{
	// Token: 0x02000B32 RID: 2866
	[Token(Token = "0x2000B32")]
	public class CaveModel : AbstractModel, IMonsterSource
	{
		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x0600459F RID: 17823 RVA: 0x0000D140 File Offset: 0x0000B340
		[Token(Token = "0x17000DB7")]
		public ulong OwnerId
		{
			[Token(Token = "0x600459F")]
			[Address(RVA = "0x9441", Offset = "0x9441", VA = "0x9441", Slot = "6")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x060045A0 RID: 17824 RVA: 0x0000D158 File Offset: 0x0000B358
		[Token(Token = "0x17000DB8")]
		public bool HasMonster
		{
			[Token(Token = "0x60045A0")]
			[Address(RVA = "0x9442", Offset = "0x9442", VA = "0x9442")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x060045A1 RID: 17825 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060045A2 RID: 17826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB9")]
		public MonsterData Monster
		{
			[Token(Token = "0x60045A1")]
			[Address(RVA = "0x9443", Offset = "0x9443", VA = "0x9443", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045A2")]
			[Address(RVA = "0x9444", Offset = "0x9444", VA = "0x9444")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x060045A3 RID: 17827 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060045A4 RID: 17828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBA")]
		public IGameAudio GameAudio
		{
			[Token(Token = "0x60045A3")]
			[Address(RVA = "0x9445", Offset = "0x9445", VA = "0x9445")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045A4")]
			[Address(RVA = "0x9446", Offset = "0x9446", VA = "0x9446")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045A5")]
		[Address(RVA = "0x9447", Offset = "0x9447", VA = "0x9447", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045A6")]
		[Address(RVA = "0x9448", Offset = "0x9448", VA = "0x9448")]
		public CaveModel(UserData user, IGameAudio gameAudio)
		{
		}

		// Token: 0x04002610 RID: 9744
		[Token(Token = "0x4002610")]
		[FieldOffset(Offset = "0xC")]
		public List<RewardInfo> Rewards;

		// Token: 0x04002611 RID: 9745
		[Token(Token = "0x4002611")]
		[FieldOffset(Offset = "0x10")]
		public bool MonsterStatusConfirmed;

		// Token: 0x04002613 RID: 9747
		[Token(Token = "0x4002613")]
		[FieldOffset(Offset = "0x18")]
		public ResourceSet SearchPrice;

		// Token: 0x04002614 RID: 9748
		[Token(Token = "0x4002614")]
		[FieldOffset(Offset = "0x1C")]
		public bool IsHorde;

		// Token: 0x02000B33 RID: 2867
		[Token(Token = "0x2000B33")]
		public class RewardInCave
		{
			// Token: 0x17000DBB RID: 3515
			// (get) Token: 0x060045A7 RID: 17831 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060045A8 RID: 17832 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DBB")]
			public AssetDic SoundAsset
			{
				[Token(Token = "0x60045A7")]
				[Address(RVA = "0x9449", Offset = "0x9449", VA = "0x9449")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60045A8")]
				[Address(RVA = "0x944A", Offset = "0x944A", VA = "0x944A")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060045A9 RID: 17833 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60045A9")]
			[Address(RVA = "0x944B", Offset = "0x944B", VA = "0x944B")]
			public RewardInCave(uint id, int amount, string imageAssetId, string name, AssetDic soundAsset)
			{
			}

			// Token: 0x04002616 RID: 9750
			[Token(Token = "0x4002616")]
			[FieldOffset(Offset = "0x8")]
			public readonly uint id;

			// Token: 0x04002617 RID: 9751
			[Token(Token = "0x4002617")]
			[FieldOffset(Offset = "0xC")]
			public readonly string ImageAssetId;

			// Token: 0x04002618 RID: 9752
			[Token(Token = "0x4002618")]
			[FieldOffset(Offset = "0x10")]
			public readonly string name;

			// Token: 0x04002619 RID: 9753
			[Token(Token = "0x4002619")]
			[FieldOffset(Offset = "0x14")]
			public readonly int amount;
		}

		// Token: 0x02000B34 RID: 2868
		[Token(Token = "0x2000B34")]
		public class MonsterInCave
		{
			// Token: 0x060045AA RID: 17834 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60045AA")]
			[Address(RVA = "0x944C", Offset = "0x944C", VA = "0x944C")]
			public MonsterInCave(uint monsterId, List<uint> artikuls)
			{
			}

			// Token: 0x0400261B RID: 9755
			[Token(Token = "0x400261B")]
			[FieldOffset(Offset = "0x8")]
			public uint monsterId;

			// Token: 0x0400261C RID: 9756
			[Token(Token = "0x400261C")]
			[FieldOffset(Offset = "0xC")]
			public List<uint> Artikuls;

			// Token: 0x0400261D RID: 9757
			[Token(Token = "0x400261D")]
			[FieldOffset(Offset = "0x10")]
			public MonsterDic MonsterDic;
		}
	}
}
