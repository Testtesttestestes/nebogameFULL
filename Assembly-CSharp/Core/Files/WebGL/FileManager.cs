using System;
using System.Collections;
using Il2CppDummyDll;

namespace Core.Files.WebGL
{
	// Token: 0x02000EFA RID: 3834
	[Token(Token = "0x2000EFA")]
	public class FileManager : AbstractFileManager
	{
		// Token: 0x06005CFF RID: 23807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CFF")]
		[Address(RVA = "0x4468", Offset = "0x4468", VA = "0x4468")]
		public FileManager(int timeout)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Files_Android_FileManager___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined4 local_38;
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined4 local_20;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5acca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_FileManager__Load_d__1___
		              );
		    DAT_ram_00a5acca = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_48,0);
		  local_2c = local_40;
		  local_18 = CONCAT44(param5,(undefined4)local_18);
		  local_18 = CONCAT71(local_18._1_7_,(undefined1)param4);
		  local_38 = 0xffffffff;
		  local_34 = local_48;
		  local_24 = param3;
		  local_20 = param1;
		  local_1c = param2;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_FeedbackFormWindow__HandleCloseButton_d__12_
		            (&local_34,&local_38,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_FileManager__Load_d__1___
		            );
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Files_WebGL_FileManager___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a5a8f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_28331);
		    DAT_ram_00a5a8f6 = '\x01';
		  }
		  Core_AssetBundles_AbstractAssetBundleLoader__DontDisposeOnLoad
		            (param1,param2,param3,StringLiteral_28331,param4,param5,param5);
		  return;
		}
		*/

		}

		// Token: 0x06005D00 RID: 23808 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D00")]
		[Address(RVA = "0xA988", Offset = "0xA988", VA = "0xA988", Slot = "8")]
		protected override IEnumerator Complete(IFileContent content)
		{
		/* --- GHIDRA: Complete ---
		void Core_Files_Android_FileManager__Complete
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  local_4 = 0;
		  System_IO_Path__Combine(param1,param2,param3,param5,param4,&local_4,auStack_10);
		  return;
		}
		*/

			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: Load ---
		int Core_Files_Android_FileManager__Load(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5accb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Files_Android_FileManager__Complete_d__2_TypeInfo);
		    DAT_ram_00a5accb = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Files_Android_FileManager__Complete_d__2_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

}
