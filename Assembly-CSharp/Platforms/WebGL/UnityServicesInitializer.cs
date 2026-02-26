using System;
using Core.Application.Managers;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Platforms.WebGL
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	public class UnityServicesInitializer : IUnityServicesInitializer
	{
		// Token: 0x0600073E RID: 1854 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x5B32", Offset = "0x5B32", VA = "0x5B32", Slot = "4")]
		public UniTask Run()
		{
		/* --- GHIDRA: Run ---
		void Platforms_UnityEditor_UnityServicesInitializer__Run
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_2c;
		  undefined8 local_24;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5b83a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_UnityServicesInitializer__InitService_d__1___
		              );
		    DAT_ram_00a5b83a = '\x01';
		  }
		  local_4 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_2c,0);
		  local_10 = local_24;
		  local_1c = 0xffffffff;
		  local_18 = local_2c;
		  local_8 = param2;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_SkinManager__HandleDictChangedEvent_d__28_
		            (&local_18,&local_1c,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_UnityServicesInitializer__InitService_d__1___
		            );
		  return;
		}
		*/

		/* --- GHIDRA: Run ---
		void Platforms_WebGL_UnityServicesInitializer__Run(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b82e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5b82e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(UniTask);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x2270", Offset = "0x2270", VA = "0x2270")]
		public UnityServicesInitializer()
		{
		}
	}
}
