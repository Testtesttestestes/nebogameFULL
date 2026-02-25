using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Boss;

namespace Gameplay.Boss.Model
{
	// Token: 0x02000B88 RID: 2952
	[Token(Token = "0x2000B88")]
	public class BossCaptainRatingData
	{
		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x060047BB RID: 18363 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047BC RID: 18364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E59")]
		public CaptainRating RawCaptainRating
		{
			[Token(Token = "0x60047BB")]
			[Address(RVA = "0x9646", Offset = "0x9646", VA = "0x9646")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047BC")]
			[Address(RVA = "0x9647", Offset = "0x9647", VA = "0x9647")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x060047BD RID: 18365 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047BE RID: 18366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E5A")]
		public List<ulong> MyTeamIds
		{
			[Token(Token = "0x60047BD")]
			[Address(RVA = "0x9648", Offset = "0x9648", VA = "0x9648")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047BE")]
			[Address(RVA = "0x9649", Offset = "0x9649", VA = "0x9649")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x060047BF RID: 18367 RVA: 0x0000D290 File Offset: 0x0000B490
		[Token(Token = "0x17000E5B")]
		public ulong Score
		{
			[Token(Token = "0x60047BF")]
			[Address(RVA = "0x964A", Offset = "0x964A", VA = "0x964A")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x060047C0 RID: 18368 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
		[Token(Token = "0x17000E5C")]
		public ulong Place
		{
			[Token(Token = "0x60047C0")]
			[Address(RVA = "0x964B", Offset = "0x964B", VA = "0x964B")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x060047C1 RID: 18369 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		[Token(Token = "0x17000E5D")]
		public ulong CaptainId
		{
			[Token(Token = "0x60047C1")]
			[Address(RVA = "0x964C", Offset = "0x964C", VA = "0x964C")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x060047C2 RID: 18370 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		[Token(Token = "0x17000E5E")]
		public bool IsMyCaptain
		{
			[Token(Token = "0x60047C2")]
			[Address(RVA = "0x964D", Offset = "0x964D", VA = "0x964D")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x060047C3 RID: 18371 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		// (set) Token: 0x060047C4 RID: 18372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E5F")]
		public bool IsAlive
		{
			[Token(Token = "0x60047C3")]
			[Address(RVA = "0x964E", Offset = "0x964E", VA = "0x964E")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60047C4")]
			[Address(RVA = "0x964F", Offset = "0x964F", VA = "0x964F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x060047C5 RID: 18373 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047C6 RID: 18374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E60")]
		[CanBeNull]
		public UserData CaptainUserData
		{
			[Token(Token = "0x60047C5")]
			[Address(RVA = "0x9650", Offset = "0x9650", VA = "0x9650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047C6")]
			[Address(RVA = "0x9651", Offset = "0x9651", VA = "0x9651")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140001C8 RID: 456
		// (add) Token: 0x060047C7 RID: 18375 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060047C8 RID: 18376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001C8")]
		public event Action CaptainUserDataChangedEvent
		{
			[Token(Token = "0x60047C7")]
			[Address(RVA = "0x9652", Offset = "0x9652", VA = "0x9652")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60047C8")]
			[Address(RVA = "0x9653", Offset = "0x9653", VA = "0x9653")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047C9")]
		[Address(RVA = "0x9654", Offset = "0x9654", VA = "0x9654")]
		public BossCaptainRatingData(CaptainRating captainRating, List<ulong> myTeamIds, bool isAlive)
		{
		}

		// Token: 0x060047CA RID: 18378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047CA")]
		[Address(RVA = "0x9655", Offset = "0x9655", VA = "0x9655")]
		private void ResultCallback(long operationIndex, UserData[] data)
		{
		}
	}
}
