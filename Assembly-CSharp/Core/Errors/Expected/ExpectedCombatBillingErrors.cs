using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200104D RID: 4173
	[Token(Token = "0x200104D")]
	public class ExpectedCombatBillingErrors : ExpectedBillingErrors
	{
		// Token: 0x0600621B RID: 25115 RVA: 0x00012420 File Offset: 0x00010620
		[Token(Token = "0x600621B")]
		[Address(RVA = "0xAE46", Offset = "0xAE46", VA = "0xAE46", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600621C RID: 25116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600621C")]
		[Address(RVA = "0xAE47", Offset = "0xAE47", VA = "0xAE47")]
		public ExpectedCombatBillingErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedCombatBillingErrors___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  uint *puVar4;
		  int param1_01;
		  int iVar5;
		  int iVar6;
		  int local_4;
		  
		  param1_00 = (int *)0x0;
		  if (DAT_ram_00a5a369 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6906);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6912);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6913);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6909);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6910);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6907);
		    DAT_ram_00a5a369 = '\x01';
		  }
		  iVar6 = Gameplay_Combat_ICombat_TypeInfo;
		  if (param2 < -1099) {
		    if (param2 == -10000) {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = func_ii_7508(StringLiteral_6913,1,0,1,0,0,0,0);
		      goto code_r0x8120c9e5;
		    }
		    if (param2 == -9999) {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = func_ii_7508(StringLiteral_6910,1,0,1,0,0,0,0);
		      goto code_r0x8120c9e5;
		    }
		    if (param2 == -0x44c) {
		      iVar5 = 0;
		      param1_01 = param1[2];
		      if ((param1_01 != 0) &&
		         (iVar5 = func_ii_1082(param1_01,Gameplay_Combat_ICombat_TypeInfo), iVar5 == 0)) {
		        System_Activator__CreateInstance(param1_01,iVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                        (param1,iVar5,*(undefined4 *)(*param1 + 0xec));
		      goto code_r0x8120c9e5;
		    }
		  }
		  else {
		    if (param2 == -1000) {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = func_ii_7508(StringLiteral_6909,1,0,1,0,0,0,0);
		      goto code_r0x8120c9e5;
		    }
		    if (param2 == -200) {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = func_ii_7508(StringLiteral_6907,1,0,1,0,0,0,0);
		      iVar6 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		      UI_Windows_Alert__Show(iVar6,0);
		      *(undefined4 *)(iVar6 + 0x1c) = uVar2;
		      UI_Windows_UnityInstantiator___ctor(iVar6,0);
		      goto code_r0x8120c9e5;
		    }
		    if (param2 == -100) {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = func_ii_7508(StringLiteral_6906,1,0,1,0,0,0,0);
		      goto code_r0x8120c9e5;
		    }
		  }
		  local_4 = param2;
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  uVar2 = func_ii_4419(StringLiteral_6912,uVar2,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(uVar2,1,0,1,0,0,0,0);
		code_r0x8120c9e5:
		  uVar3 = System_Uri___ctor(0);
		  uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		  Core_Application_App__get_ToastController(uVar3,2,uVar2,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  func_ii_7830(uVar2,0);
		  iVar6 = Gameplay_Combat_ICombat_TypeInfo;
		  iVar5 = param1[2];
		  if ((iVar5 != 0) &&
		     (param1_00 = (int *)func_ii_1082(iVar5,Gameplay_Combat_ICombat_TypeInfo),
		     param1_00 == (int *)0x0)) {
		    System_Activator__CreateInstance(iVar5,iVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x8120caa9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Gameplay_Combat_ICombat_TypeInfo,3);
		code_r0x8120caa9:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		  uVar1 = 0;
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8120cb25;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,System_IDisposable_TypeInfo,0);
		code_r0x8120cb25:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		  return 1;
		}
		*/

		}
	}
}
