using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers;
using Il2CppDummyDll;
using MVC;
using Protocol.ClanWar;
using Protocol.Dic;
using Utils;

namespace Gameplay.Clans.ClanWars.Model
{
	// Token: 0x02000AA6 RID: 2726
	[Token(Token = "0x2000AA6")]
	public class ClanWarsModel : AbstractModel
	{
		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x060041AD RID: 16813 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CEC")]
		public Dictionaries Dict
		{
			[Token(Token = "0x60041AD")]
			[Address(RVA = "0x9061", Offset = "0x9061", VA = "0x9061")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x060041AE RID: 16814 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060041AF RID: 16815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CED")]
		public ClanWarInfo WarInfo
		{
			[Token(Token = "0x60041AE")]
			[Address(RVA = "0x9062", Offset = "0x9062", VA = "0x9062")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041AF")]
			[Address(RVA = "0x9063", Offset = "0x9063", VA = "0x9063")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x060041B0 RID: 16816 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060041B1 RID: 16817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEE")]
		public BackTime WarStateBacktime
		{
			[Token(Token = "0x60041B0")]
			[Address(RVA = "0x9064", Offset = "0x9064", VA = "0x9064")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041B1")]
			[Address(RVA = "0x9065", Offset = "0x9065", VA = "0x9065")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x060041B2 RID: 16818 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060041B3 RID: 16819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEF")]
		public BackTime CurrentSeasonBacktime
		{
			[Token(Token = "0x60041B2")]
			[Address(RVA = "0x9066", Offset = "0x9066", VA = "0x9066")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041B3")]
			[Address(RVA = "0x9067", Offset = "0x9067", VA = "0x9067")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x060041B4 RID: 16820 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060041B5 RID: 16821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF0")]
		public BackTime NextSeasonBacktime
		{
			[Token(Token = "0x60041B4")]
			[Address(RVA = "0x9068", Offset = "0x9068", VA = "0x9068")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041B5")]
			[Address(RVA = "0x9069", Offset = "0x9069", VA = "0x9069")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x060041B6 RID: 16822 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060041B7 RID: 16823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF1")]
		public BackTime AccelerationCooldown
		{
			[Token(Token = "0x60041B6")]
			[Address(RVA = "0x906A", Offset = "0x906A", VA = "0x906A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041B7")]
			[Address(RVA = "0x906B", Offset = "0x906B", VA = "0x906B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x060041B8 RID: 16824 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
		// (set) Token: 0x060041B9 RID: 16825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF2")]
		public uint CurrentSeasonId
		{
			[Token(Token = "0x60041B8")]
			[Address(RVA = "0x906C", Offset = "0x906C", VA = "0x906C")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60041B9")]
			[Address(RVA = "0x906D", Offset = "0x906D", VA = "0x906D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x060041BA RID: 16826 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CF3")]
		public SeasonLeagueDic CurrenSeasonLeagueDic
		{
			[Token(Token = "0x60041BA")]
			[Address(RVA = "0x906E", Offset = "0x906E", VA = "0x906E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x060041BB RID: 16827 RVA: 0x0000CA08 File Offset: 0x0000AC08
		[Token(Token = "0x17000CF4")]
		public ulong EnemyClanId
		{
			[Token(Token = "0x60041BB")]
			[Address(RVA = "0x906F", Offset = "0x906F", VA = "0x906F")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x060041BC RID: 16828 RVA: 0x0000CA20 File Offset: 0x0000AC20
		[Token(Token = "0x17000CF5")]
		public bool CanAccelerate
		{
			[Token(Token = "0x60041BC")]
			[Address(RVA = "0x9070", Offset = "0x9070", VA = "0x9070")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041BD")]
		[Address(RVA = "0x9071", Offset = "0x9071", VA = "0x9071")]
		public ClanWarsModel(UserData user)
		{
		}

		// Token: 0x060041BE RID: 16830 RVA: 0x0000CA38 File Offset: 0x0000AC38
		[Token(Token = "0x60041BE")]
		[Address(RVA = "0x9072", Offset = "0x9072", VA = "0x9072")]
		public bool TryGetActiveWar(out ProtoGetActiveWarInfoAns.Types.ActiveWarInfo activeWar)
		{
			return default(bool);
		}

		// Token: 0x060041BF RID: 16831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041BF")]
		[Address(RVA = "0x9073", Offset = "0x9073", VA = "0x9073")]
		public void UpdateActiveWar(ProtoGetActiveWarInfoAns.Types.ActiveWarInfo activeWarInfo)
		{
		}

		// Token: 0x060041C0 RID: 16832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C0")]
		[Address(RVA = "0x9074", Offset = "0x9074", VA = "0x9074")]
		public void PopulateSeasonInfo(ProtoGetCurrentSeasonInfoAns info)
		{
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C1")]
		[Address(RVA = "0x9075", Offset = "0x9075", VA = "0x9075")]
		public void HandleSeasonStarted(ClanWarSeasonInfo seasonInfo)
		{
		}

		// Token: 0x0400244B RID: 9291
		[Token(Token = "0x400244B")]
		[FieldOffset(Offset = "0xC")]
		private DictManager _dictManager;

		// Token: 0x0400244C RID: 9292
		[Token(Token = "0x400244C")]
		[FieldOffset(Offset = "0x10")]
		private ProtoGetActiveWarInfoAns.Types.ActiveWarInfo _activeWarInfo;
	}
}
