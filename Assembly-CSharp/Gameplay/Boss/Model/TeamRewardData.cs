using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Boss;

namespace Gameplay.Boss.Model
{
	// Token: 0x02000B9A RID: 2970
	[Token(Token = "0x2000B9A")]
	public class TeamRewardData
	{
		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x060048A6 RID: 18598 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060048A7 RID: 18599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ECD")]
		public GetCaptainTeamListAns.Types.TeamRewardInfo RawTeamRewardInfo
		{
			[Token(Token = "0x60048A6")]
			[Address(RVA = "0x9722", Offset = "0x9722", VA = "0x9722")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60048A7")]
			[Address(RVA = "0x9723", Offset = "0x9723", VA = "0x9723")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x060048A8 RID: 18600 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060048A9 RID: 18601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ECE")]
		public List<TeamRewardData.TeamMemberData> TeamMembers
		{
			[Token(Token = "0x60048A8")]
			[Address(RVA = "0x9724", Offset = "0x9724", VA = "0x9724")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60048A9")]
			[Address(RVA = "0x9725", Offset = "0x9725", VA = "0x9725")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x060048AA RID: 18602 RVA: 0x0000D7A0 File Offset: 0x0000B9A0
		// (set) Token: 0x060048AB RID: 18603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ECF")]
		public bool IsAlive
		{
			[Token(Token = "0x60048AA")]
			[Address(RVA = "0x9726", Offset = "0x9726", VA = "0x9726")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60048AB")]
			[Address(RVA = "0x9727", Offset = "0x9727", VA = "0x9727")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x060048AC RID: 18604 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
		[Token(Token = "0x17000ED0")]
		public ulong TeamId
		{
			[Token(Token = "0x60048AC")]
			[Address(RVA = "0x9728", Offset = "0x9728", VA = "0x9728")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x060048AD RID: 18605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048AD")]
		[Address(RVA = "0x9729", Offset = "0x9729", VA = "0x9729")]
		public TeamRewardData(GetCaptainTeamListAns.Types.TeamRewardInfo teamRewardInfo, bool isAlive)
		{
		}

		// Token: 0x02000B9B RID: 2971
		[Token(Token = "0x2000B9B")]
		public class TeamMemberData
		{
			// Token: 0x17000ED1 RID: 3793
			// (get) Token: 0x060048AE RID: 18606 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
			// (set) Token: 0x060048AF RID: 18607 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ED1")]
			public ulong UserId
			{
				[Token(Token = "0x60048AE")]
				[Address(RVA = "0x972A", Offset = "0x972A", VA = "0x972A")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
				[Token(Token = "0x60048AF")]
				[Address(RVA = "0x972B", Offset = "0x972B", VA = "0x972B")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x140001CB RID: 459
			// (add) Token: 0x060048B0 RID: 18608 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x060048B1 RID: 18609 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x140001CB")]
			public event Action UserDataChangedEvent
			{
				[Token(Token = "0x60048B0")]
				[Address(RVA = "0x972C", Offset = "0x972C", VA = "0x972C")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x60048B1")]
				[Address(RVA = "0x972D", Offset = "0x972D", VA = "0x972D")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x060048B2 RID: 18610 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60048B2")]
			[Address(RVA = "0x1B3D", Offset = "0x1B3D", VA = "0x1B3D")]
			public TeamMemberData(ulong userId)
			{
			}

			// Token: 0x060048B3 RID: 18611 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60048B3")]
			[Address(RVA = "0x972E", Offset = "0x972E", VA = "0x972E")]
			private void ResultCallback(long operationIndex, UserData[] data)
			{
			}

			// Token: 0x040027CE RID: 10190
			[Token(Token = "0x40027CE")]
			[FieldOffset(Offset = "0x14")]
			[CanBeNull]
			public UserData UserData;
		}
	}
}
