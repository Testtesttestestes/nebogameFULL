using System;
using Core.Files;
using Core.Gameplay.Managers.Configuration;
using Il2CppDummyDll;

namespace Core.AssetBundles.WebGL
{
	// Token: 0x02001114 RID: 4372
	[Token(Token = "0x2001114")]
	public class AssetBundleLoader : AbstractAssetBundleLoader
	{
		// Token: 0x060065FB RID: 26107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065FB")]
		[Address(RVA = "0x4469", Offset = "0x4469", VA = "0x4469")]
		public AssetBundleLoader(IFileManager fileProvider, IPlatformConfigurationProvider configurationProvider, string path, bool cacheOnDevice)
		{
		/* --- GHIDRA: .ctor ---
		void Core_AssetBundles_Android_AssetBundleLoader___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a8f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGame__TypeInfo);
		    DAT_ram_00a5a8f8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IGame__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGame__TypeInfo), iVar2 == 0)) break;
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

		/* --- GHIDRA: .ctor ---
		void Core_AssetBundles_WebGL_AssetBundleLoader___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a5a8ee == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Action__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Action_AssetBundle___Add__)
		    ;
		    DAT_ram_00a5a8ee = '\x01';
		  }
		  iVar1 = Method_System_Collections_Generic_List_Action_AssetBundle___Add__;
		  iVar2 = *(int *)(param1 + 0x28);
		  *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		  uVar3 = *(uint *)(iVar2 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		    *(uint *)(iVar2 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(iVar2 + 8) + uVar3 * 4 + 0x10) = param2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar2,param2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar1 = Method_System_Collections_Generic_List_Action__Add__;
		  iVar2 = *(int *)(param1 + 0x2c);
		  *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		  uVar3 = *(uint *)(iVar2 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		    *(uint *)(iVar2 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(iVar2 + 8) + uVar3 * 4 + 0x10) = param3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar2,param3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1 + 0x20) = *(int *)(param1 + 0x20) + 1;
		  func_ii_8824(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0400368A RID: 13962
		[Token(Token = "0x400368A")]
		public const string PLATFORM_NAME = "webgl";
	}
}
