using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Medals.Model;
using Il2CppDummyDll;
using Protocol.Main;
using Utils;

namespace Core.Data
{
	// Token: 0x020010BE RID: 4286
	[Token(Token = "0x20010BE")]
	public class MedalData
	{
		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x060063FD RID: 25597 RVA: 0x00012EA0 File Offset: 0x000110A0
		[Token(Token = "0x17001417")]
		public uint CurrentRank
		{
			[Token(Token = "0x60063FD")]
			[Address(RVA = "0xAFFA", Offset = "0xAFFA", VA = "0xAFFA")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x060063FE RID: 25598 RVA: 0x00012EB8 File Offset: 0x000110B8
		[Token(Token = "0x17001418")]
		public uint NextRank
		{
			[Token(Token = "0x60063FE")]
			[Address(RVA = "0xAFFB", Offset = "0xAFFB", VA = "0xAFFB")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x060063FF RID: 25599 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006400 RID: 25600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001419")]
		public MedalDicGroup MedalDicGroup
		{
			[Token(Token = "0x60063FF")]
			[Address(RVA = "0xAFFC", Offset = "0xAFFC", VA = "0xAFFC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006400")]
			[Address(RVA = "0xAFFD", Offset = "0xAFFD", VA = "0xAFFD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x06006401 RID: 25601 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006402 RID: 25602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700141A")]
		public SortedList<uint, MedalInfo> MedalInfos
		{
			[Token(Token = "0x6006401")]
			[Address(RVA = "0xAFFE", Offset = "0xAFFE", VA = "0xAFFE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006402")]
			[Address(RVA = "0xAFFF", Offset = "0xAFFF", VA = "0xAFFF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06006403 RID: 25603 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006404 RID: 25604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700141B")]
		public BackTime Backtime
		{
			[Token(Token = "0x6006403")]
			[Address(RVA = "0xB000", Offset = "0xB000", VA = "0xB000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006404")]
			[Address(RVA = "0xB001", Offset = "0xB001", VA = "0xB001")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006405 RID: 25605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006405")]
		[Address(RVA = "0xB002", Offset = "0xB002", VA = "0xB002")]
		private MedalData()
		{
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06006406 RID: 25606 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700141C")]
		public string FilterTitles
		{
			[Token(Token = "0x6006406")]
			[Address(RVA = "0xB003", Offset = "0xB003", VA = "0xB003")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006407 RID: 25607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006407")]
		[Address(RVA = "0x1C02", Offset = "0x1C02", VA = "0x1C02")]
		public void AddMedalInfo(MedalInfo medalInfo)
		{
		}

		// Token: 0x06006408 RID: 25608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006408")]
		[Address(RVA = "0xB004", Offset = "0xB004", VA = "0xB004")]
		private void ValidateState()
		{
		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06006409 RID: 25609 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700141D")]
		public MedalDicWrapper FirstRankMedal
		{
			[Token(Token = "0x6006409")]
			[Address(RVA = "0x223F", Offset = "0x223F", VA = "0x223F")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x0600640A RID: 25610 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700141E")]
		public MedalDicWrapper CurrentMedal
		{
			[Token(Token = "0x600640A")]
			[Address(RVA = "0xB005", Offset = "0xB005", VA = "0xB005")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x0600640B RID: 25611 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700141F")]
		public MedalDicWrapper NextMedal
		{
			[Token(Token = "0x600640B")]
			[Address(RVA = "0xB006", Offset = "0xB006", VA = "0xB006")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x0600640C RID: 25612 RVA: 0x00012ED0 File Offset: 0x000110D0
		[Token(Token = "0x17001420")]
		public uint SortOrder
		{
			[Token(Token = "0x600640C")]
			[Address(RVA = "0x1C2A", Offset = "0x1C2A", VA = "0x1C2A")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600640D RID: 25613 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600640D")]
		[Address(RVA = "0x1BF7", Offset = "0x1BF7", VA = "0x1BF7")]
		public static MedalData Create(MedalDicGroup medalDicGroup)
		{
			return null;
		}

		// Token: 0x0600640E RID: 25614 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600640E")]
		[Address(RVA = "0xB007", Offset = "0xB007", VA = "0xB007")]
		public static MedalData CreateEmpty()
		{
			return null;
		}

		// Token: 0x0600640F RID: 25615 RVA: 0x00012EE8 File Offset: 0x000110E8
		[Token(Token = "0x600640F")]
		[Address(RVA = "0x1C10", Offset = "0x1C10", VA = "0x1C10")]
		public bool IsMedalAchieved(uint rankId)
		{
			return default(bool);
		}

		// Token: 0x06006410 RID: 25616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006410")]
		[Address(RVA = "0x1C16", Offset = "0x1C16", VA = "0x1C16")]
		public void RemoveMedalById(uint medalId)
		{
		}

		// Token: 0x04003579 RID: 13689
		[Token(Token = "0x4003579")]
		[FieldOffset(Offset = "0x10")]
		private uint _currentRank;

		// Token: 0x0400357A RID: 13690
		[Token(Token = "0x400357A")]
		[FieldOffset(Offset = "0x14")]
		private uint _nextRank;

		// Token: 0x0400357B RID: 13691
		[Token(Token = "0x400357B")]
		[FieldOffset(Offset = "0x18")]
		private string _filterTitles;
	}
}
