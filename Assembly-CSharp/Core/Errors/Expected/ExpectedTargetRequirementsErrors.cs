using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001076 RID: 4214
	[Token(Token = "0x2001076")]
	public class ExpectedTargetRequirementsErrors : ExpectedRequirementsErrors
	{
		// Token: 0x0600627F RID: 25215 RVA: 0x00012768 File Offset: 0x00010968
		[Token(Token = "0x600627F")]
		[Address(RVA = "0xAEA5", Offset = "0xAEA5", VA = "0xAEA5", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006280 RID: 25216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006280")]
		[Address(RVA = "0xAEA6", Offset = "0xAEA6", VA = "0xAEA6")]
		public ExpectedTargetRequirementsErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedTargetRequirementsErrors___ctor
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param3_00;
		  undefined4 uVar2;
		  int *param1_00;
		  uint *puVar3;
		  int param1_01;
		  int iVar4;
		  
		  param1_00 = (int *)0x0;
		  if (DAT_ram_00a5a395 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6911);
		    DAT_ram_00a5a395 = '\x01';
		  }
		  Core_Errors_Expected_ExpectedCombatBillingErrors___ctor(param1,param2,param2);
		  if (param2 == -0x5a) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = func_ii_7508(StringLiteral_6911,1,0,1,0,0,0,0);
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    Core_Application_App__get_ToastController(uVar2,2,param3_00,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(param3_00,0);
		    iVar4 = Gameplay_Combat_ICombat_TypeInfo;
		    param1_01 = *(int *)(param1 + 8);
		    if ((param1_01 != 0) &&
		       (param1_00 = (int *)func_ii_1082(param1_01,Gameplay_Combat_ICombat_TypeInfo),
		       param1_00 == (int *)0x0)) {
		      System_Activator__CreateInstance(param1_01,iVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd8);
		          goto code_r0x81211416;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Gameplay_Combat_ICombat_TypeInfo,3);
		code_r0x81211416:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    uVar1 = 0;
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81211492;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,System_IDisposable_TypeInfo,0);
		code_r0x81211492:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  }
		  return 1;
		}
		*/

		}
	}
}
