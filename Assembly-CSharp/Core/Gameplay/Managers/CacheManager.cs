using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Cache;
using Core.Cache.User;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using UnityEngine;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001146 RID: 4422
	[Token(Token = "0x2001146")]
	public class CacheManager : IGameManager, IBaseManager
	{
		// Token: 0x060067FE RID: 26622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067FE")]
		[Address(RVA = "0xB32A", Offset = "0xB32A", VA = "0xB32A")]
		public CacheManager(IGame game)
		{
		}

		// Token: 0x14000268 RID: 616
		// (add) Token: 0x060067FF RID: 26623 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006800 RID: 26624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000268")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60067FF")]
			[Address(RVA = "0xB32B", Offset = "0xB32B", VA = "0xB32B", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006800")]
			[Address(RVA = "0xB32C", Offset = "0xB32C", VA = "0xB32C", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000269 RID: 617
		// (add) Token: 0x06006801 RID: 26625 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006802 RID: 26626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000269")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006801")]
			[Address(RVA = "0xB32D", Offset = "0xB32D", VA = "0xB32D", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006802")]
			[Address(RVA = "0xB32E", Offset = "0xB32E", VA = "0xB32E", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x06006803 RID: 26627 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006804 RID: 26628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700154D")]
		public IUserCache UsersBasic
		{
			[Token(Token = "0x6006803")]
			[Address(RVA = "0xB32F", Offset = "0xB32F", VA = "0xB32F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006804")]
			[Address(RVA = "0xB330", Offset = "0xB330", VA = "0xB330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x06006805 RID: 26629 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006806 RID: 26630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700154E")]
		public ICache<ulong, UserData> Users
		{
			[Token(Token = "0x6006805")]
			[Address(RVA = "0xB331", Offset = "0xB331", VA = "0xB331")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006806")]
			[Address(RVA = "0xB332", Offset = "0xB332", VA = "0xB332")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06006807 RID: 26631 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006808 RID: 26632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700154F")]
		public ICache<ulong, ClanShortInfo> Clans
		{
			[Token(Token = "0x6006807")]
			[Address(RVA = "0xB333", Offset = "0xB333", VA = "0xB333")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006808")]
			[Address(RVA = "0xB334", Offset = "0xB334", VA = "0xB334")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x06006809 RID: 26633 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600680A RID: 26634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001550")]
		public ICache<AssetDic, AudioClip> AudioClipCache
		{
			[Token(Token = "0x6006809")]
			[Address(RVA = "0xB335", Offset = "0xB335", VA = "0xB335")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600680A")]
			[Address(RVA = "0xB336", Offset = "0xB336", VA = "0xB336")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600680B RID: 26635 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600680B")]
		[Address(RVA = "0xB337", Offset = "0xB337", VA = "0xB337")]
		public ICache<ulong, UserData> GetEndOfFrameCacheRequestAccumulator(ICache<ulong, UserData> cache)
		{
			return null;
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x0600680C RID: 26636 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001551")]
		public ArtifactCache Artifacts
		{
			[Token(Token = "0x600680C")]
			[Address(RVA = "0xB338", Offset = "0xB338", VA = "0xB338")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600680D RID: 26637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600680D")]
		[Address(RVA = "0xB339", Offset = "0xB339", VA = "0xB339", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x0600680E RID: 26638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600680E")]
		[Address(RVA = "0xB33A", Offset = "0xB33A", VA = "0xB33A", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x0600680F RID: 26639 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001552")]
		public string Name
		{
			[Token(Token = "0x600680F")]
			[Address(RVA = "0xB33B", Offset = "0xB33B", VA = "0xB33B", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400376B RID: 14187
		[Token(Token = "0x400376B")]
		[FieldOffset(Offset = "0x8")]
		private IGame _game;

		// Token: 0x04003772 RID: 14194
		[Token(Token = "0x4003772")]
		[FieldOffset(Offset = "0x24")]
		private Dictionary<ICache<ulong, UserData>, EndOfFrameAccumulativeCacheDataRequest<ulong, UserData>> _currentEndOfFrameCacheDataRequests;

		// Token: 0x04003773 RID: 14195
		[Token(Token = "0x4003773")]
		[FieldOffset(Offset = "0x28")]
		private ArtifactCache _artifactCache;
	}
}
