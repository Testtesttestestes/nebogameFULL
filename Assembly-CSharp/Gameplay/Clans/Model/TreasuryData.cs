using System;
using System.Runtime.CompilerServices;
using Core.Data.Balance;
using Il2CppDummyDll;
using Protocol.Clans;
using Protocol.Common;

namespace Gameplay.Clans.Model
{
	// Token: 0x02000A8B RID: 2699
	[Token(Token = "0x2000A8B")]
	public class TreasuryData : IBalanceSource
	{
		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x060040A2 RID: 16546 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060040A3 RID: 16547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC1")]
		public ResourceSet Money
		{
			[Token(Token = "0x60040A2")]
			[Address(RVA = "0x8F59", Offset = "0x8F59", VA = "0x8F59", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60040A3")]
			[Address(RVA = "0x8F5A", Offset = "0x8F5A", VA = "0x8F5A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x060040A4 RID: 16548 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060040A5 RID: 16549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC2")]
		public ResourceSet CreditDebt
		{
			[Token(Token = "0x60040A4")]
			[Address(RVA = "0x8F5B", Offset = "0x8F5B", VA = "0x8F5B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60040A5")]
			[Address(RVA = "0x8F5C", Offset = "0x8F5C", VA = "0x8F5C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1400019A RID: 410
		// (add) Token: 0x060040A6 RID: 16550 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060040A7 RID: 16551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400019A")]
		public event IBalanceSource.BalanceChangedDelegate BalanceChangedEvent
		{
			[Token(Token = "0x60040A6")]
			[Address(RVA = "0x8F5D", Offset = "0x8F5D", VA = "0x8F5D", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60040A7")]
			[Address(RVA = "0x8F5E", Offset = "0x8F5E", VA = "0x8F5E", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040A8")]
		[Address(RVA = "0x8F5F", Offset = "0x8F5F", VA = "0x8F5F")]
		public TreasuryData(ProtoGetClanTreasuryAns treasury)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Model_TreasuryData___ctor(int param1,int param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 8) = *(undefined4 *)(param2 + 0xc);
		  *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param2 + 0x10);
		  return;
		}
		*/

		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040A9")]
		[Address(RVA = "0x8F60", Offset = "0x8F60", VA = "0x8F60")]
		public void UpdateTreasury(ProtoGetClanTreasuryAns treasury)
		{
		/* --- GHIDRA: UpdateTreasury ---
		void Gameplay_Clans_Model_TreasuryData__UpdateTreasury(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57744 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a57744 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060040AA RID: 16554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040AA")]
		[Address(RVA = "0x8F61", Offset = "0x8F61", VA = "0x8F61")]
		public void RepayCreditDebt()
		{
		/* --- GHIDRA: RepayCreditDebt ---
		void Gameplay_Clans_Model_TreasuryData__RepayCreditDebt(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  
		  uVar2 = *(undefined4 *)(param1 + 8);
		  param2_00 = *(undefined4 *)(param2 + 0xc);
		  *(undefined4 *)(param1 + 8) = param2_00;
		  uVar2 = Core_Extensions_Dict_ResourceSetExt__Sub(uVar2,param2_00,0);
		  iVar1 = Core_Extensions_Dict_ResourceSetExt__GetDelta(uVar2,0);
		  if ((iVar1 == 0) && (iVar1 = *(int *)(param1 + 0x10), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 8),uVar2,
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060040AB RID: 16555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040AB")]
		[Address(RVA = "0x8F62", Offset = "0x8F62", VA = "0x8F62")]
		public void ChangeTreasury(ProtoTreasuryChangedEvt msg)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CreditDebt ---
		void Gameplay_Clans_Model_TreasuryData__set_CreditDebt
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57742 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    DAT_ram_00a57742 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 ||
		         (Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x10,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance
		            (param1_01,Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_BalanceChangedEvent ---
		void Gameplay_Clans_Model_TreasuryData__add_BalanceChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57743 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    DAT_ram_00a57743 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x10,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance
		            (param1_01,Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
