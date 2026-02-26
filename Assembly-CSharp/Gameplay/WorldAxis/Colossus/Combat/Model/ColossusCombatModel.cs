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
		/* --- GHIDRA: Dispose ---
		void Gameplay_WorldAxis_Colossus_Combat_Model_ColossusCombatModel__Dispose
		               (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58c1b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_long___);
		    Mono_Security_ASN1__get_Item(&long___TypeInfo);
		    DAT_ram_00a58c1b = '\x01';
		  }
		  iVar2 = Method_System_Array_Empty_long___;
		  iVar1 = *(int *)(Method_System_Array_Empty_long___ + 0x1c);
		  if (iVar1 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_long___);
		    iVar1 = *(int *)(iVar2 + 0x1c);
		  }
		  iVar1 = *(int *)(iVar1 + 8);
		  if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		    iVar1 = func_ii_1079(iVar1);
		  }
		  if (*(int *)(iVar1 + 0x74) == 0) {
		    func_ii_306000(iVar1);
		  }
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x1c) + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  *(undefined4 *)(param1 + 100) = **(undefined4 **)(iVar2 + 0x5c);
		  Gameplay_VortexCombat_Model_VortexCombatModel__Dispose(param1,param3,param4,param5,param6,0);
		  *(int *)(param1 + 0x68) = param2;
		  if (*(int *)(param2 + 0x10) != 0) {
		    iVar2 = Mono_Security_ASN1Convert__ToOid(long___TypeInfo,1);
		    *(ulonglong *)(iVar2 + 0x10) =
		         (ulonglong)*(uint *)(*(int *)(*(int *)(param1 + 0x68) + 0x10) + 0xc);
		    *(int *)(param1 + 100) = iVar2;
		  }
		  return;
		}
		*/

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
		/* --- GHIDRA: GetNextCombatCost ---
		void Gameplay_WorldAxis_Colossus_Combat_Model_ColossusCombatModel__GetNextCombatCost
		               (undefined4 param1,undefined4 *param2,undefined4 *param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58c1c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2800);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2799);
		    DAT_ram_00a58c1c = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2800,1,0,1,0,0,0,0);
		  *param2 = uVar1;
		  uVar1 = func_ii_7508(StringLiteral_2799,1,0,1,0,0,0,0);
		  *param3 = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600130E")]
		[Address(RVA = "0x6504", Offset = "0x6504", VA = "0x6504", Slot = "21")]
		public override void GetAwaitText(out string title, out string description)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Params ---
		void Gameplay_WorldAxis_Colossus_Combat_Model_ColossusCombatModel__set_Params
		               (int param1,undefined4 param2)
		
		{
		  Gameplay_VortexCombat_Model_VortexCombatModel__get_CombatParams(param1,0);
		  *(undefined4 *)(param1 + 0x68) = 0;
		  return;
		}
		*/

}
