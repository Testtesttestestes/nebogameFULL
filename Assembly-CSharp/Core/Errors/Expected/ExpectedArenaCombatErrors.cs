using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200103F RID: 4159
	[Token(Token = "0x200103F")]
	public class ExpectedArenaCombatErrors : ExpectedCombatErrors
	{
		// Token: 0x060061F9 RID: 25081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061F9")]
		[Address(RVA = "0xAE24", Offset = "0xAE24", VA = "0xAE24")]
		public ExpectedArenaCombatErrors()
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Errors_Expected_ExpectedArenaCombatErrors___ctor(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param3_00;
		  undefined4 uVar2;
		  int *param1_00;
		  uint *puVar3;
		  int param1_01;
		  int iVar4;
		  
		  param1_00 = (int *)0x0;
		  if (DAT_ram_00a5a356 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6905);
		    DAT_ram_00a5a356 = '\x01';
		  }
		  if (param2 == -1) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6905,1,0,1,0,0,0,0);
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
		          goto code_r0x8120a510;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Gameplay_Combat_ICombat_TypeInfo,3);
		code_r0x8120a510:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    uVar1 = 0;
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8120a58c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,System_IDisposable_TypeInfo,0);
		code_r0x8120a58c:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  }
		  return (uint)(param2 == -1);
		}
		*/

		}
	}
}
