using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Combat.Model;
using Gameplay.VortexCombat.Model;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Common;
using Utils;

namespace Gameplay.WorldAxis.Colossus.Combat.Model
{
	// Token: 0x0200033A RID: 826
	[Token(Token = "0x200033A")]
	public class ColossusCombatModel : VortexCombatModel
	{
		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x00004AA0 File Offset: 0x00002CA0
		[Token(Token = "0x170002F2")]
		public override CombatTypes CombatType
		{
			[Token(Token = "0x6001307")]
			[Address(RVA = "0x64FD", Offset = "0x64FD", VA = "0x64FD", Slot = "19")]
			get
			{
				return CombatTypes.UnknownCombat;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002F3")]
		public override long[] CombatParams
		{
			[Token(Token = "0x6001308")]
			[Address(RVA = "0x64FE", Offset = "0x64FE", VA = "0x64FE", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600130A RID: 4874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F4")]
		public ColossusCombat.LaunchParams Params
		{
			[Token(Token = "0x6001309")]
			[Address(RVA = "0x64FF", Offset = "0x64FF", VA = "0x64FF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600130A")]
			[Address(RVA = "0x6500", Offset = "0x6500", VA = "0x6500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600130B")]
		[Address(RVA = "0x6501", Offset = "0x6501", VA = "0x6501", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600130C")]
		[Address(RVA = "0x6502", Offset = "0x6502", VA = "0x6502")]
		public ColossusCombatModel(ColossusCombat.LaunchParams launchParams, CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600130D")]
		[Address(RVA = "0x6503", Offset = "0x6503", VA = "0x6503", Slot = "12")]
		public override ResourceSet GetNextCombatCost()
		{
			return null;
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600130E")]
		[Address(RVA = "0x6504", Offset = "0x6504", VA = "0x6504", Slot = "21")]
		public override void GetAwaitText(out string title, out string description)
		{
		}
	}
}
