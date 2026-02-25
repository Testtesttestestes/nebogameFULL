using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Data;
using Core.Gameplay;
using Gameplay.Boss.Model;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02000FDF RID: 4063
	[Token(Token = "0x2000FDF")]
	public class BossScope : AbstractEventBusScope
	{
		// Token: 0x060060D6 RID: 24790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060D6")]
		[Address(RVA = "0xAD02", Offset = "0xAD02", VA = "0xAD02", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060060D7 RID: 24791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060D7")]
		[Address(RVA = "0xAD03", Offset = "0xAD03", VA = "0xAD03")]
		public BossScope()
		{
		}

		// Token: 0x040033C4 RID: 13252
		[Token(Token = "0x40033C4")]
		[FieldOffset(Offset = "0x8")]
		public Action<BossScope.AttackBossEventArgs> AttackBossEvent;

		// Token: 0x040033C5 RID: 13253
		[Token(Token = "0x40033C5")]
		[FieldOffset(Offset = "0xC")]
		public Action<BossScope.MinionEventArgs> MinionAttackEvent;

		// Token: 0x040033C6 RID: 13254
		[Token(Token = "0x40033C6")]
		[FieldOffset(Offset = "0x10")]
		public Action<BossScope.MinionEventArgs> MinionKickedEvent;

		// Token: 0x040033C7 RID: 13255
		[Token(Token = "0x40033C7")]
		[FieldOffset(Offset = "0x14")]
		public Action<BossScope.InviteEventArgs> AcceptInviteEvent;

		// Token: 0x02000FE0 RID: 4064
		[Token(Token = "0x2000FE0")]
		public class AttackBossEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001316 RID: 4886
			// (get) Token: 0x060060D8 RID: 24792 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001316")]
			public BossInstanceModel BossInstanceModel
			{
				[Token(Token = "0x60060D8")]
				[Address(RVA = "0xAD04", Offset = "0xAD04", VA = "0xAD04")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17001317 RID: 4887
			// (get) Token: 0x060060D9 RID: 24793 RVA: 0x00011A30 File Offset: 0x0000FC30
			[Token(Token = "0x17001317")]
			public long OptionId
			{
				[Token(Token = "0x60060D9")]
				[Address(RVA = "0xAD05", Offset = "0xAD05", VA = "0xAD05")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001318 RID: 4888
			// (get) Token: 0x060060DA RID: 24794 RVA: 0x00011A48 File Offset: 0x0000FC48
			[Token(Token = "0x17001318")]
			public int VariantId
			{
				[Token(Token = "0x60060DA")]
				[Address(RVA = "0xAD06", Offset = "0xAD06", VA = "0xAD06")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x060060DB RID: 24795 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060DB")]
			[Address(RVA = "0xAD07", Offset = "0xAD07", VA = "0xAD07")]
			public AttackBossEventArgs(App app, IGame game, BossInstanceModel bossInstance, long optionId, int variantId)
			{
			}
		}

		// Token: 0x02000FE1 RID: 4065
		[Token(Token = "0x2000FE1")]
		public class MinionEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001319 RID: 4889
			// (get) Token: 0x060060DC RID: 24796 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001319")]
			public BossInstanceModel BossInstanceModel
			{
				[Token(Token = "0x60060DC")]
				[Address(RVA = "0xAD08", Offset = "0xAD08", VA = "0xAD08")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700131A RID: 4890
			// (get) Token: 0x060060DD RID: 24797 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700131A")]
			public MonsterData MonsterData
			{
				[Token(Token = "0x60060DD")]
				[Address(RVA = "0xAD09", Offset = "0xAD09", VA = "0xAD09")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060060DE RID: 24798 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060DE")]
			[Address(RVA = "0xAD0A", Offset = "0xAD0A", VA = "0xAD0A")]
			public MinionEventArgs(App app, IGame game, BossInstanceModel bossInstance, MonsterData monsterData)
			{
			}
		}

		// Token: 0x02000FE2 RID: 4066
		[Token(Token = "0x2000FE2")]
		public class InviteEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x1700131B RID: 4891
			// (get) Token: 0x060060DF RID: 24799 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700131B")]
			public BossInstanceModel BossInstanceModel
			{
				[Token(Token = "0x60060DF")]
				[Address(RVA = "0xAD0B", Offset = "0xAD0B", VA = "0xAD0B")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700131C RID: 4892
			// (get) Token: 0x060060E0 RID: 24800 RVA: 0x00011A60 File Offset: 0x0000FC60
			[Token(Token = "0x1700131C")]
			public ulong CaptainId
			{
				[Token(Token = "0x60060E0")]
				[Address(RVA = "0xAD0C", Offset = "0xAD0C", VA = "0xAD0C")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x060060E1 RID: 24801 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060E1")]
			[Address(RVA = "0xAD0D", Offset = "0xAD0D", VA = "0xAD0D")]
			public InviteEventArgs(App app, IGame game, BossInstanceModel bossInstance, ulong captainId)
			{
			}
		}
	}
}
