using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using Protocol.BlitzTournaments;
using UI.ToolTip;

namespace Gameplay.BlitzTournament.View
{
	// Token: 0x02000BCD RID: 3021
	[Token(Token = "0x2000BCD")]
	public class PlayerBattleView : PlayerBattleViewBase, IToolTipDataProvider
	{
		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06004A03 RID: 18947 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004A04 RID: 18948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EF7")]
		public FighterInfo Fighter
		{
			[Token(Token = "0x6004A03")]
			[Address(RVA = "0x986D", Offset = "0x986D", VA = "0x986D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A04")]
			[Address(RVA = "0x986E", Offset = "0x986E", VA = "0x986E")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06004A05 RID: 18949 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004A06 RID: 18950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EF8")]
		public UserData UserData
		{
			[Token(Token = "0x6004A05")]
			[Address(RVA = "0x986F", Offset = "0x986F", VA = "0x986F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A06")]
			[Address(RVA = "0x9870", Offset = "0x9870", VA = "0x9870")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06004A07 RID: 18951 RVA: 0x0000DA28 File Offset: 0x0000BC28
		[Token(Token = "0x17000EF9")]
		protected override uint _totalHealth
		{
			[Token(Token = "0x6004A07")]
			[Address(RVA = "0x9871", Offset = "0x9871", VA = "0x9871", Slot = "5")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A08")]
		[Address(RVA = "0x9872", Offset = "0x9872", VA = "0x9872")]
		public void Init(FighterInfo fighter)
		{
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004A09")]
		[Address(RVA = "0x9873", Offset = "0x9873", VA = "0x9873", Slot = "8")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A0A")]
		[Address(RVA = "0x9874", Offset = "0x9874", VA = "0x9874")]
		public PlayerBattleView()
		{
		}
	}
}
