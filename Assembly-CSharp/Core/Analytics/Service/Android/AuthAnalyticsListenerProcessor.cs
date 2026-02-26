using System;
using System.Collections.Generic;
using Core.Analytics.Okg.Data;
using Il2CppDummyDll;

namespace Core.Analytics.Service.Android
{
	// Token: 0x0200128F RID: 4751
	[Token(Token = "0x200128F")]
	public class AuthAnalyticsListenerProcessor
	{
		// Token: 0x060070E6 RID: 28902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070E6")]
		[Address(RVA = "0xBB0D", Offset = "0xBB0D", VA = "0xBB0D")]
		public void Process(Dictionary<string, Dictionary<string, object>> aggregator, OkgAnalyticsData dataTemplate, string eventTheme, string eventName, IReadOnlyDictionary<string, object> properties)
		{
		/* --- GHIDRA: Process ---
		uint Core_Analytics_Service_Android_AuthAnalyticsListenerProcessor__Process
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a594b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_RefAccountInfo__get_Count__);
		    DAT_ram_00a594b3 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(int **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  if (param1_00 != (int *)0x0) {
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x140);
		          goto code_r0x8100f7f6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8100f7f6:
		    iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    if (iVar3 == 0) {
		      return 0;
		    }
		    uVar1 = 0;
		    iVar3 = func_ii_7112(iVar3,0);
		    if ((iVar3 != 0) && (*(int *)(iVar3 + 0x50) != 0)) {
		      uVar1 = (uint)(0 < *(int *)(*(int *)(iVar3 + 0x50) + 0xc));
		    }
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x060070E7 RID: 28903 RVA: 0x000147C0 File Offset: 0x000129C0
		[Token(Token = "0x60070E7")]
		[Address(RVA = "0xBB0E", Offset = "0xBB0E", VA = "0xBB0E")]
		private bool UserIsRegistered()
		{
			return default(bool);
		}

		// Token: 0x060070E8 RID: 28904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070E8")]
		[Address(RVA = "0xBB0F", Offset = "0xBB0F", VA = "0xBB0F")]
		public AuthAnalyticsListenerProcessor()
		{
		}
	}
}
