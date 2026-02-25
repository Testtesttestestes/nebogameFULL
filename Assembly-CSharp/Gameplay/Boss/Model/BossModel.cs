using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Il2CppDummyDll;
using MVC;
using Protocol.Boss;

namespace Gameplay.Boss.Model
{
	// Token: 0x02000B93 RID: 2963
	[Token(Token = "0x2000B93")]
	public class BossModel : AbstractModel
	{
		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06004857 RID: 18519 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EA7")]
		public Dictionary<long, BossInstance> Storage
		{
			[Token(Token = "0x6004857")]
			[Address(RVA = "0x96D6", Offset = "0x96D6", VA = "0x96D6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06004858 RID: 18520 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004859 RID: 18521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EA8")]
		public MonsterData CurrentMinion
		{
			[Token(Token = "0x6004858")]
			[Address(RVA = "0x96D7", Offset = "0x96D7", VA = "0x96D7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004859")]
			[Address(RVA = "0x96D8", Offset = "0x96D8", VA = "0x96D8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x0600485A RID: 18522 RVA: 0x0000D620 File Offset: 0x0000B820
		[Token(Token = "0x17000EA9")]
		public int TotalNotificationNum
		{
			[Token(Token = "0x600485A")]
			[Address(RVA = "0x96D9", Offset = "0x96D9", VA = "0x96D9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x0600485B RID: 18523 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600485C RID: 18524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EAA")]
		public IGame Game
		{
			[Token(Token = "0x600485B")]
			[Address(RVA = "0x96DA", Offset = "0x96DA", VA = "0x96DA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600485C")]
			[Address(RVA = "0x96DB", Offset = "0x96DB", VA = "0x96DB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600485D RID: 18525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600485D")]
		[Address(RVA = "0x96DC", Offset = "0x96DC", VA = "0x96DC")]
		public BossModel(IGame game, UserData user)
		{
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x0600485E RID: 18526 RVA: 0x0000D638 File Offset: 0x0000B838
		// (set) Token: 0x0600485F RID: 18527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EAB")]
		public long CurrentInstanceId
		{
			[Token(Token = "0x600485E")]
			[Address(RVA = "0x96DD", Offset = "0x96DD", VA = "0x96DD")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600485F")]
			[Address(RVA = "0x96DE", Offset = "0x96DE", VA = "0x96DE")]
			set
			{
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06004860 RID: 18528 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004861 RID: 18529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EAC")]
		public BossCreateRequestData CurrentCreateRequest
		{
			[Token(Token = "0x6004860")]
			[Address(RVA = "0x96DF", Offset = "0x96DF", VA = "0x96DF")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004861")]
			[Address(RVA = "0x96E0", Offset = "0x96E0", VA = "0x96E0")]
			set
			{
			}
		}

		// Token: 0x06004862 RID: 18530 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004862")]
		[Address(RVA = "0x96E1", Offset = "0x96E1", VA = "0x96E1")]
		public BossInstance AddBoss(InstanceInfo instanceInfo)
		{
			return null;
		}

		// Token: 0x06004863 RID: 18531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004863")]
		[Address(RVA = "0x96E2", Offset = "0x96E2", VA = "0x96E2")]
		public void RemoveBoss(BossInstance instance)
		{
		}

		// Token: 0x06004864 RID: 18532 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004864")]
		[Address(RVA = "0x96E3", Offset = "0x96E3", VA = "0x96E3")]
		public BossInstance GetBoss(long id)
		{
			return null;
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06004865 RID: 18533 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EAD")]
		public BossInstance CurrentInstance
		{
			[Token(Token = "0x6004865")]
			[Address(RVA = "0x96E4", Offset = "0x96E4", VA = "0x96E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x040027A6 RID: 10150
		[Token(Token = "0x40027A6")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<long, BossInstance> _storage;

		// Token: 0x040027A9 RID: 10153
		[Token(Token = "0x40027A9")]
		[FieldOffset(Offset = "0x18")]
		private long _currentInstanceId;

		// Token: 0x040027AA RID: 10154
		[Token(Token = "0x40027AA")]
		[FieldOffset(Offset = "0x20")]
		private BossCreateRequestData _currentCreateRequest;
	}
}
