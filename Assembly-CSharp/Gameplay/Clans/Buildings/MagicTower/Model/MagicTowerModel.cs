using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Clans.Model;
using Gameplay.Discounts.Model;
using Gameplay.Isles.Clan;
using Gameplay.School.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Common;
using Protocol.Dic;
using Protocol.School;

namespace Gameplay.Clans.Buildings.MagicTower.Model
{
	// Token: 0x02000AB6 RID: 2742
	[Token(Token = "0x2000AB6")]
	public class MagicTowerModel : AbstractModel
	{
		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06004228 RID: 16936 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004229 RID: 16937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D09")]
		[CanBeNull]
		public IDiscountHandler DiscountHandler
		{
			[Token(Token = "0x6004228")]
			[Address(RVA = "0x90DC", Offset = "0x90DC", VA = "0x90DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004229")]
			[Address(RVA = "0x90DD", Offset = "0x90DD", VA = "0x90DD")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x0600422A RID: 16938 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D0A")]
		public ClanData ClanData
		{
			[Token(Token = "0x600422A")]
			[Address(RVA = "0x90DE", Offset = "0x90DE", VA = "0x90DE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x0600422B RID: 16939 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600422C RID: 16940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D0B")]
		public Dictionary<uint, ClanSchoolSpellData> SpellsById
		{
			[Token(Token = "0x600422B")]
			[Address(RVA = "0x90DF", Offset = "0x90DF", VA = "0x90DF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600422C")]
			[Address(RVA = "0x90E0", Offset = "0x90E0", VA = "0x90E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600422D")]
		[Address(RVA = "0x90E1", Offset = "0x90E1", VA = "0x90E1", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600422E RID: 16942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600422E")]
		[Address(RVA = "0x90E2", Offset = "0x90E2", VA = "0x90E2")]
		public MagicTowerModel(UserData user, ClanIsle clanIsle)
		{
		}

		// Token: 0x0600422F RID: 16943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600422F")]
		[Address(RVA = "0x90E3", Offset = "0x90E3", VA = "0x90E3")]
		public void PopulateSpells(ProtoGetSchoolInfoAns msg)
		{
		}

		// Token: 0x06004230 RID: 16944 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004230")]
		[Address(RVA = "0x90E4", Offset = "0x90E4", VA = "0x90E4")]
		public ResourceSet GetCancelImproveMoneyBack(SchoolSpellData spell)
		{
			return null;
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06004231 RID: 16945 RVA: 0x0000CA80 File Offset: 0x0000AC80
		[Token(Token = "0x17000D0C")]
		public double LearnCancelRecoilCoeff
		{
			[Token(Token = "0x6004231")]
			[Address(RVA = "0x90E5", Offset = "0x90E5", VA = "0x90E5")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x04002486 RID: 9350
		[Token(Token = "0x4002486")]
		[FieldOffset(Offset = "0xC")]
		public readonly Dictionaries Dict;

		// Token: 0x04002487 RID: 9351
		[Token(Token = "0x4002487")]
		[FieldOffset(Offset = "0x10")]
		public readonly ClansModel ClansModel;

		// Token: 0x04002488 RID: 9352
		[Token(Token = "0x4002488")]
		[FieldOffset(Offset = "0x14")]
		public readonly ClanIsle ClanIsle;
	}
}
