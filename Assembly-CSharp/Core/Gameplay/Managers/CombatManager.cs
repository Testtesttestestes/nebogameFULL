using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Combat;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001160 RID: 4448
	[Token(Token = "0x2001160")]
	public class CombatManager : ICombatManager, IGameManager, IBaseManager
	{
		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x060068B2 RID: 26802 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700156C")]
		public string Name
		{
			[Token(Token = "0x60068B2")]
			[Address(RVA = "0xB3D8", Offset = "0xB3D8", VA = "0xB3D8", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000277 RID: 631
		// (add) Token: 0x060068B3 RID: 26803 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068B4 RID: 26804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000277")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60068B3")]
			[Address(RVA = "0xB3D9", Offset = "0xB3D9", VA = "0xB3D9", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068B4")]
			[Address(RVA = "0xB3DA", Offset = "0xB3DA", VA = "0xB3DA", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000278 RID: 632
		// (add) Token: 0x060068B5 RID: 26805 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068B6 RID: 26806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000278")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60068B5")]
			[Address(RVA = "0xB3DB", Offset = "0xB3DB", VA = "0xB3DB", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068B6")]
			[Address(RVA = "0xB3DC", Offset = "0xB3DC", VA = "0xB3DC", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060068B7 RID: 26807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068B7")]
		[Address(RVA = "0xB3DD", Offset = "0xB3DD", VA = "0xB3DD", Slot = "12")]
		public void Init()
		{
		}

		// Token: 0x060068B8 RID: 26808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068B8")]
		[Address(RVA = "0xB3DE", Offset = "0xB3DE", VA = "0xB3DE", Slot = "13")]
		public void Deinit()
		{
		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x060068B9 RID: 26809 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700156D")]
		public ICombat CurrentCombat
		{
			[Token(Token = "0x60068B9")]
			[Address(RVA = "0xB3DF", Offset = "0xB3DF", VA = "0xB3DF", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060068BA RID: 26810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068BA")]
		[Address(RVA = "0xB3E0", Offset = "0xB3E0", VA = "0xB3E0", Slot = "5")]
		public void Add(ICombat combat)
		{
		}

		// Token: 0x060068BB RID: 26811 RVA: 0x00013920 File Offset: 0x00011B20
		[Token(Token = "0x60068BB")]
		[Address(RVA = "0xB3E1", Offset = "0xB3E1", VA = "0xB3E1", Slot = "6")]
		public bool TryRemove(ICombat combat)
		{
			return default(bool);
		}

		// Token: 0x060068BC RID: 26812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068BC")]
		[Address(RVA = "0xB3E2", Offset = "0xB3E2", VA = "0xB3E2")]
		public void StopCombat(ICombat combat)
		{
		}

		// Token: 0x060068BD RID: 26813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068BD")]
		[Address(RVA = "0xB3E3", Offset = "0xB3E3", VA = "0xB3E3", Slot = "7")]
		public void StopCurrentCombat()
		{
		}

		// Token: 0x060068BE RID: 26814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068BE")]
		[Address(RVA = "0xB3E4", Offset = "0xB3E4", VA = "0xB3E4")]
		public CombatManager()
		{
		}

		// Token: 0x040037A7 RID: 14247
		[Token(Token = "0x40037A7")]
		[FieldOffset(Offset = "0x10")]
		public readonly LinkedList<ICombat> Combats;
	}
}
