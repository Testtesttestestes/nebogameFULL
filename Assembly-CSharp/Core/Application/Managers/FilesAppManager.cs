using System;
using System.Runtime.CompilerServices;
using Core.Files;
using Core.Log.Files;
using Il2CppDummyDll;

namespace Core.Application.Managers
{
	// Token: 0x02001251 RID: 4689
	[Token(Token = "0x2001251")]
	public class FilesAppManager : IAppManager, IBaseManager, IFileManager
	{
		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x06006F22 RID: 28450 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016B2")]
		public string Name
		{
			[Token(Token = "0x6006F22")]
			[Address(RVA = "0xB99D", Offset = "0xB99D", VA = "0xB99D", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002EB RID: 747
		// (add) Token: 0x06006F23 RID: 28451 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F24 RID: 28452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002EB")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006F23")]
			[Address(RVA = "0xB99E", Offset = "0xB99E", VA = "0xB99E", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F24")]
			[Address(RVA = "0xB99F", Offset = "0xB99F", VA = "0xB99F", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002EC RID: 748
		// (add) Token: 0x06006F25 RID: 28453 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F26 RID: 28454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002EC")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006F25")]
			[Address(RVA = "0xB9A0", Offset = "0xB9A0", VA = "0xB9A0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F26")]
			[Address(RVA = "0xB9A1", Offset = "0xB9A1", VA = "0xB9A1", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x06006F27 RID: 28455 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006F28 RID: 28456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016B3")]
		public IApp Application
		{
			[Token(Token = "0x6006F27")]
			[Address(RVA = "0xB9A2", Offset = "0xB9A2", VA = "0xB9A2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F28")]
			[Address(RVA = "0xB9A3", Offset = "0xB9A3", VA = "0xB9A3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006F29 RID: 28457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F29")]
		[Address(RVA = "0xB9A4", Offset = "0xB9A4", VA = "0xB9A4")]
		public FilesAppManager(IApp app)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Application_Managers_FilesAppManager___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5a82e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Files_WebGL_FileManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo);
		    DAT_ram_00a5a82e = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x14);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x8127bdbc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,10);
		code_r0x8127bdbc:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  piVar3 = *(int **)(iVar4 + 0x10);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8127be41;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,
		                                Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                ,0);
		code_r0x8127be41:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param2_00 = *(undefined4 *)(iVar4 + 0x18);
		  param1_00 = unnamed_function_1417(Core_Files_WebGL_FileManager_TypeInfo);
		  Core_Files_WebGL_FileManager__Complete_d__1__System_Collections_IEnumerator_get_Current
		            (param1_00,param2_00,0);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  iVar4 = *(int *)(param1 + 8);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),param1,*(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006F2A RID: 28458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F2A")]
		[Address(RVA = "0xB9A5", Offset = "0xB9A5", VA = "0xB9A5", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Application_Managers_FilesAppManager__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  *(undefined4 *)(param1 + 0x14) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006F2B RID: 28459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F2B")]
		[Address(RVA = "0xB9A6", Offset = "0xB9A6", VA = "0xB9A6", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Application_Managers_FilesAppManager__Deinit
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a82f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Files_IFileManager_TypeInfo);
		    DAT_ram_00a5a82f = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Files_IFileManager_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8127bf4f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Files_IFileManager_TypeInfo,0);
		code_r0x8127bf4f:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,param3,param4,param5,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06006F2C RID: 28460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F2C")]
		[Address(RVA = "0xB9A7", Offset = "0xB9A7", VA = "0xB9A7", Slot = "11")]
		public void Load(string baseUri, string path, bool cacheOnDevice, Action<IFileContent> callback)
		{
		/* --- GHIDRA: Load ---
		void Core_Application_Managers_FilesAppManager__Load(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a831 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a831 = '\x01';
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

		/* --- GHIDRA: Load ---
		void Core_Application_Managers_FilesAppManager__Load(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a831 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a831 = '\x01';
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

		}

		// Token: 0x06006F2D RID: 28461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F2D")]
		[Address(RVA = "0xB9A8", Offset = "0xB9A8", VA = "0xB9A8", Slot = "12")]
		public void Load(string baseUri, string path, bool cacheOnDevice, Action<IFileContent> callback, FileDownloadLogger fileDownloadLogger)
		{
		}

		// Token: 0x04003A14 RID: 14868
		[Token(Token = "0x4003A14")]
		[FieldOffset(Offset = "0x10")]
		private IFileManager _fileManagerImpl;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Application_Managers_FilesAppManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a82a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a82a = '\x01';
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


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Application_Managers_FilesAppManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a82b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a82b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
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


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Application_Managers_FilesAppManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a82c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a82c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Application_Managers_FilesAppManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a82d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a82d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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

}
