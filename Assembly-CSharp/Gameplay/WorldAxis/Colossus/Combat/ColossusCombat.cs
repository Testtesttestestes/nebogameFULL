using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.Combat;
using Gameplay.VortexCombat.Control;
using Gameplay.WorldAxis.Colossus.Combat.Control;
using Gameplay.WorldAxis.Colossus.Combat.Model;
using Gameplay.WorldAxis.Colossus.Combat.View;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Dic;
using Utils;

namespace Gameplay.WorldAxis.Colossus.Combat
{
	// Token: 0x02000334 RID: 820
	[Token(Token = "0x2000334")]
	public class ColossusCombat : AbstractCombat<ColossusCombatModel, ColossusCombatEvents, ColossusCombatController, ColossusCombatViewMediator, ColossusCombatView>
	{
		// Token: 0x060012E3 RID: 4835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E3")]
		[Address(RVA = "0x64DD", Offset = "0x64DD", VA = "0x64DD", Slot = "11")]
		public override void Dispose()
		{
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E4")]
		[Address(RVA = "0x64DE", Offset = "0x64DE", VA = "0x64DE")]
		public ColossusCombat(ColossusCombat.LaunchParams launchLaunchParams, IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime)
		{
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E5")]
		[Address(RVA = "0x64DF", Offset = "0x64DF", VA = "0x64DF", Slot = "13")]
		protected override void InitMVC()
		{
		}

		// Token: 0x04000A27 RID: 2599
		[Token(Token = "0x4000A27")]
		[FieldOffset(Offset = "0x28")]
		private VortexCombatController _vortexController;

		// Token: 0x04000A28 RID: 2600
		[Token(Token = "0x4000A28")]
		[FieldOffset(Offset = "0x2C")]
		private VortexCombatViewMediator _vortexMediator;

		// Token: 0x04000A29 RID: 2601
		[Token(Token = "0x4000A29")]
		[FieldOffset(Offset = "0x30")]
		private ColossusCombat.LaunchParams _launchParams;

		// Token: 0x02000335 RID: 821
		[Token(Token = "0x2000335")]
		public class LaunchParams : IDisposable
		{
			// Token: 0x170002EB RID: 747
			// (get) Token: 0x060012E6 RID: 4838 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060012E7 RID: 4839 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002EB")]
			public IColossusCombatRewards ColossusCombatRewards
			{
				[Token(Token = "0x60012E6")]
				[Address(RVA = "0x64E0", Offset = "0x64E0", VA = "0x64E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60012E7")]
				[Address(RVA = "0x64E1", Offset = "0x64E1", VA = "0x64E1")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170002EC RID: 748
			// (get) Token: 0x060012E8 RID: 4840 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060012E9 RID: 4841 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002EC")]
			public IColossusCombatLauncher Launcher
			{
				[Token(Token = "0x60012E8")]
				[Address(RVA = "0x64E2", Offset = "0x64E2", VA = "0x64E2")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60012E9")]
				[Address(RVA = "0x64E3", Offset = "0x64E3", VA = "0x64E3")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060012EA RID: 4842 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012EA")]
			[Address(RVA = "0x64E4", Offset = "0x64E4", VA = "0x64E4")]
			public LaunchParams(IColossusCombatLauncher launcher, IColossusCombatRewards rewards)
			{
			}

			// Token: 0x060012EB RID: 4843 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012EB")]
			[Address(RVA = "0x64E5", Offset = "0x64E5", VA = "0x64E5", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x04000A2C RID: 2604
			[Token(Token = "0x4000A2C")]
			[FieldOffset(Offset = "0x10")]
			[CanBeNull]
			public ColossusDic Colossus;
		}
	}
}
